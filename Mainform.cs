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
    public partial class MainForm : Form
    {
        private ClientDataControl _clientDataControl;
        private BuildConfigControl _buildControl;
        private ClientsControl _clientsControl;
        private OrdersControl _ordersControl;

        public static MainForm Instance { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _clientDataControl = new ClientDataControl { Dock = DockStyle.Fill };
            tabClient.Controls.Add(_clientDataControl);

            _buildControl = new BuildConfigControl { Dock = DockStyle.Fill };
            tabBuild.Controls.Add(_buildControl);

            _clientsControl = new ClientsControl { Dock = DockStyle.Fill };
            tabClients.Controls.Add(_clientsControl);

            _ordersControl = new OrdersControl { Dock = DockStyle.Fill };
            tabOrders.Controls.Add(_ordersControl);
        }

        public void ShowClientsTab()
        {
            _clientsControl?.LoadClients();
            tabControl1.SelectedTab = tabClients;
        }

        public void ShowOrdersTab()
        {
            _ordersControl?.LoadOrders();
            tabControl1.SelectedTab = tabOrders;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Instance = null;
            base.OnFormClosed(e);
        }
    }
}