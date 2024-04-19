
namespace MyApp_WinForms.MyForms
{
    partial class Login
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
            this.label_login = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.conn_btn = new System.Windows.Forms.Button();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.pwd_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(71, 45);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(65, 25);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Login";
            this.label_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwd.Location = new System.Drawing.Point(71, 81);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(106, 25);
            this.label_pwd.TabIndex = 1;
            this.label_pwd.Text = "Password";
            this.label_pwd.Click += new System.EventHandler(this.label2_Click);
            // 
            // conn_btn
            // 
            this.conn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_btn.Location = new System.Drawing.Point(76, 127);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(330, 43);
            this.conn_btn.TabIndex = 2;
            this.conn_btn.Text = "Connexion";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(216, 45);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(190, 22);
            this.login_txt.TabIndex = 3;
            this.login_txt.TextChanged += new System.EventHandler(this.login_txt_TextChanged);
            // 
            // pwd_txt
            // 
            this.pwd_txt.Location = new System.Drawing.Point(216, 81);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.Size = new System.Drawing.Size(190, 22);
            this.pwd_txt.TabIndex = 4;
            this.pwd_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.conn_btn);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.TextBox pwd_txt;
    }
}