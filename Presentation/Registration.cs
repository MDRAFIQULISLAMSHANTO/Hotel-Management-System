using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entities;
using DataAccess;


namespace Presentation
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
        private void RegisterClick(object sender, EventArgs e)
        {
            var name = tbName.Text;
            
            var Phone = tbPhone.Text;
            var Country = tbCountry.Text;
            var username = tbUsername.Text;
            var password = tbPassword.Text;
            Guest gues = new Guest();
            gues.GuestName = name;
            gues.GuestPhone = Phone;
            gues.GuestCountry = Country;
            gues.GuestUserName = username;
            gues.GuestPassword = password;
            Database db = new Database();
            var r = db.Guests.Insert(gues);
            if (r)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        

        private void tbnBackClick(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
