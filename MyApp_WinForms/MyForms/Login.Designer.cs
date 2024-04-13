
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
            this.login_label = new System.Windows.Forms.Label();
            this.pwd_label = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.pwd_txt = new System.Windows.Forms.TextBox();
            this.authenticate_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(245, 96);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(59, 24);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login";
            // 
            // pwd_label
            // 
            this.pwd_label.AutoSize = true;
            this.pwd_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_label.Location = new System.Drawing.Point(245, 148);
            this.pwd_label.Name = "pwd_label";
            this.pwd_label.Size = new System.Drawing.Size(97, 24);
            this.pwd_label.TabIndex = 1;
            this.pwd_label.Text = "Password";
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(396, 91);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(202, 22);
            this.login_txt.TabIndex = 2;
            // 
            // pwd_txt
            // 
            this.pwd_txt.Location = new System.Drawing.Point(396, 143);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.Size = new System.Drawing.Size(202, 22);
            this.pwd_txt.TabIndex = 3;
            // 
            // authenticate_btn
            // 
            this.authenticate_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authenticate_btn.Location = new System.Drawing.Point(242, 224);
            this.authenticate_btn.Name = "authenticate_btn";
            this.authenticate_btn.Size = new System.Drawing.Size(356, 53);
            this.authenticate_btn.TabIndex = 4;
            this.authenticate_btn.Text = "Se connecter";
            this.authenticate_btn.UseVisualStyleBackColor = true;
            this.authenticate_btn.Click += new System.EventHandler(this.authenticate_btn_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(816, 546);
            this.Controls.Add(this.authenticate_btn);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.pwd_label);
            this.Controls.Add(this.login_label);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label pwd_label;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.TextBox pwd_txt;
        private System.Windows.Forms.Button authenticate_btn;
    }
}