using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private object db;

        public Form1()
        {
            InitializeComponent();
            Database db = new Database();
        }

      

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TbUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginClick(object sender, EventArgs e)
        {
            
            string uname = tbUname.Text;
            string pass = tbPass.Text;
            
            Database db = new Database();
            try
            {
                bool rs = db.Guests.CheckLogin(uname, pass);
                if (rs == true)
                {
                    this.Hide();
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Invalid Usename/ password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tnSignUp(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
