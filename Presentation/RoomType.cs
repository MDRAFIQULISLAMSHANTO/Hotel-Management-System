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
    public partial class RoomType : Form
    {
        public RoomType()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void tbBackClick(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void RoomType_Load(object sender, EventArgs e)
        {

        }
    }
}
