using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LICTTest
{
    class Program
    {
        static System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
        static void Main(string[] args)
        {

            System.Windows.Forms.Form frm = new System.Windows.Forms.Form();

           

            txt.Location = new System.Drawing.Point(20, 20);

            frm.Controls.Add(txt);

            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();

            btn.Location = new System.Drawing.Point(20, 100);
            btn.Text = "click me";


            btn.Click += btn_Click;

            frm.Controls.Add(btn);

            frm.ShowDialog();

            Console.ReadKey();
        }

        static void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt.Text);
        }
    }
}
