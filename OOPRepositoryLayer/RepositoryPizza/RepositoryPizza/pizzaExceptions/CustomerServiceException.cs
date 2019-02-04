using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPizza.pizzaExceptions
{
    class CustomerServiceException : Exception
    {
        public CustomerServiceException(string message)
            : base(message)
        {

        }
    }
}
