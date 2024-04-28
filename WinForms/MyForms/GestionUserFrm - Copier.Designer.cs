
namespace WinForms.MyForms
{
    partial class GestionUserFrm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_actualiser = new System.Windows.Forms.Button();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.checkBox_Active = new System.Windows.Forms.CheckBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_check_active = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_actualiser_tableau = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_actualiser);
            this.splitContainer1.Panel1.Controls.Add(this.text_login);
            this.splitContainer1.Panel1.Controls.Add(this.text_pwd);
            this.splitContainer1.Panel1.Controls.Add(this.label_login);
            this.splitContainer1.Panel1.Controls.Add(this.label_pwd);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_Active);
            this.splitContainer1.Panel1.Controls.Add(this.btn_recherche);
            this.splitContainer1.Panel1.Controls.Add(this.btn_modifier);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ajout);
            this.splitContainer1.Panel1.Controls.Add(this.text_prenom);
            this.splitContainer1.Panel1.Controls.Add(this.text_nom);
            this.splitContainer1.Panel1.Controls.Add(this.text_id);
            this.splitContainer1.Panel1.Controls.Add(this.label_prenom);
            this.splitContainer1.Panel1.Controls.Add(this.label_check_active);
            this.splitContainer1.Panel1.Controls.Add(this.label_nom);
            this.splitContainer1.Panel1.Controls.Add(this.label_id);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.button_supprimer);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.button_actualiser_tableau);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewUsers);
            this.splitContainer1.Size = new System.Drawing.Size(1183, 535);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_actualiser
            // 
            this.button_actualiser.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_actualiser.Location = new System.Drawing.Point(297, 283);
            this.button_actualiser.Name = "button_actualiser";
            this.button_actualiser.Size = new System.Drawing.Size(144, 37);
            this.button_actualiser.TabIndex = 16;
            this.button_actualiser.Text = "Actualiser";
            this.button_actualiser.UseVisualStyleBackColor = true;
            this.button_actualiser.Click += new System.EventHandler(this.button_actualiser_Click);
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(107, 153);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(100, 22);
            this.text_login.TabIndex = 15;
            // 
            // text_pwd
            // 
            this.text_pwd.Location = new System.Drawing.Point(371, 151);
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.Size = new System.Drawing.Size(100, 22);
            this.text_pwd.TabIndex = 14;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_login.Location = new System.Drawing.Point(24, 153);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(66, 20);
            this.label_login.TabIndex = 13;
            this.label_login.Text = "Login :";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_pwd.Location = new System.Drawing.Point(245, 153);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(120, 20);
            this.label_pwd.TabIndex = 12;
            this.label_pwd.Text = "Mot de passe :";
            // 
            // checkBox_Active
            // 
            this.checkBox_Active.AutoSize = true;
            this.checkBox_Active.Location = new System.Drawing.Point(371, 51);
            this.checkBox_Active.Name = "checkBox_Active";
            this.checkBox_Active.Size = new System.Drawing.Size(18, 17);
            this.checkBox_Active.TabIndex = 11;
            this.checkBox_Active.UseVisualStyleBackColor = true;
            // 
            // btn_recherche
            // 
            this.btn_recherche.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_recherche.Location = new System.Drawing.Point(28, 283);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(144, 37);
            this.btn_recherche.TabIndex = 10;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_modifier.Location = new System.Drawing.Point(297, 220);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(143, 37);
            this.btn_modifier.TabIndex = 9;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ajout.Location = new System.Drawing.Point(28, 220);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(144, 37);
            this.btn_ajout.TabIndex = 8;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(371, 100);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(100, 22);
            this.text_prenom.TabIndex = 7;
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(107, 99);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(100, 22);
            this.text_nom.TabIndex = 5;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(107, 51);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 22);
            this.text_id.TabIndex = 4;
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_prenom.Location = new System.Drawing.Point(245, 102);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(81, 20);
            this.label_prenom.TabIndex = 3;
            this.label_prenom.Text = "Prénom :";
            // 
            // label_check_active
            // 
            this.label_check_active.AutoSize = true;
            this.label_check_active.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_check_active.Location = new System.Drawing.Point(245, 54);
            this.label_check_active.Name = "label_check_active";
            this.label_check_active.Size = new System.Drawing.Size(101, 20);
            this.label_check_active.TabIndex = 2;
            this.label_check_active.Text = "Est Activé :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_nom.Location = new System.Drawing.Point(24, 102);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(56, 20);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "Nom :";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(24, 54);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 20);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ld :";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(17, 99);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 30;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(740, 349);
            this.dataGridViewUsers.TabIndex = 13;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_supprimer.Location = new System.Drawing.Point(460, 454);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(297, 37);
            this.button_supprimer.TabIndex = 12;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_actualiser_tableau
            // 
            this.button_actualiser_tableau.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualiser_tableau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_actualiser_tableau.Location = new System.Drawing.Point(17, 469);
            this.button_actualiser_tableau.Name = "button_actualiser_tableau";
            this.button_actualiser_tableau.Size = new System.Drawing.Size(321, 37);
            this.button_actualiser_tableau.TabIndex = 11;
            this.button_actualiser_tableau.Text = "Actualiser";
            this.button_actualiser_tableau.UseVisualStyleBackColor = true;
            this.button_actualiser_tableau.Click += new System.EventHandler(this.button_actualiser_tableau_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Liste utilisateurs";
            // 
            // GestionUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1183, 535);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GestionUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion utilisateurs";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_check_active;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_actualiser_tableau;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox checkBox_Active;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button button_actualiser;
    }
}