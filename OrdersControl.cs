using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject23123 {
public partial class OrdersControl : UserControl
    {
        public OrdersControl()
        {
            InitializeComponent();
            LoadOrders();
        }

        public void LoadOrders()
        {
            // Отключаем событие, пока обновляем источник данных
            dgvOrders.SelectionChanged -= dgvOrders_SelectionChanged;

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = new BindingList<Order>(OrderRepository.Orders);

            if (dgvOrders.Columns.Count > 0)
            {
                foreach (DataGridViewColumn c in dgvOrders.Columns)
                    c.Visible = false;

                SetColumn("Id", "№", 60, DataGridViewAutoSizeColumnMode.None, "N0", null);
                SetColumn("CreatedAt", "Дата", 140, DataGridViewAutoSizeColumnMode.None, null, "dd.MM.yyyy HH:mm");
                SetColumn("ClientName", "Клиент", 0, DataGridViewAutoSizeColumnMode.Fill, null, null);
                SetColumn("TotalItems", "Позиций", 90, DataGridViewAutoSizeColumnMode.None, "N0", null);
                SetColumn("TotalSum", "Сумма", 120, DataGridViewAutoSizeColumnMode.None, "N0", null);
            }

            // Включаем событие обратно
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;

            // Если строки есть — выделяем первую и показываем её детали
            if (dgvOrders.Rows.Count > 0)
            {
                dgvOrders.Rows[0].Selected = true;
                dgvOrders.CurrentCell = dgvOrders.Rows[0].Cells[0];
                ShowDetails(dgvOrders.Rows[0].DataBoundItem as Order);
            }
            else
            {
                ShowDetails(null);
            }
        }

        private void SetColumn(string name, string header, int width,
                               DataGridViewAutoSizeColumnMode mode,
                               string cellFormat, string dateFormat)
        {
            if (!dgvOrders.Columns.Contains(name)) return;

            var col = dgvOrders.Columns[name];
            if (col == null) return;

            col.Visible = true;
            col.HeaderText = header;

            col.AutoSizeMode = mode;

            if (mode == DataGridViewAutoSizeColumnMode.None)
                col.Width = width;

            if (!string.IsNullOrEmpty(cellFormat))
                col.DefaultCellStyle.Format = cellFormat;

            if (!string.IsNullOrEmpty(dateFormat))
                col.DefaultCellStyle.Format = dateFormat;
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                ShowDetails(null);
                return;
            }

            var order = dgvOrders.CurrentRow.DataBoundItem as Order;
            ShowDetails(order);
        }

        private void ShowDetails(Order order)
        {
            lstComposition.Items.Clear();

            if (order == null)
            {
                lblTotalItemsValue.Text = "0";
                lblTotalSumValue.Text = "0 ₽";
                return;
            }

            lblTotalItemsValue.Text = order.TotalItems.ToString();
            lblTotalSumValue.Text = order.TotalSum.ToString("N0") + " ₽";

            foreach (var kvp in order.Items)
            {
                string category = TranslateCategory(kvp.Key);
                lstComposition.Items.Add($"{category}: {kvp.Value.Name} — {kvp.Value.Price:N0} ₽");
            }
        }

        private string TranslateCategory(string key)
        {
            switch (key)
            {
                case "cpu": return "Процессор";
                case "mb": return "Мат. плата";
                case "psu": return "Блок питания";
                case "gpu": return "Видеокарта";
                case "cool": return "Охлаждение";
                case "ram": return "ОЗУ";
                case "storage": return "Накопители";
                case "case": return "Корпус";
                case "sound": return "Звуковая карта";
                case "extra": return "Доп. детали";
                case "peripheral": return "Периферия";
                case "software": return "ПО";
                default: return key;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var order = dgvOrders.CurrentRow?.DataBoundItem as Order;
            if (order == null)
            {
                MessageBox.Show("Выберите заказ для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить заказ №{order.Id}?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            OrderRepository.Orders.Remove(order);
            LoadOrders();
        }
    }
}