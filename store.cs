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
    public partial class store : Form
    {
        string ig_name;
        string ig_price;
        string ig_group;
        int sum;
        string sumstring;
        public store()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
            Program.manypeoplebuffe = manypeople.Text;
            try
            {
                
                con.Open();//ใส่สถานะโต๊ะเป็นชื่อผู้ใช้ ว่าโต๊ะนี้มีคนจองเเล้ว
                string nameseat = Program.selectnumber;
                string nameUser = Program.username;
                string receipt="WN-"+ System.DateTime.Now.ToString("yyyyMMddHHmmss");
                string sql = "UPDATE seat SET status_table = '"+ nameUser +"' WHERE name_table='"+ nameseat +"';";
                //MessageBox.Show("'" + Program.username + "" + Program.selectnumber + "'\n"+sql, "");
                MySqlCommand cmd5 = new MySqlCommand(sql, con);
                cmd5.ExecuteReader();
                con.Close();
                

                con.Open();//ดึงข้อมูลว่าผู้ใช้ซื้ออะไรบ้าง เเล้วดึงข้อมูล 3 อย่างนี้มา 
                string sql1 = "SELECT * FROM neworder WHERE id_order='" + Program.selectmenubuffe + "'";
                //MessageBox.Show("'" + Program.selectmenubuffe + "'");
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
                
                con.Open();//การคำนวณ
                int a = Convert.ToInt32(ig_price);
                int b = Convert.ToInt32(Program.manypeoplebuffe);
                sum = a * b;
                //sum = int.Parse(ig_price) * int.Parse(Program.manypeoplebuffe);
                sumstring = sum.ToString();//เเปลงตัวเลขเป็นตัวหนังสือ เพื่อเอามาเก็บไว้ในฐานข้อมูล

                string sql2 = "INSERT INTO receipt(name_receipt, number_receipt, prices_receipt, user_receipt, date_receipt, no_receipt, group_receipt) VALUES('" +ig_name + "', '" + Program.manypeoplebuffe + "', '" + sumstring + "', '" + Program.username + "', '" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + receipt + "', '"+ ig_group +"')";//เป็นเก็บข้อมูลไว้ใน ดาต้าเบส
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {

                }
                con.Close();
                

                con.Open();//เป็นการค้างบิลไว้ เป็นการเอาเลขที่ใบเสร็จไปใส่ในสถานะ 
                string sql3 = "UPDATE login SET status_login='" + receipt + "' WHERE Username = '" + Program.username + "';";
                MySqlCommand cmd3 = new MySqlCommand(sql3, con);
                MySqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {

                }
                con.Close();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
                
                storetable ST = new storetable();
                ST.ShowDialog();

            }
            catch(Exception ex)//การเกิดข้อผิดพลาด
            {
                MessageBox.Show("เกิดข้อผิดพลาด"+ex);
            }
                
          
         
           
         
        }

        private void menu99_CheckedChanged(object sender, EventArgs e)//เป็นการเลือกเมนู
        {
            if (menu99.Checked == true)
            {
                Program.selectmenubuffe = "1";
            }
        }

        private void store_Load(object sender, EventArgs e)
        {
            Program.selectmenubuffe = "1";//ที่ใส่หมายเลขเพื่อจะใช้ดึงข้อมูลในดาต้าเบส
            MessageBox.Show(Program.selectnumber);
        }

        private void menu159_CheckedChanged(object sender, EventArgs e)
        {
            if (menu159.Checked == true)
            {
                Program.selectmenubuffe = "2";
            }
        }

        private void menu199_CheckedChanged(object sender, EventArgs e)
        {
            if (menu199.Checked == true)
            {
                Program.selectmenubuffe = "3";
            }
        }
    }
}
