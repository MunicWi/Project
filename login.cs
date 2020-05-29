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
    public partial class login : Form
    {
        string no_receiptfromDB;
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
            try
            {
                con.Open();//หน้า login
                string sql = "SELECT * FROM login WHERE Username='" + username.Text + "' AND Password='" + password.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool check = false;
                while (reader.Read())
                {
                    check = true;//เเสดงว่า username password มีข้อมูลอยู่ในดาต้าเบส
                    Program.username = reader.GetString("Username");//เป็นเลขาที่เก็บข้อมูล ดึงข้อมูลออกมาใช้เก็บไว้ในคอม
                    Program.status = reader.GetString("status_login");//ดึงข้อมูล status_login

                }
                con.Close();
                if (check == false)//ตรวจสอบข้อมูล 
                {

                    MessageBox.Show("ไม่มี UsernameและPassword นี้");
                }
                else//ถ้ามี check= true
                {
                    if (Program.status == "")//การเช็คสถานะของผู้ใช้ว่าว่างไหม
                    {
                        select se = new select();
                        se.ShowDialog();
                    }
                    else//ถ้าสถานะไม่ว่าง แสดงว่ามีเลขที่ใบเสร็จ เอาเลขที่ใบเสร็จไปตรวจสอบว่าเป็นการสังประเภทไหน
                    {
                        try//คำสั่งการทำงานปกติ
                        {
                            MySqlConnection con1 = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
                            con1.Open();
                            string sql2 = "SELECT * FROM receipt WHERE no_receipt = '" + Program.status + "'";
                             MySqlCommand cmd1 = new MySqlCommand(sql2, con1);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();
                            while (reader1.Read())
                            {

                                no_receiptfromDB = reader1.GetString("group_receipt");
                            }
                            
                            if (no_receiptfromDB == "บุพเฟ่ต์")
                            {
                                storetable s = new storetable();
                                s.ShowDialog();
                            }  
                            else if (no_receiptfromDB == "กลับบ้าน")
                            {
                                confirm s = new confirm();
                                s.ShowDialog();
                            }
                            
                        }
                        catch (Exception ex) //ทำงานเกิดข้อผิดพลาด ตรวจสอบเงื่อนไข
                        {
                            MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล กรุณาลองใหม่อีกครั้ง"+ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            apply a = new apply();
            a.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
