using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Critr.Data
{
  public class ChangelistHelpers
  {
    //-------------------------------------------------------------------------

    public static Dictionary<int, Changelist> Changelists = new Dictionary<int, Changelist>();

    //-------------------------------------------------------------------------

    // Static method to load changelists from the Critr DB.

    public static void LoadChangelists()
    {
      Changelists.Clear();

      // Get changelist IDs.
      List<int> changelistIDs = new List<int>();

      SqlCommand cmd = Program.DbConnection.CreateCommand();
      cmd.CommandText =
        "SELECT id " +
        "FROM Changelist";

      using( SqlDataReader reader = cmd.ExecuteReader() )
      {
        while( reader.Read() )
        {
          changelistIDs.Add( reader.GetInt32( 0 ) );
        }
      }

      // Load the changelists.
      foreach( int id in changelistIDs )
      {
        Changelists.Add( id, new Changelist( id ) );
      }
    }

    //-------------------------------------------------------------------------
  }
}
