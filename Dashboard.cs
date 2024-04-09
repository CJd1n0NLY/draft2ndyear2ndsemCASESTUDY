using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void lblAvailableUnit_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.BackColor = Color.DimGray;
            lblCheckIcon.BackColor = Color.DimGray;
            lblOccupiedUnit.BackColor = Color.Transparent;
            lblOccuIcon.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }

        private void lblCheckIcon_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.BackColor = Color.DimGray;
            lblCheckIcon.BackColor = Color.DimGray;
            lblOccupiedUnit.BackColor = Color.Transparent;
            lblOccuIcon.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }

        private void lblOccupiedUnit_Click(object sender, EventArgs e)
        {
            lblOccuIcon.BackColor = Color.DimGray;
            lblOccupiedUnit.BackColor = Color.DimGray;
            lblCheckIcon.BackColor = Color.Transparent;
            lblAvailableUnit.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = false;
            pnlOccUnit.Visible = true;
        }

        private void lblOccuIcon_Click(object sender, EventArgs e)
        {
            lblOccuIcon.BackColor = Color.DimGray;
            lblOccupiedUnit.BackColor = Color.DimGray;
            lblCheckIcon.BackColor = Color.Transparent;
            lblAvailableUnit.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = false;
            pnlOccUnit.Visible = true;
        }
    }
}
