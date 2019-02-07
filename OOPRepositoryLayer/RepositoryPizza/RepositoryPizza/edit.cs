using RepositoryPizza.ModelCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositoryPizza
{
    public partial class Edit : Form
    {
        private Customer k;
        public Edit(Customer k)
        {

            this.k = k;
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            textBox1.Text = k.getId().ToString();
            textBox2.Text = k.getName();
            textBox3.Text = k.getAddress();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            k.setId(Convert.ToInt32(textBox1.Text));
            k.setName(textBox2.Text);
            k.setAddress(textBox3.Text);
        }
    }
}
