
namespace MyApp_WinForms.MyForms
{
    partial class CreationUser
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
            this.lab_login = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.checkBox_activated = new System.Windows.Forms.CheckBox();
            this.button_ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_login
            // 
            this.lab_login.AutoSize = true;
            this.lab_login.Location = new System.Drawing.Point(92, 77);
            this.lab_login.Name = "lab_login";
            this.lab_login.Size = new System.Drawing.Size(43, 17);
            this.lab_login.TabIndex = 0;
            this.lab_login.Text = "Login";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Location = new System.Drawing.Point(95, 127);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(69, 17);
            this.label_pwd.TabIndex = 1;
            this.label_pwd.Text = "Password";
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(186, 77);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(207, 22);
            this.text_login.TabIndex = 2;
            this.text_login.TextChanged += new System.EventHandler(this.text_login_TextChanged);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(186, 127);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(207, 22);
            this.text_password.TabIndex = 3;
            // 
            // checkBox_activated
            // 
            this.checkBox_activated.AutoSize = true;
            this.checkBox_activated.Location = new System.Drawing.Point(98, 190);
            this.checkBox_activated.Name = "checkBox_activated";
            this.checkBox_activated.Size = new System.Drawing.Size(88, 21);
            this.checkBox_activated.TabIndex = 4;
            this.checkBox_activated.Text = "Activated";
            this.checkBox_activated.UseVisualStyleBackColor = true;
            // 
            // button_ajout
            // 
            this.button_ajout.Location = new System.Drawing.Point(258, 245);
            this.button_ajout.Name = "button_ajout";
            this.button_ajout.Size = new System.Drawing.Size(75, 23);
            this.button_ajout.TabIndex = 5;
            this.button_ajout.Text = "Ajouter";
            this.button_ajout.UseVisualStyleBackColor = true;
            this.button_ajout.Click += new System.EventHandler(this.button_ajout_Click);
            // 
            // CreationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ajout);
            this.Controls.Add(this.checkBox_activated);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.lab_login);
            this.Name = "CreationUser";
            this.Text = "CreationUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_login;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.CheckBox checkBox_activated;
        private System.Windows.Forms.Button button_ajout;
    }
}