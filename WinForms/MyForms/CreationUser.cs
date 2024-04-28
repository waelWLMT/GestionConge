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
    public partial class CreationUser : Form
    {

        private  readonly IUserService _userSerive;
        public CreationUser()
        {
            _userSerive = new UserService();
           
            InitializeComponent();
        }

        private void button_ajout_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = text_login.Text;
            user.Password = text_password.Text;
            user.Activated = checkBox_activated.Checked;

            _userSerive.CreationUser(user);

        }

        private void text_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
