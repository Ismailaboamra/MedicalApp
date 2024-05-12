
namespace MedicalApp
{
    partial class Login_frm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signup_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(72, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Create Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Don\'t Have an Account";
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.White;
            this.Clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Clear_btn.Location = new System.Drawing.Point(35, 321);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(216, 35);
            this.Clear_btn.TabIndex = 25;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(35, 269);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(216, 35);
            this.login_btn.TabIndex = 24;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // cb_showpass
            // 
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_showpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_showpass.Location = new System.Drawing.Point(64, 236);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(151, 27);
            this.cb_showpass.TabIndex = 23;
            this.cb_showpass.Text = "Show Password";
            this.cb_showpass.UseVisualStyleBackColor = true;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.cb_showpass_CheckedChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.Password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_txt.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(35, 190);
            this.Password_txt.Multiline = true;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(216, 28);
            this.Password_txt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_txt.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.Location = new System.Drawing.Point(35, 125);
            this.Username_txt.Multiline = true;
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(216, 28);
            this.Username_txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // signup_lbl
            // 
            this.signup_lbl.AutoSize = true;
            this.signup_lbl.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signup_lbl.Location = new System.Drawing.Point(49, 38);
            this.signup_lbl.Name = "signup_lbl";
            this.signup_lbl.Size = new System.Drawing.Size(196, 46);
            this.signup_lbl.TabIndex = 14;
            this.signup_lbl.Text = "Login Page";
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 489);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.cb_showpass);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup_lbl);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_frm";
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox cb_showpass;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label signup_lbl;
    }
}