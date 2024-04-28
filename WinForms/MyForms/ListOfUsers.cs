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
    public partial class ListOfUsers : Form
    {
        private readonly IUserService _userService;
        public ListOfUsers()
        {
            InitializeComponent();
            this._userService = new UserService();
            this.loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void loadData()
        {
            List<User> users = new List<User>();
            users = _userService.GetListUsers();
            dataGridView1.DataSource = users;
        }
    }
}
