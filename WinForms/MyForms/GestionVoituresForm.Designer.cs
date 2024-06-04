
namespace WinForms.MyForms
{
    partial class GestionVoituresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVoituresForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_menu = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_model = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_voiture_id = new System.Windows.Forms.TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.text_immatriculation = new System.Windows.Forms.TextBox();
            this.comboBox_Marque = new System.Windows.Forms.ComboBox();
            this.comboBox_Propriétaire = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_enregister = new Guna.UI2.WinForms.Guna2Button();
            this.button_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.text_annee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1398, 52);
            this.guna2Panel1.TabIndex = 20;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1341, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(520, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestion des voitures";
            // 
            // lab_menu
            // 
            this.lab_menu.AutoSize = true;
            this.lab_menu.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_menu.ForeColor = System.Drawing.Color.Teal;
            this.lab_menu.Location = new System.Drawing.Point(1230, 669);
            this.lab_menu.Name = "lab_menu";
            this.lab_menu.Size = new System.Drawing.Size(156, 22);
            this.lab_menu.TabIndex = 21;
            this.lab_menu.Text = "Menu principal";
            this.lab_menu.Click += new System.EventHandler(this.lab_menu_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 15;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1184, 661);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(41, 43);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 22;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 23;
            // 
            // lab_model
            // 
            this.lab_model.AutoSize = true;
            this.lab_model.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_model.ForeColor = System.Drawing.Color.Teal;
            this.lab_model.Location = new System.Drawing.Point(41, 116);
            this.lab_model.Name = "lab_model";
            this.lab_model.Size = new System.Drawing.Size(107, 27);
            this.lab_model.TabIndex = 30;
            this.lab_model.Text = "Voiture Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(766, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "Modèle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(231, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "Immatriculation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(523, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 33;
            this.label5.Text = "Marque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(1092, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nom & Prénom Propriétaire";
            // 
            // text_voiture_id
            // 
            this.text_voiture_id.AcceptsTab = true;
            this.text_voiture_id.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_voiture_id.Location = new System.Drawing.Point(35, 156);
            this.text_voiture_id.Name = "text_voiture_id";
            this.text_voiture_id.Size = new System.Drawing.Size(121, 29);
            this.text_voiture_id.TabIndex = 35;
            // 
            // text_immatriculation
            // 
            this.text_immatriculation.AcceptsTab = true;
            this.text_immatriculation.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.text_immatriculation.Location = new System.Drawing.Point(201, 156);
            this.text_immatriculation.Name = "text_immatriculation";
            this.text_immatriculation.Size = new System.Drawing.Size(204, 29);
            this.text_immatriculation.TabIndex = 36;
            // 
            // comboBox_Marque
            // 
            this.comboBox_Marque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Marque.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.comboBox_Marque.FormattingEnabled = true;
            this.comboBox_Marque.Location = new System.Drawing.Point(453, 157);
            this.comboBox_Marque.Name = "comboBox_Marque";
            this.comboBox_Marque.Size = new System.Drawing.Size(217, 30);
            this.comboBox_Marque.TabIndex = 37;
            this.comboBox_Marque.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marque_SelectedIndexChanged);
            // 
            // comboBox_Propriétaire
            // 
            this.comboBox_Propriétaire.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.comboBox_Propriétaire.FormattingEnabled = true;
            this.comboBox_Propriétaire.Location = new System.Drawing.Point(1097, 155);
            this.comboBox_Propriétaire.Name = "comboBox_Propriétaire";
            this.comboBox_Propriétaire.Size = new System.Drawing.Size(247, 30);
            this.comboBox_Propriétaire.TabIndex = 38;
            this.comboBox_Propriétaire.SelectedIndexChanged += new System.EventHandler(this.comboBox_Propriétaire_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(526, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 32);
            this.label7.TabIndex = 40;
            this.label7.Text = "Liste des voitures";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1325, 325);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_enregister
            // 
            this.button_enregister.AutoRoundedCorners = true;
            this.button_enregister.BackColor = System.Drawing.Color.Transparent;
            this.button_enregister.BorderRadius = 22;
            this.button_enregister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_enregister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_enregister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_enregister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_enregister.FillColor = System.Drawing.Color.Teal;
            this.button_enregister.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button_enregister.ForeColor = System.Drawing.Color.White;
            this.button_enregister.Location = new System.Drawing.Point(360, 213);
            this.button_enregister.Name = "button_enregister";
            this.button_enregister.Size = new System.Drawing.Size(196, 47);
            this.button_enregister.TabIndex = 42;
            this.button_enregister.Text = "Enregister";
            // 
            // button_modifier
            // 
            this.button_modifier.AutoRoundedCorners = true;
            this.button_modifier.BackColor = System.Drawing.Color.Transparent;
            this.button_modifier.BorderRadius = 22;
            this.button_modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_modifier.FillColor = System.Drawing.Color.Teal;
            this.button_modifier.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button_modifier.ForeColor = System.Drawing.Color.White;
            this.button_modifier.Location = new System.Drawing.Point(642, 213);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(196, 47);
            this.button_modifier.TabIndex = 43;
            this.button_modifier.Text = "Modifier";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Teal;
            this.guna2Button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(924, 213);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(196, 47);
            this.guna2Button1.TabIndex = 44;
            this.guna2Button1.Text = "Supprimer";
            // 
            // text_annee
            // 
            this.text_annee.AcceptsTab = true;
            this.text_annee.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.text_annee.Location = new System.Drawing.Point(943, 158);
            this.text_annee.Name = "text_annee";
            this.text_annee.Size = new System.Drawing.Size(116, 29);
            this.text_annee.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(963, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 27);
            this.label8.TabIndex = 46;
            this.label8.Text = "Année";
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(702, 158);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(217, 30);
            this.comboBox_Model.TabIndex = 47;
            this.comboBox_Model.SelectedIndexChanged += new System.EventHandler(this.comboBox_Model_SelectedIndexChanged);
            // 
            // GestionVoituresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1398, 736);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_annee);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_enregister);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Propriétaire);
            this.Controls.Add(this.comboBox_Marque);
            this.Controls.Add(this.text_immatriculation);
            this.Controls.Add(this.text_voiture_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lab_menu);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionVoituresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nom & Prénom Propriétaire";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_menu;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.TextBox text_voiture_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_model;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.ComboBox comboBox_Marque;
        private System.Windows.Forms.TextBox text_immatriculation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Propriétaire;
        private Guna.UI2.WinForms.Guna2Button button_enregister;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button button_modifier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_annee;
        private System.Windows.Forms.ComboBox comboBox_Model;
    }
}