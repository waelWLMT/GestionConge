﻿using BLL.Iservices;
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

namespace MyApp_WinForms.MyForms
{
    public partial class Login : Form

    {
        private readonly IUserService _userService;

        public Login()
        {
            this._userService = new UserService();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = login_txt.Text;
            var password = pwd_txt.Text;

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
                    this.Close();
                }

            }

            if (user != null)
            {
                var message = "Login est mot de passe correct";
                MessageBox.Show(message);
            }
        }
    }
}