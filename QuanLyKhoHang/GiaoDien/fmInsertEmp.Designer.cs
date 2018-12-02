namespace QuanLyKhoHang.GiaoDien
{
    partial class fmInsertEmp
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
            this.tbTenTK = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCPW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtimeDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbEmp = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbBan = new System.Windows.Forms.RadioButton();
            this.tbADD = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTenTK
            // 
            this.tbTenTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTenTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenTK.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTK.ForeColor = System.Drawing.Color.White;
            this.tbTenTK.Location = new System.Drawing.Point(226, 60);
            this.tbTenTK.Name = "tbTenTK";
            this.tbTenTK.Size = new System.Drawing.Size(279, 26);
            this.tbTenTK.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(385, 611);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 47);
            this.btnSubmit.TabIndex = 41;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPW
            // 
            this.tbPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPW.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPW.ForeColor = System.Drawing.Color.White;
            this.tbPW.Location = new System.Drawing.Point(226, 120);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '●';
            this.tbPW.Size = new System.Drawing.Size(279, 26);
            this.tbPW.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 40);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nhập lại mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCPW
            // 
            this.tbCPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCPW.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPW.ForeColor = System.Drawing.Color.White;
            this.tbCPW.Location = new System.Drawing.Point(226, 180);
            this.tbCPW.Name = "tbCPW";
            this.tbCPW.PasswordChar = '●';
            this.tbCPW.Size = new System.Drawing.Size(279, 26);
            this.tbCPW.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 40);
            this.label4.TabIndex = 26;
            this.label4.Text = "Họ và tên đệm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLN
            // 
            this.tbLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLN.ForeColor = System.Drawing.Color.White;
            this.tbLN.Location = new System.Drawing.Point(226, 240);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(279, 26);
            this.tbLN.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 40);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFN
            // 
            this.tbFN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFN.ForeColor = System.Drawing.Color.White;
            this.tbFN.Location = new System.Drawing.Point(226, 300);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(279, 26);
            this.tbFN.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 40);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ngày sinh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtimeDOB
            // 
            this.dtimeDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtimeDOB.CustomFormat = "dd-MM-yyyy";
            this.dtimeDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeDOB.Location = new System.Drawing.Point(226, 360);
            this.dtimeDOB.Name = "dtimeDOB";
            this.dtimeDOB.Size = new System.Drawing.Size(279, 27);
            this.dtimeDOB.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SeaGreen;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 40);
            this.label7.TabIndex = 33;
            this.label7.Text = "Địa chỉ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.BackColor = System.Drawing.Color.Transparent;
            this.rbEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmp.ForeColor = System.Drawing.Color.White;
            this.rbEmp.Location = new System.Drawing.Point(181, 1);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(98, 23);
            this.rbEmp.TabIndex = 36;
            this.rbEmp.TabStop = true;
            this.rbEmp.Text = "Nhân viên";
            this.rbEmp.UseVisualStyleBackColor = false;
            this.rbEmp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SeaGreen;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 40);
            this.label8.TabIndex = 35;
            this.label8.Text = "Chức vụ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.BackColor = System.Drawing.Color.Transparent;
            this.rbManager.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.ForeColor = System.Drawing.Color.White;
            this.rbManager.Location = new System.Drawing.Point(3, 2);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(82, 23);
            this.rbManager.TabIndex = 34;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Quản lý";
            this.rbManager.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SeaGreen;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 40);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tình trạng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.rbManager);
            this.panel1.Controls.Add(this.rbEmp);
            this.panel1.Location = new System.Drawing.Point(226, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 26);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.rbActive);
            this.panel2.Controls.Add(this.rbBan);
            this.panel2.Location = new System.Drawing.Point(226, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 26);
            this.panel2.TabIndex = 41;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.BackColor = System.Drawing.Color.Transparent;
            this.rbActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.ForeColor = System.Drawing.Color.White;
            this.rbActive.Location = new System.Drawing.Point(3, 2);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(101, 23);
            this.rbActive.TabIndex = 38;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Hoạt động";
            this.rbActive.UseVisualStyleBackColor = false;
            // 
            // rbBan
            // 
            this.rbBan.AutoSize = true;
            this.rbBan.BackColor = System.Drawing.Color.Transparent;
            this.rbBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBan.ForeColor = System.Drawing.Color.White;
            this.rbBan.Location = new System.Drawing.Point(181, 1);
            this.rbBan.Name = "rbBan";
            this.rbBan.Size = new System.Drawing.Size(79, 23);
            this.rbBan.TabIndex = 40;
            this.rbBan.TabStop = true;
            this.rbBan.Text = "Bị khóa";
            this.rbBan.UseVisualStyleBackColor = false;
            // 
            // tbADD
            // 
            this.tbADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbADD.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbADD.ForeColor = System.Drawing.Color.White;
            this.tbADD.FormattingEnabled = true;
            this.tbADD.ItemHeight = 25;
            this.tbADD.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Cạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Đồng Nai",
            "Đồng Tháp",
            "Đồng Tháp",
            "Điện Biên",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hòa Bình",
            "Hậu Giang",
            "Hưng Yên",
            "Hồ Chí Minh",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.tbADD.Location = new System.Drawing.Point(226, 414);
            this.tbADD.Name = "tbADD";
            this.tbADD.Size = new System.Drawing.Size(279, 33);
            this.tbADD.TabIndex = 33;
            // 
            // fmInsertEmp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 671);
            this.Controls.Add(this.tbADD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtimeDOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenTK);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmInsertEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTenTK;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtimeDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbBan;
        private System.Windows.Forms.ComboBox tbADD;
    }
}