using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _331YektaAL2.DönemPerformans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 frm1 = new Form1();
        public static Menu frm2 = new Menu();
        public static Form2 frm3 = new Form2 ();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3.Show();
            
        }
    }
}
