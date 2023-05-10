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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmStaff frmStaff = new FrmStaff();
            frmStaff.MdiParent = this;
            frmStaff.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 關閉目前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            this.ActiveMdiChild.Close();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while(this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void 水平排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 垂直排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 階梯式排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}
