
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepositoryPizza.ModelCustomer;
using ConnectToMysqlDatabase;
using System.Data;

namespace RepositoryPizza.Repository
{
    partial class CustomersRepo
    {
        List<Customer> customers;

        public CustomersRepo()
        {
            customers = new List<Customer>();
            fillCustomersListFromDatabase();
        }

        public DataTable getCustomersDataTable()
        {
            DataTable cDT = new DataTable();
            cDT.Columns.Add("Azonosító",typeof(int));
            cDT.Columns.Add("Vevő név", typeof(string));
            cDT.Columns.Add("Cím", typeof(string));
            foreach(Customer c in customers)
            {
                cDT.Rows.Add(c.getId(), c.getName(), c.getAddress());
            }
            return cDT;
        }

        internal bool checkExist(Customer newCustomer)
        {
            foreach (Customer c in customers)
            {
                if (c.getId() == newCustomer.getId())
                {
                    return true;
                }
            }

            return false;

        }

        internal void addCustomer(Customer newCustomer)
        {
            customers.Add(newCustomer);
        }

        private void fillCustomersListFromDatabase()
        {
            MySQLDatabase md = new MySQLDatabase();
            MySQLDatabaseInterface mdi = md.getDatabaseInterface();
            mdi.open();
            string query = "SELECT * FROM pvevo ";
            DataTable dtCustomer = mdi.getToDataTable(query);
            mdi.close();

            foreach(DataRow row in dtCustomer.Rows)
            {
                int customerID = Convert.ToInt32(row["vazon"].ToString());
                string customerName = row["vnev"].ToString();
                string customerAddress = row["vcim"].ToString();
                Customer c = new Customer(customerID, customerName, customerAddress);
                customers.Add(c);
            }
        }
        public void modifyList(Customer c)
            {
            int id=c.getId();
                customers[id].setName(c.getName());
                customers[id].setAddress(c.getAddress());
    }
}
