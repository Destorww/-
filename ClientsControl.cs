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
    public partial class ClientsControl : UserControl
    {
        public ClientsControl()
        {
            InitializeComponent();
            LoadClients();
        }

        public void LoadClients()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = new BindingList<Client>(ClientRepository.Clients);

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

            // Показываем заглушку, если список пуст
            lblEmpty.Visible = ClientRepository.Clients.Count == 0;
            dgvClients.Visible = ClientRepository.Clients.Count > 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}