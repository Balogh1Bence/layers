﻿using System;
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
        public string getUpdateQuery()
        {
            int id = getId();
            return "UPDATE `pvevo` SET `vazon`="+id+",`vnev`="+getName()+",`vcim`="+getAddress()+" WHERE vazon='"+id+"'";
        }
    }
}
