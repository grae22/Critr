using System;
using System.Data.SqlClient;

namespace Critr.Data
{
  public class User
  {
    //-------------------------------------------------------------------------

    public int Id { get; private set; }
    public bool Enabled { get; set; }
    public string Username { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; private set; }
    public bool IsReviewCreator { get; set; }
    public bool IsReviewer { get; set; }
    public bool IsReviewCandidate { get; set; }

    //-------------------------------------------------------------------------

    // Creates a user object and populates it from the DB.

    public User( int id )
    {
      Id = id;
      Enabled = false;
      Username = "Unknown";
      FirstName = "Unknown";
      LastName = "Unknown";
      Password = "123454321";
      Email = "Unknown";
      IsReviewCreator = false;
      IsReviewer = false;
      IsReviewCandidate = false;

      LoadDataFromDb();
    }

    //-------------------------------------------------------------------------

    public User(
      bool enabled,
      string username,
      string firstName,
      string lastName,
      string password,
      string email,
      bool isReviewCreator,
      bool isReviwer,
      bool isReviewCandidate )
    {
      // Set class vars.
      Enabled = enabled;
      Username = username;
      FirstName = firstName;
      LastName = lastName;
      Password = password;
      Email = email;
      IsReviewCreator = isReviewCreator;
      IsReviewer = IsReviewer;
      IsReviewCandidate = isReviewCandidate;

      // Username already exists?
      SqlCommand cmd = Program.DbConnection.CreateCommand();
      cmd.CommandText =
        "SELECT id " +
        "FROM [User] " +
        "WHERE sourceControlUsername='" + Username + "'";

      object ob = cmd.ExecuteScalar();

      if( ob != null )
      {
        throw new Exception( "User already exists with username '" + Username + "'." );
      }

      // Add to the db.
      cmd = Program.DbConnection.CreateCommand();
      cmd.CommandText =
        "INSERT INTO [User]( " +
          "enabled, " +
          "firstName, " +
          "lastName, " +
          "password, " +
          "sourceControlUsername, " +
          "email, " +
          "isReviewCreator, " +
          "isReviewer, " +
          "isReviewCandidate ) " +
        "VALUES ( " +
          '\'' + Enabled + "', " +
          '\'' + FirstName + "', " +
          '\'' + LastName + "', " +
          '\'' + Password + "', " +
          '\'' + Username + "', " +
          '\'' + Email + "', " +
          '\'' + IsReviewCreator + "', " +
          '\'' + IsReviewer + "', " +
          '\'' + IsReviewCandidate + "' )";

      int rowCount = cmd.ExecuteNonQuery();

      if( rowCount < 1 )
      {
        throw new Exception( "Failed to insert user '" + Username + "' into User table." );
      }
    }

    //-------------------------------------------------------------------------

    private void LoadDataFromDb()
    {
      SqlCommand cmd = Program.DbConnection.CreateCommand();
      cmd.CommandText =
        "SELECT " +
          /* 0 */"enabled, " +
          /* 1 */"firstName, " +
          /* 2 */"lastName, " +
          /* 3 */"password, " +
          /* 4 */"sourceControlUsername, " +
          /* 5 */"email, " +
          /* 6 */"isReviewCreator, " +
          /* 7 */"isReviewer, " +
          /* 8 */"isReviewCandidate " +
        "FROM [User] " +
        "WHERE id=" + Id;
      
      using( SqlDataReader reader = cmd.ExecuteReader() )
      {
        if( reader.Read() == false )
        {
          throw new Exception(
            "No user found with id " + Id + '.' );
        }

        Enabled = reader.GetBoolean( 0 );
        FirstName = reader.GetString( 1 );
        LastName = reader.GetString( 2 );
        Password = reader.GetString( 3 );
        Username = reader.GetString( 4 );
        Email = reader.GetString( 5 );
        IsReviewCreator = reader.GetBoolean( 6 );
        IsReviewer = reader.GetBoolean( 7 );
        IsReviewCandidate = reader.GetBoolean( 8 );
      }
    }

    //-------------------------------------------------------------------------

    public void WriteToDb()
    {
      SqlCommand cmd = Program.DbConnection.CreateCommand();
      cmd = Program.DbConnection.CreateCommand();
      cmd.CommandText =
        "UPDATE [User] " +
          "SET " +
          "enabled='" + Enabled + "', " +
          "firstName='" + FirstName + "', " +
          "lastName='" + LastName + "', " +
          "password='" + Password + "', " +
          "email='" + Email + "', " +
          "isReviewCreator='" + IsReviewCreator + "', " +
          "isReviewer='" + IsReviewer + "', " +
          "isReviewCandidate='" + IsReviewCandidate + "' " +
        "WHERE id=" + Id;

      int rowCount = cmd.ExecuteNonQuery();

      if( rowCount < 1 )
      {
        throw new Exception( "Failed to update user '" + Username + "' in User table." );
      }
    }

    //-------------------------------------------------------------------------

    override public string ToString()
    {
      return Username;
    }

    //-------------------------------------------------------------------------
  }
}
