using prjCustomerSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCustomerSystem
{
    public partial class FrmLogin : Form
    {
        bool isClosed = true;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CStaff c = (new CStaffManager()).queryByEmail(txtEmail.Text);
            if (c != null)
            {
                if(c.password==txtPassword.Text) 
                { 
                    isClosed = false;
                    Close();
                    return;
                }
            }
            MessageBox.Show("帳號與密碼不符");
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }
    }

}
