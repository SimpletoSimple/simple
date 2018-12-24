using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMDI
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            childOne one = new childOne();
            one.MdiParent = this;
            one.Show();

            childTwo two = new childTwo();
            two.MdiParent = this;
            two.Show();


            childThree three = new childThree();
            three.MdiParent = this;
            three.Show();
        }

        private void cascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
          
        }
    }
}
