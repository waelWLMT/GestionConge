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
    public partial class GestionVoituresForm : Form
    {
        private readonly ICarService _carService;

        public GestionVoituresForm()
        {
            this._carService = new CarService();
            InitializeComponent();
            LoadDataUser();
            LoadData();
            Modificationcolonne();
            Supprimercolonne();
            LoadDataMarque();
            LoadDataModel();
        }

        private void lab_menu_Click(object sender, EventArgs e)
        {
            Hide();
            AcceuilForm acceuil = new AcceuilForm();
            acceuil.Closed += (s, args) => this.Close();
            acceuil.Show();
        }

        private void LoadDataUser()
        {
            List<User> users = new List<User>();
            users = _carService.GetNomPrenomProprietaire();
            comboBox_Propriétaire.DataSource = users;
            comboBox_Propriétaire.DisplayMember = "Nom & Prénom";
            comboBox_Propriétaire.ValueMember = "UserId";
            comboBox_Propriétaire.Text = "Selectionner Votre propriètaire";
        }

        private void LoadDataMarque()
        {
            List<Marque> marque = new List<Marque>();
            marque = _carService.GetListMarque();
            comboBox_Marque.DataSource = marque;
            comboBox_Marque.DisplayMember = "LibelleMarque";
            comboBox_Marque.ValueMember = "MarqueId";
            comboBox_Marque.Text = "Selectionner Marque";
        }

        private void LoadDataModel()
        {
            List<Model> model = new List<Model>();
            string nameMarque = comboBox_Marque.Items.ToString();
            model = _carService.GetListModel(nameMarque);
            comboBox_Model.DataSource = model;
            comboBox_Model.DisplayMember = "ModelId";
            comboBox_Model.ValueMember = "LibelleModel";
            comboBox_Model.Text = "Selectionner Model";
        }
        private void comboBox_Propriétaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void lab_menu_Click_1(object sender, EventArgs e)
        {
            Hide();
            AcceuilForm acceuil = new AcceuilForm();
            acceuil.Closed += (s, args) => this.Close();
            acceuil.Show();

        }
        private void LoadData()
        {
            List<Voiture>cars = new List<Voiture>();
            cars = _carService.GetListeVoiture();
            dataGridView1.DataSource = cars;
        }
        public void Supprimercolonne()
        {
            DataGridViewImageColumn btnDel =  new DataGridViewImageColumn();
            btnDel.Image = Properties.Resources.supprimer;
            dataGridView1.Columns.Add(btnDel);
            btnDel.Name = "Suppression";
            btnDel.HeaderText = "Suppression";
            btnDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnDel.Width = 100;
        }
        public void Modificationcolonne()
        {
            DataGridViewImageColumn btnEdit = new DataGridViewImageColumn();
            btnEdit.Image = Properties.Resources.edit_validated_40458;
            dataGridView1.Columns.Add(btnEdit);
            btnEdit.Name = "Modification";
            btnEdit.HeaderText = "Modification";
            btnEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnEdit.Width = 100;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void comboBox_Marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataMarque();

        }

        private void comboBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataModel();
        }
    }
}
