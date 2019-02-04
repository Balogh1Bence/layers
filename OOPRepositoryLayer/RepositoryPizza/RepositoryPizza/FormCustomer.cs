using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RepositoryPizza.Service;
using RepositoryPizza.TableClasses;

namespace RepositoryPizza
{
    public partial class FormCustomer : Form
    {
        CustomerService cs;

        public FormCustomer()
        {
            cs = new CustomerService();
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource =
                cs.LoadCustomerData();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Customer hofeherke = new Customer(8, "Hófehérke", "Erdő utca 8");
            cs.addCustomer(hofeherke);

            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.DataSource = cs.LoadCustomerData();

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
