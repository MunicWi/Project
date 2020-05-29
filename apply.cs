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
    public partial class apply : Form
    {
        public apply()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void สมัครสมาชิก_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//เป็นเงื่อนไขที่ผู้ใช้ต้องกรอกให้ครบ
        {
            if (username.Text==""||password.Text==""|| name.Text == "" || email.Text == "" || tell.Text == "" || addess.Text == "")//ตรวจสอบว่าผู้ใช้กรอกข้อมูลครบไหม
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
            } 
            else if(password.Text.Length > 6) {//กรอกรหัสผ่านไม่เกิน 6 ตัว
                MessageBox.Show("รหัสผ่านเกินกำหนด");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");//เชื่อมดาต้าเบส
                try
                {
                    con.Open();//ตรวจสอบข้อมูลว่าซ้ำกันไหม ถ้าซ้ำ loop while ทำงาน
                    string sql = "SELECT * FROM login WHERE Username='" + username.Text+"'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    bool check = false; //ไม่ซ้ำ
                    while (reader.Read())
                    {
                        check = true;//ซ้ำ
                    }
                    con.Close();
                    if (check == false) //ทำการเพิ่มในดาต้าเบส
                    {
                        sql= "INSERT INTO login(Username, Password, Name, Email, Tell, address) VALUES('" + username.Text + "', '" + password.Text + "', '" + name.Text + "', '" + email.Text + "', '" + tell.Text + "', '" + addess.Text + "')";
                        con.Open();
                        cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteReader();
                        con.Close();
                        MessageBox.Show("[บันทึกข้อมูลเรียบร้อยแล้ว");
                    }
                    else//ถ้าซ้ำ Username มีผู้ใช้แล้ว
                    {
                        MessageBox.Show("Username มีผู้ใช้แล้ว");
                        con.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล"+ex);
                }
            }
        }
    }
}
