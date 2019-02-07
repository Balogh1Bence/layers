using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepositoryPizza.pizzaExceptions;
using RepositoryPizza.Service;
using RepositoryPizza.ModelCustomer;

namespace RepositoryPizza
{
    public partial class FormCustomer : Form
    {
        CustomerService cs;

        public FormCustomer()
        {
            cs = new CustomerService();
            InitializeComponent();
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource =
                cs.LoadCustomerData();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                errorProviderNewButton.Clear();
                Customer hofeherke = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text,textBox3.Text);
                cs.addCustomer(hofeherke);

                dataGridViewCustomers.DataSource = null;
                dataGridViewCustomers.DataSource = cs.LoadCustomerData();
            }
            catch (CustomerServiceException cse)
            {
                errorProviderNewButton.SetError(buttonNew, cse.Message);
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(dataGridViewCustomers.SelectedRows.Count>1)
            {
                dataGridViewCustomers.ClearSelection();
                return;
            }
            Customer c = new Customer(Convert.ToInt32(dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString()), dataGridViewCustomers.SelectedRows[0].Cells[1].Value.ToString(), dataGridViewCustomers.SelectedRows[0].Cells[2].Value.ToString());
            Edit edit = new Edit(c);
            edit.Show();
            int azon;
            string nev;
            string cim;
            cs.editCustomerData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
