using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table t = new table();
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            take_home take = new take_home();
            take.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void select_Load(object sender, EventArgs e)
        {

        }
    }
}
