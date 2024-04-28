
namespace WinForms.MyForms
{
    partial class GestionUserForm
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
            System.Windows.Forms.Label lab_id;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lab_nom;
            System.Windows.Forms.Label lab_pwd;
            System.Windows.Forms.Label lab_login;
            System.Windows.Forms.Label lab_prenom;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_actualiser = new System.Windows.Forms.Button();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.checkBox_active = new System.Windows.Forms.CheckBox();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_actualiser_grid = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            lab_id = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lab_nom = new System.Windows.Forms.Label();
            lab_pwd = new System.Windows.Forms.Label();
            lab_login = new System.Windows.Forms.Label();
            lab_prenom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_id
            // 
            lab_id.AutoSize = true;
            lab_id.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_id.ForeColor = System.Drawing.Color.White;
            lab_id.Location = new System.Drawing.Point(4, 67);
            lab_id.Name = "lab_id";
            lab_id.Size = new System.Drawing.Size(37, 20);
            lab_id.TabIndex = 30;
            lab_id.Text = "Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(249, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 20);
            label2.TabIndex = 31;
            label2.Text = "Est Activé :";
            // 
            // lab_nom
            // 
            lab_nom.AutoSize = true;
            lab_nom.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_nom.ForeColor = System.Drawing.Color.White;
            lab_nom.Location = new System.Drawing.Point(3, 118);
            lab_nom.Name = "lab_nom";
            lab_nom.Size = new System.Drawing.Size(56, 20);
            lab_nom.TabIndex = 32;
            lab_nom.Text = "Nom :";
            // 
            // lab_pwd
            // 
            lab_pwd.AutoSize = true;
            lab_pwd.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_pwd.ForeColor = System.Drawing.Color.White;
            lab_pwd.Location = new System.Drawing.Point(252, 177);
            lab_pwd.Name = "lab_pwd";
            lab_pwd.Size = new System.Drawing.Size(93, 20);
            lab_pwd.TabIndex = 33;
            lab_pwd.Text = "Password :";
            // 
            // lab_login
            // 
            lab_login.AutoSize = true;
            lab_login.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_login.ForeColor = System.Drawing.Color.White;
            lab_login.Location = new System.Drawing.Point(3, 179);
            lab_login.Name = "lab_login";
            lab_login.Size = new System.Drawing.Size(66, 20);
            lab_login.TabIndex = 34;
            lab_login.Text = "Login :";
            // 
            // lab_prenom
            // 
            lab_prenom.AutoSize = true;
            lab_prenom.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_prenom.ForeColor = System.Drawing.Color.White;
            lab_prenom.Location = new System.Drawing.Point(251, 118);
            lab_prenom.Name = "lab_prenom";
            lab_prenom.Size = new System.Drawing.Size(81, 20);
            lab_prenom.TabIndex = 35;
            lab_prenom.Text = "Prénom :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.button_actualiser);
            this.groupBox1.Controls.Add(this.button_rechercher);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.checkBox_active);
            this.groupBox1.Controls.Add(this.text_pwd);
            this.groupBox1.Controls.Add(this.text_prenom);
            this.groupBox1.Controls.Add(this.text_nom);
            this.groupBox1.Controls.Add(this.text_login);
            this.groupBox1.Controls.Add(this.text_id);
            this.groupBox1.Controls.Add(lab_prenom);
            this.groupBox1.Controls.Add(lab_login);
            this.groupBox1.Controls.Add(lab_pwd);
            this.groupBox1.Controls.Add(lab_nom);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(lab_id);
            this.groupBox1.Controls.Add(this.label_login);
            this.groupBox1.Controls.Add(this.label_nom);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire";
            // 
            // button_actualiser
            // 
            this.button_actualiser.BackColor = System.Drawing.Color.White;
            this.button_actualiser.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualiser.ForeColor = System.Drawing.Color.Red;
            this.button_actualiser.Location = new System.Drawing.Point(306, 311);
            this.button_actualiser.Name = "button_actualiser";
            this.button_actualiser.Size = new System.Drawing.Size(147, 46);
            this.button_actualiser.TabIndex = 10;
            this.button_actualiser.Text = "Actualiser";
            this.button_actualiser.UseVisualStyleBackColor = false;
            this.button_actualiser.Click += new System.EventHandler(this.button_actualiser_Click);
            // 
            // button_rechercher
            // 
            this.button_rechercher.BackColor = System.Drawing.Color.White;
            this.button_rechercher.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rechercher.ForeColor = System.Drawing.Color.Red;
            this.button_rechercher.Location = new System.Drawing.Point(40, 311);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(143, 46);
            this.button_rechercher.TabIndex = 9;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = false;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.Color.White;
            this.button_modifier.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifier.ForeColor = System.Drawing.Color.Red;
            this.button_modifier.Location = new System.Drawing.Point(306, 246);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(147, 46);
            this.button_modifier.TabIndex = 8;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.BackColor = System.Drawing.Color.White;
            this.button_ajouter.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.ForeColor = System.Drawing.Color.Red;
            this.button_ajouter.Location = new System.Drawing.Point(40, 246);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 46);
            this.button_ajouter.TabIndex = 7;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // checkBox_active
            // 
            this.checkBox_active.AutoSize = true;
            this.checkBox_active.Location = new System.Drawing.Point(346, 70);
            this.checkBox_active.Name = "checkBox_active";
            this.checkBox_active.Size = new System.Drawing.Size(18, 17);
            this.checkBox_active.TabIndex = 2;
            this.checkBox_active.UseVisualStyleBackColor = true;
            // 
            // text_pwd
            // 
            this.text_pwd.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.text_pwd.Location = new System.Drawing.Point(341, 172);
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.Size = new System.Drawing.Size(141, 26);
            this.text_pwd.TabIndex = 6;
            // 
            // text_prenom
            // 
            this.text_prenom.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.text_prenom.Location = new System.Drawing.Point(341, 114);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(141, 26);
            this.text_prenom.TabIndex = 4;
            // 
            // text_nom
            // 
            this.text_nom.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.text_nom.Location = new System.Drawing.Point(69, 118);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(148, 26);
            this.text_nom.TabIndex = 3;
            // 
            // text_login
            // 
            this.text_login.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.text_login.Location = new System.Drawing.Point(68, 172);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(149, 26);
            this.text_login.TabIndex = 5;
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.text_id.Location = new System.Drawing.Point(69, 67);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(148, 26);
            this.text_id.TabIndex = 1;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_login.Location = new System.Drawing.Point(-70, 180);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(66, 20);
            this.label_login.TabIndex = 29;
            this.label_login.Text = "Login :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_nom.Location = new System.Drawing.Point(-70, 129);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(56, 20);
            this.label_nom.TabIndex = 18;
            this.label_nom.Text = "Nom :";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(-70, 81);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 20);
            this.label_id.TabIndex = 17;
            this.label_id.Text = "ld :";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(572, 79);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 30;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(810, 349);
            this.dataGridViewUsers.TabIndex = 14;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(783, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Liste des utilisateurs";
            // 
            // button_actualiser_grid
            // 
            this.button_actualiser_grid.BackColor = System.Drawing.Color.White;
            this.button_actualiser_grid.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualiser_grid.ForeColor = System.Drawing.Color.Red;
            this.button_actualiser_grid.Location = new System.Drawing.Point(628, 442);
            this.button_actualiser_grid.Name = "button_actualiser_grid";
            this.button_actualiser_grid.Size = new System.Drawing.Size(265, 39);
            this.button_actualiser_grid.TabIndex = 16;
            this.button_actualiser_grid.Text = "Actualiser";
            this.button_actualiser_grid.UseVisualStyleBackColor = false;
            this.button_actualiser_grid.Click += new System.EventHandler(this.button_actualiser_grid_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.White;
            this.button_supprimer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.Color.Red;
            this.button_supprimer.Location = new System.Drawing.Point(1069, 441);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(265, 40);
            this.button_supprimer.TabIndex = 17;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // GestionUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 538);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_actualiser_grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des utilisateurs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.CheckBox checkBox_active;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_actualiser;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_actualiser_grid;
        private System.Windows.Forms.Button button_supprimer;
    }
}