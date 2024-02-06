namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_dangnhap = new Label();
            label_tendangnhap = new Label();
            label_matkhau = new Label();
            textBox_tendangnhap = new TextBox();
            textBox_matkhau = new TextBox();
            button_dangnhap = new Button();
            button_thoat = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_dangnhap
            // 
            label_dangnhap.AutoSize = true;
            label_dangnhap.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_dangnhap.Location = new Point(288, 29);
            label_dangnhap.Name = "label_dangnhap";
            label_dangnhap.Size = new Size(127, 24);
            label_dangnhap.TabIndex = 0;
            label_dangnhap.Text = "ĐĂNG NHẬP";
            // 
            // label_tendangnhap
            // 
            label_tendangnhap.AutoSize = true;
            label_tendangnhap.BackColor = SystemColors.ButtonFace;
            label_tendangnhap.BorderStyle = BorderStyle.Fixed3D;
            label_tendangnhap.Location = new Point(101, 90);
            label_tendangnhap.Name = "label_tendangnhap";
            label_tendangnhap.Size = new Size(109, 22);
            label_tendangnhap.TabIndex = 1;
            label_tendangnhap.Text = "Tên đăng nhập";
            // 
            // label_matkhau
            // 
            label_matkhau.AutoSize = true;
            label_matkhau.BorderStyle = BorderStyle.Fixed3D;
            label_matkhau.Location = new Point(138, 126);
            label_matkhau.Name = "label_matkhau";
            label_matkhau.Size = new Size(72, 22);
            label_matkhau.TabIndex = 2;
            label_matkhau.Text = "Mật khẩu";
            // 
            // textBox_tendangnhap
            // 
            textBox_tendangnhap.Location = new Point(227, 90);
            textBox_tendangnhap.Name = "textBox_tendangnhap";
            textBox_tendangnhap.Size = new Size(289, 27);
            textBox_tendangnhap.TabIndex = 3;
            // 
            // textBox_matkhau
            // 
            textBox_matkhau.Location = new Point(227, 119);
            textBox_matkhau.Name = "textBox_matkhau";
            textBox_matkhau.Size = new Size(289, 27);
            textBox_matkhau.TabIndex = 4;
            // 
            // button_dangnhap
            // 
            button_dangnhap.Location = new Point(323, 161);
            button_dangnhap.Name = "button_dangnhap";
            button_dangnhap.Size = new Size(94, 29);
            button_dangnhap.TabIndex = 5;
            button_dangnhap.Text = "Đăng nhập";
            button_dangnhap.UseVisualStyleBackColor = true;
            button_dangnhap.Click += button_dangnhap_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(422, 161);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 29);
            button_thoat.TabIndex = 6;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(615, 203);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Quên";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(737, 244);
            Controls.Add(button1);
            Controls.Add(button_thoat);
            Controls.Add(button_dangnhap);
            Controls.Add(textBox_matkhau);
            Controls.Add(textBox_tendangnhap);
            Controls.Add(label_matkhau);
            Controls.Add(label_tendangnhap);
            Controls.Add(label_dangnhap);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_dangnhap;
        private Label label_tendangnhap;
        private Label label_matkhau;
        private TextBox textBox_tendangnhap;
        private TextBox textBox_matkhau;
        private Button button_dangnhap;
        private Button button_thoat;
        private Button button1;
    }
}