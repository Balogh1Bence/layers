using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPizza.TableClasses
{
    class Customer
    {
        private int id;
        private string name;
        private string address;

        public Customer(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }

        public override string ToString()
        {
            return id+" "+name+" "+address;
        }
    }
}
