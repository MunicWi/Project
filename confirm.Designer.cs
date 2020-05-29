namespace WindowsFormsApp1
{
    partial class confirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirm));
            this.Print = new System.Windows.Forms.Button();
            this.payMoneyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.giveMoneyTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMoney = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.payMoney1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // Print
            // 
            this.Print.Enabled = false;
            this.Print.Font = new System.Drawing.Font("DSN Erawan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Print.Location = new System.Drawing.Point(613, 276);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(107, 36);
            this.Print.TabIndex = 15;
            this.Print.Text = "พิมพ์ใบเสร็จ";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // payMoneyButton
            // 
            this.payMoneyButton.Font = new System.Drawing.Font("DSN Erawan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.payMoneyButton.Location = new System.Drawing.Point(613, 224);
            this.payMoneyButton.Name = "payMoneyButton";
            this.payMoneyButton.Size = new System.Drawing.Size(107, 36);
            this.payMoneyButton.TabIndex = 14;
            this.payMoneyButton.Text = "ชำระเงิน";
            this.payMoneyButton.UseVisualStyleBackColor = true;
            this.payMoneyButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("DSN Erawan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(12, 402);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(152, 36);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "ยกเลิกการสั่งซื้อ";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("DSN Erawan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(592, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "ยืนยันการสั่งซื้อ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._31;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 454);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // giveMoneyTextbox
            // 
            this.giveMoneyTextbox.Location = new System.Drawing.Point(648, 151);
            this.giveMoneyTextbox.Name = "giveMoneyTextbox";
            this.giveMoneyTextbox.ReadOnly = true;
            this.giveMoneyTextbox.Size = new System.Drawing.Size(120, 20);
            this.giveMoneyTextbox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("DTAC-BoldOF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(553, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "ยอดชำระเงิน";
            // 
            // inputMoney
            // 
            this.inputMoney.Location = new System.Drawing.Point(648, 66);
            this.inputMoney.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inputMoney.Name = "inputMoney";
            this.inputMoney.Size = new System.Drawing.Size(120, 20);
            this.inputMoney.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("DTAC-BoldOF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(577, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "เงินที่จ่าย";
            // 
            // payMoney1
            // 
            this.payMoney1.Location = new System.Drawing.Point(648, 107);
            this.payMoney1.Name = "payMoney1";
            this.payMoney1.ReadOnly = true;
            this.payMoney1.Size = new System.Drawing.Size(120, 20);
            this.payMoney1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("DTAC-BoldOF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(582, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "เงินทอน";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payMoney1);
            this.Controls.Add(this.giveMoneyTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.payMoneyButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "confirm";
            this.Text = "confirm";
            this.Load += new System.EventHandler(this.confirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button payMoneyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox giveMoneyTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payMoney1;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}