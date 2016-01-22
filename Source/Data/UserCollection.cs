using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using Critr.Utils;

namespace Critr.Data
{
  class UserCollection
  {
    //-------------------------------------------------------------------------

    public List<User> Users { get; private set; }

    //-------------------------------------------------------------------------

    public UserCollection()
    {
      Users = new List<User>();

      LoadFromDb();
      LoadFromP4();
    }

    //-------------------------------------------------------------------------

    private void LoadFromDb()
    {
      // Compile a list of user IDs.
      List<int> userIDs = new List<int>();

      SqlCommand cmd = Program.DbConnection.Critr.CreateCommand();
      cmd.CommandText =
        "SELECT id " +
        "FROM [User] " +
        "ORDER BY sourceControlUsername";

      using( SqlDataReader reader = cmd.ExecuteReader() )
      {
        while( reader.Read() )
        {
          userIDs.Add( reader.GetInt32( 0 ) );
        }
      }

      // Create each user.
      foreach( int id in userIDs )
      {
        User user = new User( id );
        Users.Add( user );

        //Program.Log.AddEntry(
        //  Log.EntryType.INFO,
        //  "Added user '" + user.Username + "' from DB." );
      }
    }

    //-------------------------------------------------------------------------

    private void LoadFromP4()
    {
      // Query P4 for all users.
      Process p = new Process();
      p.StartInfo.UseShellExecute = false;
      p.StartInfo.RedirectStandardOutput = true;
      p.StartInfo.FileName = "p4.exe";
      p.StartInfo.Arguments = "users";
      p.Start();

      string output = p.StandardOutput.ReadToEnd();
      p.WaitForExit( 1000 );

      // Split the output into individual lines.
      string[] lines = output.Split( new string[] { Environment.NewLine }, StringSplitOptions.None );

      // The username is the first thing on each line followed by a space char.
      foreach( string line in lines )
      {
        if( line.IndexOf( ' ' ) < 0 )
        {
          continue;
        }

        string username = line.Substring( 0, line.IndexOf( ' ' ) );

        //Program.Log.AddEntry(
        //  Log.EntryType.INFO,
        //  "Found user '" + username + "' in P4." );

        try
        {
          if( GetUser( username ) != null )
          {
            continue;
          }

          User user =
            new User(
              false,
              username,
              "Unknown",
              "Unknown",
              "123454321",
              "Unknown",
              false,
              false,
              false );

          Users.Add( user );

          //Program.Log.AddEntry(
          //  Log.EntryType.INFO,
          //  "Added user '" + user.Username + "' to DB." );
        }
        catch( Exception ex )
        {
          Program.Log.AddEntry(
            Log.EntryType.ERROR,
            "Error while creating a user: " + ex.Message );
        }
      }
    }

    //-------------------------------------------------------------------------

    public User GetUser( string username )
    {
      if( username == null )
      {
        return null;
      }

      username = username.ToLower();

      foreach( User user in Users )
      {
        if( username == user.Username.ToLower() )
        {
          return user;
        }
      }

      return null;
    }

    //-------------------------------------------------------------------------
  }
}
