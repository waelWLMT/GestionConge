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
    public partial class DeleteUser : Form
    {
        private readonly IUserService _userService;
        public DeleteUser()
        {
            InitializeComponent();
            this._userService = new UserService();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            User user = new User();
            int idUser = Convert.ToInt32(txt_UserId.Text);

            user = _userService.AfficherUserById(idUser);
            txt_login.Text = user.Login;
            txt_pwd.Text = user.Password;
            checkBox_activated.Checked = user.Activated;
        }

        private void btn_ok_delete_Click(object sender, EventArgs e)
        {
            int idUser = Convert.ToInt32(txt_UserId.Text);

            string message = "Avez vous sûre de supprimer cette user  N°" +idUser;
            string title = "Suppression User";
            MessageBox.Show(message, title);

            _userService.SuppressionUser(idUser);

            string message1 = "Votre user a été supprimer avec success";
            string title1 = "Suppression User";
            MessageBox.Show(message1, title1);
        }
    }
}
