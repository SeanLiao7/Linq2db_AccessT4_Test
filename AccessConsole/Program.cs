using System;
using System.Diagnostics;
using System.Linq;
using AccessConsole.Repository;

namespace AccessConsole
{
    internal class Program
    {
        // 若在x64環境，必須使用x64的 Database (必須安裝Microsoft 套件)
        // Define 於此專案的 Configuration 的 "條件式編譯符號"
        //#if x64
        private const string ProviderStr = "Provider=Microsoft.ACE.OLEDB.12.0;";

        //#else
        //private const string ProviderStr = "Provider=Microsoft.Jet.OLEDB.4.0;";
        //#endif
        private static void Main( string[ ] args )
        {
            ////var path = System.Environment.CurrentDirectory;
            //const string path = @"..\..\Db\ProjectData.accdb";
            //var connectString = ProviderStr;
            //connectString += "Data Source=" + path + ";";
            //connectString += "Jet OLEDB:Database Password=" + "12459115";
            //using ( var db = new AccessGenericRepository<IC_INFO>( connectString ) )
            //{
            //    var data = db.ReadAll( );
            //    var target = data.Single( x => x.ICINFO_KEY == "p1" );
            //    var delete = data.FirstOrDefault( x => x.ICINFO_KEY == "333" );
            //    target.ICINFO_VALUE = "ppap4545454";
            //    db.Update( target );
            //    db.Delete( delete );
            //    //db.Create( new IC_INFO { ICINFO_KEY = "YY", ICINFO_VALUE = "rr" } );
            //    foreach ( var x in data )
            //    {
            //        Console.WriteLine( $"Key : {x.ICINFO_KEY}, Value : {x.ICINFO_VALUE}" );
            //    }
            //}
            //Console.Read( );

            TreeOfError2( );
        }

        private static void SingleBadThing( )
        {
            throw new NotImplementedException( );
        }

        private static void TreeOfError( )
        {
            try
            {
                SingleBadThing( );
            }
            catch ( Exception ex )
            {
                // Reported on Call Stack.
                throw;
            }
        }

        private static void TreeOfError2( )
        {
            try
            {
                SingleBadThing( ); // Reported on Call Stack.
            }
            catch ( Exception ex ) when ( false )
            {
                Console.WriteLine( "Can't happen" );
            }
        }
    }
}