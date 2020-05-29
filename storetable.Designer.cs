namespace WindowsFormsApp1
{
    partial class storetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storetable));
            this.PayButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payMoney = new System.Windows.Forms.TextBox();
            this.inputMoney = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.giveMoneyTextbox = new System.Windows.Forms.TextBox();
            this.giveMoney = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintReceipt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PayButton.Font = new System.Drawing.Font("DTAC-BoldOF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PayButton.Location = new System.Drawing.Point(407, 168);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(111, 42);
            this.PayButton.TabIndex = 0;
            this.PayButton.Text = "ชำระเงิน";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("DSN Erawan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(382, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "ยืนยันชำระเงิน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("DTAC-BoldOF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(152, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "เงินที่จ่าย";
            // 
            // payMoney
            // 
            this.payMoney.Location = new System.Drawing.Point(223, 211);
            this.payMoney.Name = "payMoney";
            this.payMoney.ReadOnly = true;
            this.payMoney.Size = new System.Drawing.Size(120, 20);
            this.payMoney.TabIndex = 23;
            // 
            // inputMoney
            // 
            this.inputMoney.Location = new System.Drawing.Point(223, 168);
            this.inputMoney.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inputMoney.Name = "inputMoney";
            this.inputMoney.Size = new System.Drawing.Size(120, 20);
            this.inputMoney.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("DTAC-BoldOF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(128, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "ยอดชำระเงิน";
            // 
            // giveMoneyTextbox
            // 
            this.giveMoneyTextbox.Location = new System.Drawing.Point(223, 253);
            this.giveMoneyTextbox.Name = "giveMoneyTextbox";
            this.giveMoneyTextbox.ReadOnly = true;
            this.giveMoneyTextbox.Size = new System.Drawing.Size(120, 20);
            this.giveMoneyTextbox.TabIndex = 26;
            // 
            // giveMoney
            // 
            this.giveMoney.AutoSize = true;
            this.giveMoney.BackColor = System.Drawing.Color.Yellow;
            this.giveMoney.Font = new System.Drawing.Font("DTAC-BoldOF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.giveMoney.Location = new System.Drawing.Point(152, 246);
            this.giveMoney.Name = "giveMoney";
            this.giveMoney.Size = new System.Drawing.Size(60, 27);
            this.giveMoney.TabIndex = 27;
            this.giveMoney.Text = "เงินทอน";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("DTAC-BoldOF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(133, 335);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 45);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "ยกเลิกที่นั่ง";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            // PrintReceipt
            // 
            this.PrintReceipt.BackColor = System.Drawing.Color.Thistle;
            this.PrintReceipt.Enabled = false;
            this.PrintReceipt.Font = new System.Drawing.Font("DTAC-BoldOF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PrintReceipt.Location = new System.Drawing.Point(407, 232);
            this.PrintReceipt.Name = "PrintReceipt";
            this.PrintReceipt.Size = new System.Drawing.Size(111, 41);
            this.PrintReceipt.TabIndex = 29;
            this.PrintReceipt.Text = "พิมพ์ใบเสร็จ";
            this.PrintReceipt.UseVisualStyleBackColor = false;
            this.PrintReceipt.Click += new System.EventHandler(this.PrintReceipt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("DTAC-BoldOF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(615, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "Exit/ออก";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._1111;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // storetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrintReceipt);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.giveMoney);
            this.Controls.Add(this.giveMoneyTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputMoney);
            this.Controls.Add(this.payMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "storetable";
            this.Text = "storetable";
            this.Load += new System.EventHandler(this.storetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payMoney;
        private System.Windows.Forms.NumericUpDown inputMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox giveMoneyTextbox;
        private System.Windows.Forms.Label giveMoney;
        private System.Windows.Forms.Button CancelButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button PrintReceipt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}