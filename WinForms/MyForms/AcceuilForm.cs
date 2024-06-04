using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.MyForms
{
    public partial class AcceuilForm : Form
    {
        public AcceuilForm()
        {
            InitializeComponent();
        }

        private void AcceuilForm_Load(object sender, EventArgs e)
        {

        }

       

        private void pict_users_Click(object sender, EventArgs e)
        {
            Hide();
            GestionUserForm GestionUser = new GestionUserForm();
            GestionUser.Closed += (s, args) => this.Close();
            GestionUser.Show();
        }

        private void labUsers_Click(object sender, EventArgs e)
        {
            Hide();
            GestionUserForm GestionUser = new GestionUserForm();
            GestionUser.Closed += (s, args) => this.Close();
            GestionUser.Show();

        }

        private void lab_deconnecter_Click(object sender, EventArgs e)
        {
            Hide();
            AuthentificationFrm authentification = new AuthentificationFrm();
            authentification.Closed += (s, args) => this.Close();
            authentification.Show();
        }

        private void btn_deconnection_Click(object sender, EventArgs e)
        {
            Hide();
            AuthentificationFrm authentification = new AuthentificationFrm();
            authentification.Closed += (s, args) => this.Close();
            authentification.Show();
        }

        private void pict_voitures_Click(object sender, EventArgs e)
        {
            Hide();
            GestionVoituresForm voiture = new GestionVoituresForm();
            voiture.Closed += (s, args) => this.Close();
            voiture.Show();
        }
    }
}
