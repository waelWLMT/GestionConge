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
using System.Windows;
using System.Windows.Forms;

namespace WinForms.MyForms
{
    public partial class GestionUserForm : Form
    {
        private readonly IUserService _userService;
        public GestionUserForm()
        {
            this._userService = new UserService();
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            List<User> users = new List<User>();
            users = _userService.GetListUsers();
            dataGridViewUsers.DataSource = users;
        }

        private void LoadFormulaire()
        {
            text_id.Text = null;
            text_nom.Text = "";
            text_prenom.Text = "";
            text_login.Text = "";
            text_pwd.Text = "";
            checkBox_active.Checked = false;
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
            checkBox_active.Checked = user.Activated;
        }

        private void RechercheByName()
        {
            User user = new User();
            string name = text_nom.Text;
            user = _userService.AfficherbyName(name);
            text_id.Text = user.UserId.ToString();
            text_prenom.Text = user.Prenom;
            text_login.Text = user.Login;
            text_pwd.Text = user.Password;
            checkBox_active.Checked = user.Activated;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.Nom = text_nom.Text;
            user.Prenom = text_prenom.Text;
            user.Login = text_login.Text;
            user.Password = text_pwd.Text;
            user.Activated = checkBox_active.Checked;

            _userService.CreationUser(user);
            LoadFormulaire();

            LoadData();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            if (text_nom.Text != null && text_nom.Text != string.Empty)
            {
                RechercheByName();
            }
            else
                RechercheById();
        }

        private void button_actualiser_Click(object sender, EventArgs e)
        {
            LoadFormulaire();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt32(text_id.Text);
            user.Nom = text_nom.Text;
            user.Prenom = text_prenom.Text;
            user.Login = text_login.Text;
            user.Password = text_pwd.Text;
            user.Activated = checkBox_active.Checked;
            _userService.ModificationUser(user);
            LoadFormulaire();
            LoadData();

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId;
            userId = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;
            User user = new User();
            user = _userService.AfficherUserById(userId);
            text_id.Text = user.UserId.ToString();
            text_nom.Text = user.Nom;
            text_prenom.Text = user.Prenom;
            text_login.Text = user.Login;
            text_pwd.Text = user.Password;
            checkBox_active.Checked = user.Activated;
        }

        private void button_actualiser_grid_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int userId;
            userId = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                _userService.SuppressionUser(userId);
                string message1 = "Votre user a été supprimer avec success";
                string title1 = "Suppression User";
                System.Windows.MessageBox.Show(message1, title1);

            }
            else
            {
                string message1 = "Votre user ne peut pas être supprimer";
                string title1 = "Suppression User";
                System.Windows.MessageBox.Show(message1, title1);
            }
 
            
            LoadData();


        }
    }
}
