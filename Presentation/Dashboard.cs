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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void RaClick(object sender, EventArgs e)
        {

        }

        private void ResClick(object sender, EventArgs e)
        {
            
        }

        private void RtClick(object sender, EventArgs e)
        {
            this.Hide();
            new RoomType().Show();
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
             
        }
    }
}
