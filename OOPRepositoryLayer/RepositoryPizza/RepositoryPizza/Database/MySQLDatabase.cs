using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectToMysqlDatabase
{
    class MySQLDatabase
    {
        public MySQLDatabaseInterface getDatabaseInterface()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi.setErrorToUserInterface(true);
            mdi.setErrorToGraphicalUserInterface(false);
            mdi.setConnectionServerData("localhost", "pizza","3306");
            mdi.setConnectionUserData("root", "");
            mdi.makeConnectionToDatabase();        

            return mdi;
        }
    }
}
