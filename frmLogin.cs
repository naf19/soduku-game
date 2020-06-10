using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (MainClass.login(txtusername.Text, txtpassword.Text))
                {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid details");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MainClass.populateusrs();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
             
        }
    }
}
