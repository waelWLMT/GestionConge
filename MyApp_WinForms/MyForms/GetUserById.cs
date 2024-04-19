using BLL.Iservices;
using BLL.Services;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp_WinForms.MyForms
{
    public partial class GetUserById : Form
    {
        private readonly IUserService _userService;

        public GetUserById()
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

        private void txt_UserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetUserById_Load(object sender, EventArgs e)
        {

        }
    }
}
