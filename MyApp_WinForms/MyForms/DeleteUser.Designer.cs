
namespace MyApp_WinForms.MyForms
{
    partial class DeleteUser
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
            this.btn_ok_delete = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.checkBox_activated = new System.Windows.Forms.CheckBox();
            this.lab_login = new System.Windows.Forms.Label();
            this.lab_pwd = new System.Windows.Forms.Label();
            this.lab_id_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok_delete
            // 
            this.btn_ok_delete.Location = new System.Drawing.Point(601, 152);
            this.btn_ok_delete.Name = "btn_ok_delete";
            this.btn_ok_delete.Size = new System.Drawing.Size(92, 28);
            this.btn_ok_delete.TabIndex = 25;
            this.btn_ok_delete.Text = "Supprimer";
            this.btn_ok_delete.UseVisualStyleBackColor = true;
            this.btn_ok_delete.Click += new System.EventHandler(this.btn_ok_delete_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(250, 158);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(221, 22);
            this.txt_pwd.TabIndex = 24;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(250, 123);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(221, 22);
            this.txt_login.TabIndex = 23;
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(250, 93);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(221, 22);
            this.txt_UserId.TabIndex = 22;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(601, 93);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 29);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // checkBox_activated
            // 
            this.checkBox_activated.AutoSize = true;
            this.checkBox_activated.Location = new System.Drawing.Point(127, 199);
            this.checkBox_activated.Name = "checkBox_activated";
            this.checkBox_activated.Size = new System.Drawing.Size(88, 21);
            this.checkBox_activated.TabIndex = 20;
            this.checkBox_activated.Text = "Activated";
            this.checkBox_activated.UseVisualStyleBackColor = true;
            // 
            // lab_login
            // 
            this.lab_login.AutoSize = true;
            this.lab_login.Location = new System.Drawing.Point(124, 123);
            this.lab_login.Name = "lab_login";
            this.lab_login.Size = new System.Drawing.Size(43, 17);
            this.lab_login.TabIndex = 19;
            this.lab_login.Text = "Login";
            // 
            // lab_pwd
            // 
            this.lab_pwd.AutoSize = true;
            this.lab_pwd.Location = new System.Drawing.Point(124, 158);
            this.lab_pwd.Name = "lab_pwd";
            this.lab_pwd.Size = new System.Drawing.Size(69, 17);
            this.lab_pwd.TabIndex = 18;
            this.lab_pwd.Text = "Password";
            // 
            // lab_id_user
            // 
            this.lab_id_user.AutoSize = true;
            this.lab_id_user.Location = new System.Drawing.Point(124, 93);
            this.lab_id_user.Name = "lab_id_user";
            this.lab_id_user.Size = new System.Drawing.Size(49, 17);
            this.lab_id_user.TabIndex = 17;
            this.lab_id_user.Text = "UserId";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ok_delete);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.checkBox_activated);
            this.Controls.Add(this.lab_login);
            this.Controls.Add(this.lab_pwd);
            this.Controls.Add(this.lab_id_user);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok_delete;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox checkBox_activated;
        private System.Windows.Forms.Label lab_login;
        private System.Windows.Forms.Label lab_pwd;
        private System.Windows.Forms.Label lab_id_user;
    }
}