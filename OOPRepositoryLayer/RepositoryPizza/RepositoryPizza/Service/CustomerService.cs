using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPizza.pizzaExceptions;
using RepositoryPizza.Repository;
using RepositoryPizza.ModelCustomer;

namespace RepositoryPizza.Service
{
    class CustomerService
    {
        CustomersRepo cr;

        public CustomerService()
        {
            cr = new CustomersRepo();
        }

        public DataTable LoadCustomerData()
        {
            return cr.getCustomersDataTable();
        }

        internal void addCustomer(Customer newCustomer)
        {
            if (!cr.checkExist(newCustomer))
            {
                cr.addCustomer(newCustomer);
                cr.addcustomerToDatabase(newCustomer);
                
            }
            else
            {
                throw new CustomerServiceException(newCustomer.getName() + " already exists.");
            }
        }

        public void editCustomerData()
        {
            
        }
    }
}
