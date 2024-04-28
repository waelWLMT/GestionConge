using BLL.IServices;
using BLL.Services;
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
    public partial class AuthentificationFrm : Form
    {
        private readonly IUserService _userService;
        public AuthentificationFrm()
        {
            InitializeComponent();
            this._userService = new UserService();
        }

        private void button_seconnecter_Click(object sender, EventArgs e)
        {
            var login = text_login.Text;
            var password = text_pwd.Text;

            var user = _userService.Authenticate(login, password);
            if (user == null)
            {
                string message = "login ou mot de passe incorrect";
                string title = "login failed";
                //MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;

                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result =
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


                if (result == DialogResult.OK)
                {
                    this.ResetText();
                }

            }

            if (user != null)
            {
                Hide();
                AcceuilForm acceuil = new AcceuilForm();
                acceuil.Closed += (s, args) => this.Close();
                acceuil.Show();

            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
