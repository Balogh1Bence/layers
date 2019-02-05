using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToMysqlDatabase;
using RepositoryPizza.ModelCustomer;

namespace RepositoryPizza.Repository
{
    partial class CustomersRepo
    {
        public void addcustomerToDatabase(Customer customer)
        {
            MySQLDatabase msd = new MySQLDatabase();
            MySQLDatabaseInterface mdi = msd.getDatabaseInterface();
            string query = customer.getInsertQuery();

            mdi.open();

            mdi.executeDMQuery(query);
            System.Windows.Forms.MessageBox.Show(query);

            mdi.close();

        }
    }
}
