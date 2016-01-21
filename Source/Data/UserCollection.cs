using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Critr.Data
{
  class UserCollection
  {
    //-------------------------------------------------------------------------

    public List< User > Users { get; private set; }

    //-------------------------------------------------------------------------

    public UserCollection()
    {
      LoadFromDb();
    }

    //-------------------------------------------------------------------------

    private void LoadFromDb()
    {
      SqlCommand cmd = Program.DbConnection.Critr.CreateCommand();
      cmd.CommandText =
        "SELECT id " +
        "FROM User " +
        "ORDER BY sourceControlUsername";

      using( SqlDataReader reader = cmd.ExecuteReader() )
      {
        while( reader.Read() )
        {
          Users.Add( new User( reader.GetInt32( 0 ) ) );
        }
      }
    }

    //-------------------------------------------------------------------------
  }
}
