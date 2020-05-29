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
    public partial class table : Form
    {
        string table1="";
        
        public table()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            showtable.Text = "A01";//เก็บค่าไว้ใน text box ชั่วคราว
        }

        private void A2_Click(object sender, EventArgs e)
        {
            showtable.Text = "A02";
        }

        private void A3_Click(object sender, EventArgs e)
        {
            showtable.Text = "A03";
        }

        private void A4_Click(object sender, EventArgs e)
        {
            showtable.Text = "A04";
        }

        private void A5_Click(object sender, EventArgs e)
        {
            showtable.Text = "A05";
        }

        private void A6_Click(object sender, EventArgs e)
        {
            showtable.Text = "A06";
        }

        private void A7_Click(object sender, EventArgs e)
        {
            showtable.Text = "A07";
        }

        private void A8_Click(object sender, EventArgs e)
        {
            showtable.Text = "A08";
        }

        private void A9_Click(object sender, EventArgs e)
        {
            showtable.Text = "A09";
        }

        private void A10_Click(object sender, EventArgs e)
        {
            showtable.Text = "A10";
        }

        private void A11_Click(object sender, EventArgs e)
        {
            showtable.Text = "A11";
        }

        private void A12_Click(object sender, EventArgs e)
        {
            showtable.Text = "A12";
        }

        private void A13_Click(object sender, EventArgs e)
        {
            showtable.Text = "A13";
        }

        private void A14_Click(object sender, EventArgs e)
        {
            showtable.Text = "A14";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showtable.Text = "A15";
        }

        private void A16_Click(object sender, EventArgs e)
        {
            showtable.Text = "A16";
        }

        private void table_Load(object sender, EventArgs e)//เมื่อมันเด้งขึ้นมาให้ทำอะไรได้บ้าง ทำการตรวจสอบว่าโต๊ะว่างไหม
        {
           // string[] table = { "0", "0", "0","0","0","0","0","0","0","0","0","0","0","0","0","0" };
            MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
            try
            {
                con.Open();//ตรวจสอบโต๊ะว่างไหม
                string sql = "SELECT * FROM table";
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A01';", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                   {
                    table1 = reader.GetString("status_table");//เช็คสถานะ ดึงข้อมูลว่าว่างไหม ถ้าว่าง ให้เปลี่ยนจากสีเเดง เป็นสีเขียว เเล้วก็กดปุ่มได้
                    if (table1 == "")
                    {
                        A1.BackColor = System.Drawing.Color.Green;
                        A1.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A02';", con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    table1 = reader2.GetString("status_table");
                    if (table1 == "")
                    {
                        A2.BackColor = System.Drawing.Color.Green;
                        A2.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A03';", con);
                MySqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    table1 = reader3.GetString("status_table");
                    if (table1 == "")
                    {
                        A3.BackColor = System.Drawing.Color.Green;
                        A3.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd4 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A04';", con);
                MySqlDataReader reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    table1 = reader4.GetString("status_table");
                    if (table1 == "")
                    {
                        A4.BackColor = System.Drawing.Color.Green;
                        A4.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd5 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A05';", con);
                MySqlDataReader reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    table1 = reader5.GetString("status_table");
                    if (table1 == "")
                    {
                        A5.BackColor = System.Drawing.Color.Green;
                        A5.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd6 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A06';", con);
                MySqlDataReader reader6 = cmd6.ExecuteReader();
                while (reader6.Read())
                {
                    table1 = reader6.GetString("status_table");
                    if (table1 == "")
                    {
                        A6.BackColor = System.Drawing.Color.Green;
                        A6.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd7 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A07';", con);
                MySqlDataReader reader7 = cmd7.ExecuteReader();
                while (reader7.Read())
                {
                    table1 = reader7.GetString("status_table");
                    if (table1 == "")
                    {
                        A7.BackColor = System.Drawing.Color.Green;
                        A7.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd8 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A08';", con);
                MySqlDataReader reader8 = cmd8.ExecuteReader();
                while (reader8.Read())
                {
                    table1 = reader8.GetString("status_table");
                    if (table1 == "")
                    {
                        A8.BackColor = System.Drawing.Color.Green;
                        A8.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd9 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A09';", con);
                MySqlDataReader reader9 = cmd9.ExecuteReader();
                while (reader9.Read())
                {
                    table1 = reader9.GetString("status_table");
                    if (table1 == "")
                    {
                        A9.BackColor = System.Drawing.Color.Green;
                        A9.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd10 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A10';", con);
                MySqlDataReader reader10 = cmd10.ExecuteReader();
                while (reader10.Read())
                {
                    table1 = reader10.GetString("status_table");
                    if (table1 == "")
                    {
                        A10.BackColor = System.Drawing.Color.Green;
                        A10.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd11 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A11';", con);
                MySqlDataReader reader11 = cmd11.ExecuteReader();
                while (reader11.Read())
                {
                    table1 = reader11.GetString("status_table");
                    if (table1 == "")
                    {
                        A11.BackColor = System.Drawing.Color.Green;
                        A11.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd12 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A12';", con);
                MySqlDataReader reader12 = cmd12.ExecuteReader();
                while (reader12.Read())
                {
                    table1 = reader12.GetString("status_table");
                    if (table1 == "")
                    {
                        A12.BackColor = System.Drawing.Color.Green;
                        A12.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd13 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A13';", con);
                MySqlDataReader reader13 = cmd13.ExecuteReader();
                while (reader13.Read())
                {
                    table1 = reader13.GetString("status_table");
                    if (table1 == "")
                    {
                        A13.BackColor = System.Drawing.Color.Green;
                        A13.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd14 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A14';", con);
                MySqlDataReader reader14 = cmd14.ExecuteReader();
                while (reader14.Read())
                {
                    table1 = reader14.GetString("status_table");
                    if (table1 == "")
                    {
                        A14.BackColor = System.Drawing.Color.Green;
                        A14.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd15 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A15';", con);
                MySqlDataReader reader15 = cmd15.ExecuteReader();
                while (reader15.Read())
                {
                    table1 = reader15.GetString("status_table");
                    if (table1 == "")
                    {
                        A15.BackColor = System.Drawing.Color.Green;
                        A15.Enabled = true;
                    }
                }
                con.Close();
                con.Open();
                MySqlCommand cmd16 = new MySqlCommand("SELECT * FROM seat WHERE name_table = 'A16';", con);
                MySqlDataReader reader16 = cmd16.ExecuteReader();
                while (reader16.Read())
                {
                    table1 = reader16.GetString("status_table");
                    if (table1 == "")
                    {
                        A16.BackColor = System.Drawing.Color.Green;
                        A16.Enabled = true;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (showtable.Text == "")
            {
                MessageBox.Show("กรุณาเลือกที่นั่ง");
            }
            else
            {
                Program.selectnumber = showtable.Text;//เก็บข้อมูลโต๊ะ
                store s = new store();
                s.ShowDialog();


            }
        }

        private void showtable_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
