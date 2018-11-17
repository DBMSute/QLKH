namespace QuanLyKhoHang.GiaoDien
{
    partial class fmInputPW
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbOldPW = new System.Windows.Forms.TextBox();
            this.tbNewPW = new System.Windows.Forms.TextBox();
            this.tbCfmPW = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(325, 241);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 47);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbOldPW
            // 
            this.tbOldPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOldPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOldPW.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.tbOldPW.ForeColor = System.Drawing.Color.White;
            this.tbOldPW.Location = new System.Drawing.Point(198, 85);
            this.tbOldPW.Name = "tbOldPW";
            this.tbOldPW.PasswordChar = '●';
            this.tbOldPW.Size = new System.Drawing.Size(250, 28);
            this.tbOldPW.TabIndex = 6;
            // 
            // tbNewPW
            // 
            this.tbNewPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPW.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.tbNewPW.ForeColor = System.Drawing.Color.White;
            this.tbNewPW.Location = new System.Drawing.Point(198, 140);
            this.tbNewPW.Name = "tbNewPW";
            this.tbNewPW.PasswordChar = '●';
            this.tbNewPW.Size = new System.Drawing.Size(250, 28);
            this.tbNewPW.TabIndex = 7;
            // 
            // tbCfmPW
            // 
            this.tbCfmPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCfmPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCfmPW.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.tbCfmPW.ForeColor = System.Drawing.Color.White;
            this.tbCfmPW.Location = new System.Drawing.Point(198, 195);
            this.tbCfmPW.Name = "tbCfmPW";
            this.tbCfmPW.PasswordChar = '●';
            this.tbCfmPW.Size = new System.Drawing.Size(250, 28);
            this.tbCfmPW.TabIndex = 9;
            // 
            // lbNote
            // 
            this.lbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.White;
            this.lbNote.Location = new System.Drawing.Point(40, 20);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(408, 44);
            this.lbNote.TabIndex = 10;
            this.lbNote.Text = "Chú ý:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mật khẩu cũ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mật khẩu mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Xác nhận mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fmInputPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.tbCfmPW);
            this.Controls.Add(this.tbNewPW);
            this.Controls.Add(this.tbOldPW);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmInputPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbOldPW;
        private System.Windows.Forms.TextBox tbNewPW;
        private System.Windows.Forms.TextBox tbCfmPW;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}