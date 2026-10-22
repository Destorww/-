using MyProject23123;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject23123
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            // Привязываем список клиентов к DataGridView
            dgvClients.DataSource = null;
            dgvClients.DataSource = ClientRepository.Clients;

            // Красивые заголовки столбцов
            if (dgvClients.Columns.Count > 0)
            {
                dgvClients.Columns["Name"].HeaderText = "Имя";
                dgvClients.Columns["Email"].HeaderText = "Эл. почта";
                dgvClients.Columns["Phone"].HeaderText = "Телефон";
                dgvClients.Columns["DeliveryType"].HeaderText = "Тип получения";
                dgvClients.Columns["City"].HeaderText = "Город";
                dgvClients.Columns["Street"].HeaderText = "Улица";
                dgvClients.Columns["Entrance"].HeaderText = "Подъезд";
                dgvClients.Columns["Flat"].HeaderText = "Квартира";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
