using prjCustomerSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace prjCustomerSystem
{
    public partial class Form1 : Form
    {
        //List<CCustomer> list = new List<CCustomer>();
        CCustomerManager _manager = new CCustomerManager(); 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //private void dataLoad()
        //{
        //    CCustomer x = new CCustomer();
        //    x.id = "001";
        //    x.name = "Marco";
        //    x.phone = "0933654125";
        //    x.email = "marco@gmail.com";
        //    x.address = "Taipei";
        //    list.Add(x);

        //    x = new CCustomer();
        //    x.id = "002";
        //    x.name = "Selina";
        //    x.phone = "0966541258";
        //    x.email = "selina@gmail.com";
        //    x.address = "New Taipei";
        //    list.Add(x);

        //    x = new CCustomer();
        //    x.id = "008";
        //    x.name = "Kymbia";
        //    x.phone = "0932448559";
        //    x.email = "kymbia@outlook.com";
        //    x.address = "TaiChung";
        //    list.Add(x);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            _manager.moveFirst();
            displayCustomerInfo();
        }

        public void displayCustomerInfo()
        {
            CCustomer x = _manager.current;
            txtId.Text = x.id;
            txtName.Text = x.name;
            txtPhone.Text = x.phone;
            txtEmail.Text = x.email;
            txtAddress.Text = x.address;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _manager.moveLast();
            displayCustomerInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _manager.movePrevious();
            displayCustomerInfo();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _manager.moveNext();
            displayCustomerInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //try
            //{
            CCustomer x = _manager.current;
            txtId.Text = x.id;
            txtName.Text = x.name;
            txtPhone.Text = x.phone;
            txtEmail.Text = x.email;
            txtAddress.Text = x.address;

            if (txtSearch.Text == x.id)
            {

            }

           



            //    txtId.Text = list.Count;
            //    txtName.Text = list.Count;
            //    txtPhone.Text = list.Count;
            //    txtEmail.Text = list.Count;
            //    txtAddress.Text = list.Count;
            //    position = index;
            //}
            //catch
            //{
            //}
            //try
            //{
            //    int index = Array.IndexOf(names, txtSearch.Text);
            //    txtId.Text = ids[index];
            //    txtName.Text = names[index];
            //    txtPhone.Text = phones[index];
            //    txtEmail.Text = emails[index];
            //    txtAddress.Text = addresses[index];
            //}
            //catch
            //{
            //}
            //try
            //{
            //    int index = Array.IndexOf(phones, txtSearch.Text);
            //    txtId.Text = ids[index];
            //    txtName.Text = names[index];
            //    txtPhone.Text = phones[index];
            //    txtEmail.Text = emails[index];
            //    txtAddress.Text = addresses[index];
            //}
            //catch
            //{
            //}
            //try
            //{
            //    int index = Array.IndexOf(emails, txtSearch.Text);
            //    txtId.Text = ids[index];
            //    txtName.Text = names[index];
            //    txtPhone.Text = phones[index];
            //    txtEmail.Text = emails[index];
            //    txtAddress.Text = addresses[index];
            //}
            //catch
            //{
            //}
            //try
            //{
            //    int index = Array.IndexOf(addresses, txtSearch.Text);
            //    txtId.Text = ids[index];
            //    txtName.Text = names[index];
            //    txtPhone.Text = phones[index];
            //    txtEmail.Text = emails[index];
            //    txtAddress.Text = addresses[index];
            //}
            //catch
            //{
            //}

        }
    }
}
