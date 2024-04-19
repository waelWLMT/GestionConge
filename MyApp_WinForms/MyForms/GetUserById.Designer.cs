
namespace MyApp_WinForms.MyForms
{
    partial class GetUserById
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
            this.lab_id_user = new System.Windows.Forms.Label();
            this.lab_pwd = new System.Windows.Forms.Label();
            this.lab_login = new System.Windows.Forms.Label();
            this.checkBox_activated = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_id_user
            // 
            this.lab_id_user.AutoSize = true;
            this.lab_id_user.Location = new System.Drawing.Point(97, 59);
            this.lab_id_user.Name = "lab_id_user";
            this.lab_id_user.Size = new System.Drawing.Size(49, 17);
            this.lab_id_user.TabIndex = 0;
            this.lab_id_user.Text = "UserId";
            // 
            // lab_pwd
            // 
            this.lab_pwd.AutoSize = true;
            this.lab_pwd.Location = new System.Drawing.Point(97, 124);
            this.lab_pwd.Name = "lab_pwd";
            this.lab_pwd.Size = new System.Drawing.Size(69, 17);
            this.lab_pwd.TabIndex = 1;
            this.lab_pwd.Text = "Password";
            // 
            // lab_login
            // 
            this.lab_login.AutoSize = true;
            this.lab_login.Location = new System.Drawing.Point(97, 89);
            this.lab_login.Name = "lab_login";
            this.lab_login.Size = new System.Drawing.Size(43, 17);
            this.lab_login.TabIndex = 2;
            this.lab_login.Text = "Login";
            // 
            // checkBox_activated
            // 
            this.checkBox_activated.AutoSize = true;
            this.checkBox_activated.Location = new System.Drawing.Point(100, 165);
            this.checkBox_activated.Name = "checkBox_activated";
            this.checkBox_activated.Size = new System.Drawing.Size(88, 21);
            this.checkBox_activated.TabIndex = 3;
            this.checkBox_activated.Text = "Activated";
            this.checkBox_activated.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(574, 59);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(223, 59);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(221, 22);
            this.txt_UserId.TabIndex = 5;
            this.txt_UserId.TextChanged += new System.EventHandler(this.txt_UserId_TextChanged);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(223, 89);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(221, 22);
            this.txt_login.TabIndex = 6;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(223, 124);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(221, 22);
            this.txt_pwd.TabIndex = 7;
            // 
            // GetUserById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.checkBox_activated);
            this.Controls.Add(this.lab_login);
            this.Controls.Add(this.lab_pwd);
            this.Controls.Add(this.lab_id_user);
            this.Name = "GetUserById";
            this.Text = "GetUserById";
            this.Load += new System.EventHandler(this.GetUserById_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_id_user;
        private System.Windows.Forms.Label lab_pwd;
        private System.Windows.Forms.Label lab_login;
        private System.Windows.Forms.CheckBox checkBox_activated;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_pwd;
    }
}