using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPizza.ModelCustomer
{
    partial class Customer
    {
        internal string getInsertQuery()
        {
            return "INSERT INTO `pvevo` (`vazon`, `vnev`, `vcim`) VALUES ('" + getId() + "', '" + getName() + "', '" + 
                getAddress() + "');";
        }
    }
}
