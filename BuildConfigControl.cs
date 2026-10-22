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
        public partial class BuildConfigControl : UserControl
        {
            private const int RequiredTotal = 8;

            private int _requiredDone = 0;
            private int _totalItems = 0;
            private decimal _totalSum = 0;

            private readonly HashSet<string> _added = new HashSet<string>();

            private ComponentItem _selectedCpu;
            private ComponentItem _selectedMotherboard;

            private readonly Dictionary<string, ComponentItem> _selectedItems
                = new Dictionary<string, ComponentItem>();

            public BuildConfigControl()
            {
                InitializeComponent();
            }

            private void BuildConfigControl_Load(object sender, EventArgs e)
            {
                UpdateProgress();
                UpdateSummary();
            }

            // ================= ОБЯЗАТЕЛЬНЫЕ =================

            private void btnAddCpu_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("cpu", "Процессор");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _selectedCpu = form.SelectedItem;
                    AddItem("cpu", txtCpu, lblCpuReq, form.SelectedItem, required: true);
                }
            }

            private void btnAddMotherboard_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("mb", "Материнская плата");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (_selectedCpu != null && form.SelectedItem.Socket != _selectedCpu.Socket)
                    {
                        var result = MessageBox.Show(
                            $"Сокет материнской платы ({form.SelectedItem.Socket}) не совпадает " +
                            $"с сокетом процессора ({_selectedCpu.Socket}).\n\n" +
                            "Это не помешает добавить, но сборка может не работать.\n\nПродолжить?",
                            "Несовместимость", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result != DialogResult.Yes) return;
                    }

                    _selectedMotherboard = form.SelectedItem;
                    AddItem("mb", txtMotherboard, lblMotherboardReq, form.SelectedItem, required: true);
                }
            }

            private void btnAddPsu_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("psu", "Блок питания");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("psu", txtPsu, lblPsuReq, form.SelectedItem, required: true);
            }

            private void btnAddGpu_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("gpu", "Видеокарта");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("gpu", txtGpu, lblGpuReq, form.SelectedItem, required: true);
            }

            private void btnAddCooling_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("cool", "Охлаждение процессора");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("cool", txtCooling, lblCoolingReq, form.SelectedItem, required: true);
            }

            private void btnAddRam_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("ram", "ОЗУ");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("ram", txtRam, lblRamReq, form.SelectedItem, required: true);
            }

            private void btnAddStorage_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("storage", "Накопители");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("storage", txtStorage, lblStorageReq, form.SelectedItem, required: true);
            }

            private void btnAddCase_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("case", "Корпус");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("case", txtCase, lblCaseReq, form.SelectedItem, required: true);
            }

            // ================= ОПЦИОНАЛЬНЫЕ =================

            private void btnAddSound_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("sound", "Звуковая карта");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("sound", txtSound, null, form.SelectedItem, required: false);
            }

            private void btnAddExtra_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("extra", "Доп. детали");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("extra", txtExtra, null, form.SelectedItem, required: false);
            }

            private void btnAddPeripheral_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("peripheral", "Периферия");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("peripheral", txtPeripheral, null, form.SelectedItem, required: false);
            }

            private void btnAddSoftware_Click(object sender, EventArgs e)
            {
                var form = new SelectComponentForm("software", "ПО");
                if (form.ShowDialog() == DialogResult.OK)
                    AddItem("software", txtSoftware, null, form.SelectedItem, required: false);
            }

            // ================= ОБЩАЯ ЛОГИКА =================

            private void AddItem(string key, TextBox txt, Label reqLabel, ComponentItem item, bool required)
            {
                if (_added.Contains(key))
                {
                    MessageBox.Show("Эта позиция уже добавлена.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _added.Add(key);
                _selectedItems[key] = item;
                _totalItems++;
                _totalSum += item.Price;

                if (required)
                {
                    _requiredDone++;
                    if (reqLabel != null)
                    {
                        reqLabel.Text = "✓ Добавлено";
                        reqLabel.ForeColor = System.Drawing.Color.LightGreen;
                    }
                }

                txt.Text = item.Name;
                txt.Enabled = false;

                UpdateProgress();
                UpdateSummary();
            }

            private void UpdateProgress()
            {
                progressBar1.Maximum = RequiredTotal;
                progressBar1.Value = Math.Min(_requiredDone, RequiredTotal);
                lblProgress.Text = $"{_requiredDone}/{RequiredTotal}";
            }

            private void UpdateSummary()
            {
                lblCountValue.Text = _totalItems.ToString();
                lblSumValue.Text = _totalSum.ToString("N0") + " ₽";
            }

            // ================= КНОПКИ СПРАВА =================

            private void btnSendToBuilder_Click(object sender, EventArgs e)
            {
                if (_requiredDone < RequiredTotal)
                {
                    MessageBox.Show(
                        $"Не все обязательные комплектующие выбраны ({_requiredDone}/{RequiredTotal}).",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var order = OrderRepository.CreateNew();
                order.TotalItems = _totalItems;
                order.TotalSum = _totalSum;

                // Копируем ВСЕ выбранные комплектующие
                foreach (var kvp in _selectedItems)
                    order.Items[kvp.Key] = kvp.Value;

                var lastClient = ClientRepository.Clients.Count > 0
                    ? ClientRepository.Clients[ClientRepository.Clients.Count - 1]
                    : null;

                order.ClientName = lastClient?.Name ?? "—";
                order.ClientPhone = lastClient?.Phone ?? "—";

                OrderRepository.Add(order);

                MessageBox.Show($"Заказ №{order.Id} отправлен сборщику!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm.Instance?.ShowOrdersTab();

                ClearBuild();
            }

            private void btnSaveBuild_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Сборка сохранена.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Очистить всю сборку?", "Подтверждение",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                ClearBuild();
            }

            private void ClearBuild()
            {
                foreach (Control c in grpRequired.Controls)
                {
                    if (c is TextBox tb)
                    {
                        tb.Clear();
                        tb.Enabled = true;
                    }
                }

                ResetReqLabel(lblCpuReq);
                ResetReqLabel(lblMotherboardReq);
                ResetReqLabel(lblPsuReq);
                ResetReqLabel(lblGpuReq);
                ResetReqLabel(lblCoolingReq);
                ResetReqLabel(lblRamReq);
                ResetReqLabel(lblStorageReq);
                ResetReqLabel(lblCaseReq);

                _added.Clear();
                _selectedItems.Clear();
                _requiredDone = 0;
                _totalItems = 0;
                _totalSum = 0;
                _selectedCpu = null;
                _selectedMotherboard = null;

                UpdateProgress();
                UpdateSummary();
            }

            private void ResetReqLabel(Label lbl)
            {
                if (lbl == null) return;
                lbl.Text = "Обязательно";
                lbl.ForeColor = System.Drawing.Color.LightGray;
            }
        }
    }