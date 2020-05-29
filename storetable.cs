using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class storetable : Form
    {
        string no_receiptformDB_toProgram;
        string name_menu;
        string many_menu;
        string price_menu;
        string user_menu;
        string date_menu;
        string group_menu;
        int Allmoney;
        int Paymoney;
        int Givemoney;
        public storetable()
        {
            InitializeComponent();
        }

        private void storetable_Load(object sender, EventArgs e)
        {
            //ดึงข้อมูลเลขที่ใบเสร็จจากสถานะผู้ใช้
            MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
            try
            {
                con.Open();//
                string sql = "SELECT * FROM login WHERE Username='" + Program.username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    no_receiptformDB_toProgram = reader.GetString("status_login");
                }
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการโหลดเลขที่ใบเสร็จ");
            }
            //ดึงข้อมูลใบเสร็จ
            MySqlConnection con1 = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
            try
            {
                //MessageBox.Show("'" + no_receiptformDB_toProgram + "'");
                con1.Open();//
                string sql1 = "SELECT * FROM receipt WHERE no_receipt='" + no_receiptformDB_toProgram + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    name_menu = reader1.GetString("name_receipt");
                    many_menu = reader1.GetString("number_receipt");
                    price_menu = reader1.GetString("prices_receipt");
                    user_menu = reader1.GetString("user_receipt");
                    date_menu = reader1.GetString("date_receipt");
                    group_menu = reader1.GetString("group_receipt");
                }
                con1.Close();
                payMoney.Text = price_menu;

            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูลใบเสร็จ"+ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(inputMoney.Text) < int.Parse(price_menu))
            {
                MessageBox.Show("กรุณาจ่ายเงินมากกว่าหรือเท่ากับยอดชำระ", "การแจ้งเตือน");
            }
            else
            {
                inputMoney.ReadOnly = true;
                Allmoney = int.Parse(inputMoney.Text);
                Paymoney = int.Parse(payMoney.Text);
                Givemoney = Allmoney - Paymoney;
                giveMoneyTextbox.Text = Givemoney.ToString();
                
                
                PayButton.Enabled = false;
                PayButton.Text = "จ่ายแล้วเรียบร้อย";

                try //ลบสถานะผู้ใช้ (บิลที่ค้าง)
                {
                    MySqlConnection con1 = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
                    con1.Open();
                    string sql1 = "UPDATE login SET status_login = '' WHERE Username = '" + Program.username + "';";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                    cmd1.ExecuteReader();
                    con1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ลบสถานะผู้ใช้ (บิลที่ค้าง)"+ ex, "การแจ้งเตือน");
                }

                try //ลบสถานะโต๊ะ
                {
                    MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
                    con.Open();
                    string sql = "UPDATE seat SET status_table = '' WHERE status_table = '" + Program.username + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("สรุป \nรับเงินมา :" + Allmoney.ToString() + "บาท\nจ่ายทั้งหมด : " + Paymoney.ToString() + "บาท \nเงินทอน : " + Givemoney.ToString() + "บาท", "สรุปรายการ");
                    PrintReceipt.Enabled = true;
                    CancelButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ลบสถานะโต๊ะ" + ex, "การแจ้งเตือน");

                }
                
            }
            
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("เลขที่ใบเสร็จ : "+ no_receiptformDB_toProgram, new Font("DSN Erawan", 12, FontStyle.Bold), Brushes.Black, new PointF(60, 60));
            e.Graphics.DrawString("วันที่ขาย : " + date_menu, new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 80));
            e.Graphics.DrawString("ผู้ซื้อ : " + user_menu, new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 100));
            e.Graphics.DrawString("ประเภทสินค้า  : " + group_menu, new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 120));
            e.Graphics.DrawString("---------------------------------------------", new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 140));
            e.Graphics.DrawString("รายการสินค้า", new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 160));
            e.Graphics.DrawString("---------------------------------------------", new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 180));
            e.Graphics.DrawString(name_menu + "         ราคา   " + price_menu + "  บาท", new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 200));
            e.Graphics.DrawString("---------------------------------------------", new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 220));
            e.Graphics.DrawString("รับเงินมา  : " + Allmoney.ToString(), new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 240));
            e.Graphics.DrawString("ยอดชำระเงิน  : " + Paymoney.ToString(), new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 260));
            e.Graphics.DrawString("เงินทอน  : " + Givemoney.ToString(), new Font("DSN Erawan", 12, FontStyle.Regular), Brushes.Black, new PointF(60, 280));

        }

        private void PrintReceipt_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("80 x 160 mm", 400, 350);
            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)//ปุ่มยกเลิก
        {
            try //ลบสถานะผู้ใช้ (บิลที่ค้าง)
            {
                MySqlConnection con1 = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
                con1.Open();
                string sql1 = "UPDATE login SET status_login = '' WHERE Username = '" + Program.username + "';";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                cmd1.ExecuteReader();
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ลบสถานะผู้ใช้ (บิลที่ค้าง)" + ex, "การแจ้งเตือน");
            }

            try //ลบใบเสร็จทิ้ง
            {
                MySqlConnection con2 = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
                con2.Open();
                string sql2 = "DELETE FROM receipt WHERE no_receipt = '" + no_receiptformDB_toProgram + "';";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                cmd2.ExecuteReader();
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ลบใบเสร็จทิ้ง" + ex, "การแจ้งเตือน");
            }

            try //ลบสถานะโต๊ะ
            {
                MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=123456;database=project");
                con.Open();
                string sql = "UPDATE seat SET status_table = '' WHERE status_table = '" + Program.username + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("ยกเลิกที่นั่งเรียบร้อยแล้ว", "การแจ้งเตือน");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ลบสถานะโต๊ะ" + ex, "การแจ้งเตือน");

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
