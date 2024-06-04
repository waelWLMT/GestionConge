
namespace WinForms.MyForms
{
    partial class AcceuilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceuilForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pict_users = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pict_voitures = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pict_entretiens = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labUsers = new System.Windows.Forms.Label();
            this.lab_voitures = new System.Windows.Forms.Label();
            this.lab_entretiens = new System.Windows.Forms.Label();
            this.btn_deconnection = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lab_deconnecter = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_voitures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_entretiens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deconnection)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(915, 52);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Menu principal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 35);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(361, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Développer by me ❤️";
            // 
            // pict_users
            // 
            this.pict_users.BackColor = System.Drawing.Color.Transparent;
            this.pict_users.BorderRadius = 15;
            this.pict_users.Image = ((System.Drawing.Image)(resources.GetObject("pict_users.Image")));
            this.pict_users.ImageRotate = 0F;
            this.pict_users.Location = new System.Drawing.Point(90, 117);
            this.pict_users.Name = "pict_users";
            this.pict_users.Size = new System.Drawing.Size(176, 159);
            this.pict_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_users.TabIndex = 2;
            this.pict_users.TabStop = false;
            this.pict_users.UseTransparentBackground = true;
            this.pict_users.Click += new System.EventHandler(this.pict_users_Click);
            // 
            // pict_voitures
            // 
            this.pict_voitures.BackColor = System.Drawing.Color.Transparent;
            this.pict_voitures.BorderRadius = 15;
            this.pict_voitures.Image = ((System.Drawing.Image)(resources.GetObject("pict_voitures.Image")));
            this.pict_voitures.ImageRotate = 0F;
            this.pict_voitures.Location = new System.Drawing.Point(378, 117);
            this.pict_voitures.Name = "pict_voitures";
            this.pict_voitures.Size = new System.Drawing.Size(176, 159);
            this.pict_voitures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_voitures.TabIndex = 3;
            this.pict_voitures.TabStop = false;
            this.pict_voitures.UseTransparentBackground = true;
            this.pict_voitures.Click += new System.EventHandler(this.pict_voitures_Click);
            // 
            // pict_entretiens
            // 
            this.pict_entretiens.BackColor = System.Drawing.Color.Transparent;
            this.pict_entretiens.BorderRadius = 15;
            this.pict_entretiens.Image = ((System.Drawing.Image)(resources.GetObject("pict_entretiens.Image")));
            this.pict_entretiens.ImageRotate = 0F;
            this.pict_entretiens.Location = new System.Drawing.Point(693, 113);
            this.pict_entretiens.Name = "pict_entretiens";
            this.pict_entretiens.Size = new System.Drawing.Size(176, 159);
            this.pict_entretiens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_entretiens.TabIndex = 4;
            this.pict_entretiens.TabStop = false;
            this.pict_entretiens.UseTransparentBackground = true;
            // 
            // labUsers
            // 
            this.labUsers.AutoSize = true;
            this.labUsers.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsers.ForeColor = System.Drawing.Color.Teal;
            this.labUsers.Location = new System.Drawing.Point(103, 279);
            this.labUsers.Name = "labUsers";
            this.labUsers.Size = new System.Drawing.Size(141, 22);
            this.labUsers.TabIndex = 1;
            this.labUsers.Text = "Gestion Users";
            this.labUsers.Click += new System.EventHandler(this.labUsers_Click);
            // 
            // lab_voitures
            // 
            this.lab_voitures.AutoSize = true;
            this.lab_voitures.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_voitures.ForeColor = System.Drawing.Color.Teal;
            this.lab_voitures.Location = new System.Drawing.Point(391, 279);
            this.lab_voitures.Name = "lab_voitures";
            this.lab_voitures.Size = new System.Drawing.Size(169, 22);
            this.lab_voitures.TabIndex = 5;
            this.lab_voitures.Text = "Gestion Voitures";
            // 
            // lab_entretiens
            // 
            this.lab_entretiens.AutoSize = true;
            this.lab_entretiens.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_entretiens.ForeColor = System.Drawing.Color.Teal;
            this.lab_entretiens.Location = new System.Drawing.Point(683, 284);
            this.lab_entretiens.Name = "lab_entretiens";
            this.lab_entretiens.Size = new System.Drawing.Size(190, 22);
            this.lab_entretiens.TabIndex = 6;
            this.lab_entretiens.Text = "Gestion Entretiens";
            // 
            // btn_deconnection
            // 
            this.btn_deconnection.BackColor = System.Drawing.Color.Transparent;
            this.btn_deconnection.BorderRadius = 15;
            this.btn_deconnection.Image = ((System.Drawing.Image)(resources.GetObject("btn_deconnection.Image")));
            this.btn_deconnection.ImageRotate = 0F;
            this.btn_deconnection.Location = new System.Drawing.Point(709, 374);
            this.btn_deconnection.Name = "btn_deconnection";
            this.btn_deconnection.Size = new System.Drawing.Size(41, 43);
            this.btn_deconnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_deconnection.TabIndex = 7;
            this.btn_deconnection.TabStop = false;
            this.btn_deconnection.UseTransparentBackground = true;
            this.btn_deconnection.Click += new System.EventHandler(this.btn_deconnection_Click);
            // 
            // lab_deconnecter
            // 
            this.lab_deconnecter.AutoSize = true;
            this.lab_deconnecter.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_deconnecter.ForeColor = System.Drawing.Color.Teal;
            this.lab_deconnecter.Location = new System.Drawing.Point(750, 385);
            this.lab_deconnecter.Name = "lab_deconnecter";
            this.lab_deconnecter.Size = new System.Drawing.Size(153, 22);
            this.lab_deconnecter.TabIndex = 8;
            this.lab_deconnecter.Text = "Se déconnecter";
            this.lab_deconnecter.Click += new System.EventHandler(this.lab_deconnecter_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(858, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 9;
            // 
            // AcceuilForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 461);
            this.Controls.Add(this.lab_deconnecter);
            this.Controls.Add(this.btn_deconnection);
            this.Controls.Add(this.lab_entretiens);
            this.Controls.Add(this.lab_voitures);
            this.Controls.Add(this.labUsers);
            this.Controls.Add(this.pict_entretiens);
            this.Controls.Add(this.pict_voitures);
            this.Controls.Add(this.pict_users);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcceuilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_voitures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_entretiens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deconnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_gestion_users;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox pic_gestion_users;
        private System.Windows.Forms.Label label_sedeconnecter;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox pict_users;
        private Guna.UI2.WinForms.Guna2PictureBox pict_voitures;
        private Guna.UI2.WinForms.Guna2PictureBox pict_entretiens;
        private System.Windows.Forms.Label labUsers;
        private System.Windows.Forms.Label lab_voitures;
        private System.Windows.Forms.Label lab_entretiens;
        private Guna.UI2.WinForms.Guna2PictureBox btn_deconnection;
        private System.Windows.Forms.Label lab_deconnecter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}