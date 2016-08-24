using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLICT2
{
    public partial class frmMain : Form
    {
        frmCity city = new frmCity();
        frmUnit unit = new frmUnit();
        frmBrand brand = new frmBrand();
        frmCatagory catagory = new frmCatagory();
        frmProduct product = new frmProduct();

        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = "Current Date And Time :"+ DateTime.Now.ToString();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e) //city form
        {
            if (city.IsDisposed)
                city = new frmCity();

            city.MdiParent = this;       //MdiParent used for place the forms inside of main form
            city.BringToFront();         //BringToFront used for if clicked tthe city menu it will bring the city form infront of other's...others are also same
            city.Show();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e) //unit form
        {
            if (unit.IsDisposed)
                unit = new frmUnit();

            unit.MdiParent = this;
            unit.BringToFront();
            unit.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e) // brand form
        {
            if (brand.IsDisposed)
                brand = new frmBrand();

            brand.MdiParent = this;
            brand.BringToFront();
            brand.Show();
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e) //catagory form
        {
            if (catagory.IsDisposed)
                catagory = new frmCatagory();

            catagory.Show();
            catagory.BringToFront();
            catagory.MdiParent = this;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e) //product form
        {
            if (product.IsDisposed)
                product = new frmProduct();

            product.Show();
            product.BringToFront();
            product.MdiParent = this;
        }
    }
}
