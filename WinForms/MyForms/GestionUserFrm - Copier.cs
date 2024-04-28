using BLL.IServices;
using BLL.Services;
using Core.Models;
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
    public partial class GestionUserFrm : Form
    {
        private readonly IUserService _userService;
        public GestionUserFrm()

        {
            InitializeComponent();
            this._userService = new UserService();
            LoadData();
        }

        private void GestionUserFrm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            List<User> users = new List<User>();
            users = _userService.GetListUsers();
            dataGridViewUsers.DataSource = users;
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Nom = text_nom.Text;
            user.Prenom = text_prenom.Text;
            user.Login = text_login.Text;
            user.Password = text_pwd.Text;
            user.Activated = checkBox_Active.Checked;

            _userService.CreationUser(user);
            LoadData();

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Nom = text_nom.Text;
            user.Prenom = text_prenom.Text;
            user.Login = text_login.Text;
            user.Password = text_pwd.Text;
            user.Activated = checkBox_Active.Checked;
            _userService.ModificationUser(user);
            LoadData();

        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {

            if (text_nom.Text != null && text_nom.Text !=string.Empty)
            {
                RechercheByName();
            }
            else
                RechercheById();
        }
        private void RechercheById()
        {
            User user = new User();
            int idUser = Convert.ToInt32(text_id.Text);
            user = _userService.AfficherUserById(idUser);
            text_nom.Text = user.Nom;
            text_prenom.Text = user.Prenom;
            text_login.Text = user.Login;
            text_pwd.Text = user.Password;
            checkBox_Active.Checked = user.Activated;
        }

        private void RechercheByName()
        {
            User user = new User();
            string name = text_nom.Text;
            user = _userService.AfficherbyName(name);
            text_id.Text= user.UserId.ToString();
            text_prenom.Text = user.Prenom;
            text_login.Text = user.Login;
            text_pwd.Text = user.Password;
            checkBox_Active.Checked = user.Activated;
        }

        private void button_actualiser_Click(object sender, EventArgs e)
        {
            text_id.Text = null;
            text_nom.Text = "";
            text_prenom.Text = "";
            text_login.Text = "";
            text_pwd.Text = "";
            checkBox_Active.Checked =false;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int userId;
            userId = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;

            string message = "Avez vous sûre de supprimer cette user  N°" + userId;
            string title = "Suppression User";
            MessageBox.Show(message, title);

            _userService.SuppressionUser(userId);

            string message1 = "Votre user a été supprimer avec success";
            string title1 = "Suppression User";
            MessageBox.Show(message1, title1);
        }

        private void button_actualiser_tableau_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId;
            userId = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;
            User user = new User();
            user = _userService.AfficherUserById(userId);
            text_nom.Text = user.Nom;
            text_prenom.Text = user.Prenom;
            text_login.Text = user.Login;
            text_pwd.Text = user.Password;
            checkBox_Active.Checked = user.Activated;
        }

    }

}
