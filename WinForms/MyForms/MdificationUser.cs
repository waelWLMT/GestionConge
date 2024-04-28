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
    public partial class ModificationUser : Form
    {
        private readonly IUserService _userService;
        public ModificationUser()
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

        private void btn_ok_update_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt32(txt_UserId.Text);
            user.Login = txt_login.Text;
            user.Password = txt_pwd.Text;
            user.Activated = checkBox_activated.Checked;

            string message= "vous êtes sûr de tes modifications ?";
            string title = "Modification User";
            MessageBox.Show(message, title);

            _userService.ModificationUser(user);
            string message1 = "Votre user a été modifier avec success";
            string title1 = "Modification User";
            MessageBox.Show(message1, title1);

        }
    }
}
