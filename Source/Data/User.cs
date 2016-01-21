using System;
using System.Data.SqlClient;

namespace Critr.Data
{
  class User
  {
    //-------------------------------------------------------------------------

    public int Id { get; private set; }
    public bool Enabled { get; private set; }
    public string Username { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; private set; }
    public bool IsReviewCreator { get; private set; }
    public bool IsReviewer { get; private set; }
    public bool IsReviewCandidate { get; private set; }

    //-------------------------------------------------------------------------

    public User( int id )
    {
      Id = id;
      Enabled = false;
      Username = "Unknown";
      FirstName = "Unknown";
      LastName = "Unknown";
      Password = "123454321";
      IsReviewCreator = false;
      IsReviewer = false;
      IsReviewCandidate = false;

      LoadDataFromDb();
    }

    //-------------------------------------------------------------------------

    private void LoadDataFromDb()
    {
      SqlCommand cmd = Program.DbConnection.Critr.CreateCommand();
      cmd.CommandText =
        "SELECT " +
          /* 0 */"enabled," +
          /* 1 */"firstName," +
          /* 2 */"lastName," +
          /* 3 */"password," +
          /* 4 */"sourceControlUsername," +
          /* 5 */"email," +
          /* 6 */"isReviewCreator," +
          /* 7 */"isReviewer," +
          /* 8 */"isReviewCandidate " +
        "FROM User " +
        "WHERE id=" + Id;
      
      using( SqlDataReader reader = cmd.ExecuteReader() )
      {
        if( reader.HasRows == false )
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
  }
}
