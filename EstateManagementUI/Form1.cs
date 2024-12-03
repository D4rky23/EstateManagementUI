using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateManagementUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Form2 clientForm = new Form2(); 
            clientForm.Show(); 
            this.Hide();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Form3 adminForm = new Form3(); 
            adminForm.Show(); 
            this.Hide(); 
        }
    }
}
