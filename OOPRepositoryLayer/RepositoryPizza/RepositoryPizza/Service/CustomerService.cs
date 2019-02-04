﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepositoryPizza.Repository;
using RepositoryPizza.TableClasses;

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
            cr.addCustomer(newCustomer);
        }
    }
}