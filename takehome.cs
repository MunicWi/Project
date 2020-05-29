using MySql.Data.MySqlClient;
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
    public partial class take_home : Form
    {
        string SelectMenuTakeHome;
        string ManySet;
        string ig_name;
        string ig_price;
        string ig_group;
        int sum;
        string sumstring;
        public take_home()
        {
            InitializeComponent();
        }

        private void take_home_Load(object sender, EventArgs e)
        {
            SelectMenuTakeHome = "4";
            ManySet = numericUpDown1.Text;
        }

        private void Menu199_CheckedChanged(object sender, EventArgs e)
        {
            SelectMenuTakeHome = "4";
        }

        private void Menu259_CheckedChanged(object sender, EventArgs e)
        {
            SelectMenuTakeHome = "5";
        }

        private void Menu299_CheckedChanged(object sender, EventArgs e)
        {
            SelectMenuTakeHome = "6";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ManySet = numericUpDown1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
            ManySet = numericUpDown1.Text;
            try
            {
                string receipt = "WN-" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
                con.Open(); //เรียกข้อมูลอาหาร
                string sql1 = "SELECT * FROM neworder WHERE id_order='" + SelectMenuTakeHome + "'";
                //MessageBox.Show("'" + SelectMenuTakeHome + "'");
                //MessageBox.Show(sql1);
                MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    ig_name = reader1.GetString("name_order");
                    ig_price = reader1.GetString("prices_order");
                    ig_group = reader1.GetString("group_order");
                }
                con.Close();

                con.Open(); //เซฟข้อมูลลงใบเสร็จ
                int a = Convert.ToInt32(ig_price);
                int b = Convert.ToInt32(ManySet);
                sum = a * b;
                //sum = int.Parse(ig_price) * int.Parse(Program.manypeoplebuffe);
                sumstring = sum.ToString();

                string sql2 = "INSERT INTO receipt(name_receipt, number_receipt, prices_receipt, user_receipt, date_receipt, no_receipt, group_receipt) VALUES('" + ig_name + "', '" + ManySet + "', '" + sumstring + "', '" + Program.username + "', '" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + receipt + "', '" + ig_group + "')";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {

                }
                con.Close();


                con.Open(); //crate status_login By no_receipt การค้างบิล เช็คสถานะโดยการเอาที่เลขใบเสร็จใส่ลงไป
                string sql3 = "UPDATE login SET status_login='" + receipt + "' WHERE Username = '" + Program.username + "';";
                MySqlCommand cmd3 = new MySqlCommand(sql3, con);
                MySqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {

                }
                con.Close();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");

                confirm ST = new confirm();
                ST.ShowDialog();

            }
            catch (Exception ex)//การเกิดข้อผิดพลาด
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + ex);
            }
        }
    }
}
