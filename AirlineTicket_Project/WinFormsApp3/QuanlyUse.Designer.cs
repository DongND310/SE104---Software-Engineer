namespace WinFormsApp3
{
    partial class QuanlyUse
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
            tabControl1 = new TabControl();
            DoanThu = new TabPage();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            textBox_TONGDOANTHU = new TextBox();
            label4 = new Label();
            button_DTNAM = new Button();
            button_DTTHANG = new Button();
            textBox_thang = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView_DTPhieuDat = new DataGridView();
            dataGridView_DTVE = new DataGridView();
            tabPage2 = new TabPage();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            tabControl1.SuspendLayout();
            DoanThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DTPhieuDat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DTVE).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DoanThu);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1003, 611);
            tabControl1.TabIndex = 0;
            // 
            // DoanThu
            // 
            DoanThu.Controls.Add(button1);
            DoanThu.Controls.Add(label6);
            DoanThu.Controls.Add(label5);
            DoanThu.Controls.Add(textBox_TONGDOANTHU);
            DoanThu.Controls.Add(label4);
            DoanThu.Controls.Add(button_DTNAM);
            DoanThu.Controls.Add(button_DTTHANG);
            DoanThu.Controls.Add(textBox_thang);
            DoanThu.Controls.Add(label2);
            DoanThu.Controls.Add(label1);
            DoanThu.Controls.Add(dataGridView_DTPhieuDat);
            DoanThu.Controls.Add(dataGridView_DTVE);
            DoanThu.Location = new Point(4, 29);
            DoanThu.Name = "DoanThu";
            DoanThu.Padding = new Padding(3);
            DoanThu.Size = new Size(995, 578);
            DoanThu.TabIndex = 0;
            DoanThu.Text = "Doanh Thu";
            DoanThu.UseVisualStyleBackColor = true;
            DoanThu.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(131, 504);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 24;
            button1.Text = "Xuất file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 395);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 23;
            label6.Text = "Phiếu Đặt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 157);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 22;
            label5.Text = "VÉ";
            // 
            // textBox_TONGDOANTHU
            // 
            textBox_TONGDOANTHU.Location = new Point(219, 431);
            textBox_TONGDOANTHU.Name = "textBox_TONGDOANTHU";
            textBox_TONGDOANTHU.Size = new Size(125, 27);
            textBox_TONGDOANTHU.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 438);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 20;
            label4.Text = "Tổng Doanh Thu";
            // 
            // button_DTNAM
            // 
            button_DTNAM.Location = new Point(97, 334);
            button_DTNAM.Name = "button_DTNAM";
            button_DTNAM.Size = new Size(171, 60);
            button_DTNAM.TabIndex = 19;
            button_DTNAM.Text = "Doanh Thu Tổng";
            button_DTNAM.UseVisualStyleBackColor = true;
            button_DTNAM.Click += button_DTNAM_Click_1;
            // 
            // button_DTTHANG
            // 
            button_DTTHANG.Location = new Point(97, 287);
            button_DTTHANG.Name = "button_DTTHANG";
            button_DTTHANG.Size = new Size(171, 41);
            button_DTTHANG.TabIndex = 18;
            button_DTTHANG.Text = "Doanh Thu Tháng";
            button_DTTHANG.UseVisualStyleBackColor = true;
            button_DTTHANG.Click += button_DTTHANG_Click_1;
            // 
            // textBox_thang
            // 
            textBox_thang.Location = new Point(143, 154);
            textBox_thang.Name = "textBox_thang";
            textBox_thang.Size = new Size(125, 27);
            textBox_thang.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 157);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 16;
            label2.Text = "Tháng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 43);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 15;
            label1.Text = "Doanh thu";
            // 
            // dataGridView_DTPhieuDat
            // 
            dataGridView_DTPhieuDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DTPhieuDat.Location = new Point(522, 297);
            dataGridView_DTPhieuDat.Name = "dataGridView_DTPhieuDat";
            dataGridView_DTPhieuDat.RowHeadersWidth = 51;
            dataGridView_DTPhieuDat.RowTemplate.Height = 29;
            dataGridView_DTPhieuDat.Size = new Size(403, 239);
            dataGridView_DTPhieuDat.TabIndex = 14;
            // 
            // dataGridView_DTVE
            // 
            dataGridView_DTVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DTVE.Location = new Point(522, 43);
            dataGridView_DTVE.Name = "dataGridView_DTVE";
            dataGridView_DTVE.RowHeadersWidth = 51;
            dataGridView_DTVE.RowTemplate.Height = 29;
            dataGridView_DTVE.Size = new Size(403, 239);
            dataGridView_DTVE.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(995, 578);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Acount";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 108);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên TK";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 185);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 2;
            label7.Text = "MAT KHAU";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 27);
            textBox3.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(134, 283);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 4;
            label8.Text = "MATKHAU  MOI";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(265, 365);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 27);
            textBox4.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 372);
            label9.Name = "label9";
            label9.Size = new Size(194, 20);
            label9.TabIndex = 6;
            label9.Text = "MAT KHAU MOI 1 LAN NUA";
            // 
            // QuanlyUse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 626);
            Controls.Add(tabControl1);
            Name = "QuanlyUse";
            Text = "QuanlyUse";
            tabControl1.ResumeLayout(false);
            DoanThu.ResumeLayout(false);
            DoanThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DTPhieuDat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DTVE).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage DoanThu;
        private TabPage tabPage2;
        private Label label6;
        private Label label5;
        private TextBox textBox_TONGDOANTHU;
        private Label label4;
        private Button button_DTNAM;
        private Button button_DTTHANG;
        private TextBox textBox_thang;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView_DTPhieuDat;
        private DataGridView dataGridView_DTVE;
        private Button button1;
        private Label label3;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
    }
}