using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Critr.Utils;
using Critr.Db;
using Critr.UI;
using Critr.Data;

namespace Critr
{
  static class Program
  {
    //-------------------------------------------------------------------------

    public static Settings Settings { get; private set; }
    public static DbConnection DbConnection { get; private set; }
    public static Log Log { get; private set; }
    public static UserCollection UserCollection { get; private set; }

    //-------------------------------------------------------------------------

    [STAThread]
    static void Main( string[] args )
    {
      // Initialise the log.
      Log =
        new Log(
          Path.GetDirectoryName( Assembly.GetExecutingAssembly().FullName ) + "Critr.log",
          1000 );

      // Settings.
      try
      {
        Settings = new Settings();
        Settings.Initialise();
      }
      catch( Exception ex )
      {
        Log.AddEntry( ex );
        MessageBox.Show( ex.Message,
                         "Settings Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error );
      }

      // Db.
      try
      {
        // Try connect to the databases.
        try
        {
          DbConnection = DbConnection.Instance;
        }
        catch( Exception ex )
        {
          Log.AddEntry( ex );
          MessageBox.Show( ex.Message,
                           "Database Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error );
          return;
        }

        // Connected to Bugtraq?
        if( DbConnection.Critr.State != System.Data.ConnectionState.Open )
        {
          Log.AddEntry(
            Log.EntryType.ERROR,
            "Failed to connect to the Bugtraq database." );

          MessageBox.Show( "Failed to connect to the Bugtraq database.",
                           "Database Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error );
        }
      }
      catch( Exception ex )
      {
        Log.AddEntry( ex );
        MessageBox.Show( ex.Message,
                         "Database Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error );
      }

      // User collection.
      UserCollection = new UserCollection();

      // Start the app.
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault( false );
      Application.Run( new MainForm() );

      // Shutdown.
      Settings.SaveToFile();
      Log.AddInfo( "Shutdown." );
    }

    //-------------------------------------------------------------------------
  }
}
