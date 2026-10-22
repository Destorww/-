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
using System.Xml.Linq;

namespace MyProject23123 {
        public partial class ClientDataControl : UserControl
        {
            public ClientDataControl()
            {
                InitializeComponent();
            }

            private void chkDelivery_CheckedChanged(object sender, EventArgs e)
            {
                bool delivery = chkDelivery.Checked;
                txtCity.Enabled = delivery;
                txtStreet.Enabled = delivery;
                txtEntrance.Enabled = delivery;
                txtFlat.Enabled = delivery;
            }

            private void chkPickup_CheckedChanged(object sender, EventArgs e)
            {
                if (chkPickup.Checked && chkDelivery.Checked)
                    chkDelivery.Checked = false;
            }

            private void btnSaveChanges_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Введите имя клиента.", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Данные клиента сохранены (черновик).", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void btnSend_Click(object sender, EventArgs e)
            {
                // --- Валидация ---
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Введите имя клиента.", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Введите мобильный телефон.", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                if (!chkDelivery.Checked && !chkPickup.Checked)
                {
                    MessageBox.Show("Выберите способ получения: доставка или самовывоз.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- Формируем объект ---
                var client = new Client
                {
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    DeliveryType = chkDelivery.Checked ? "Доставка" : "Самовывоз",
                    City = txtCity.Text.Trim(),
                    Street = txtStreet.Text.Trim(),
                    Entrance = txtEntrance.Text.Trim(),
                    Flat = txtFlat.Text.Trim()
                };

                // --- Кладём в "базу" ---
                ClientRepository.Add(client);

                MessageBox.Show("Данные отправлены в базу клиентов.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- Переключаемся на вкладку "База данных клиентов" ---
                MainForm.Instance?.ShowClientsTab();

                // --- Очищаем поля ---
                ClearFields();
            }

            private void ClearFields()
            {
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtCity.Clear();
                txtStreet.Clear();
                txtEntrance.Clear();
                txtFlat.Clear();

                chkDelivery.Checked = false;
                chkPickup.Checked = false;
            }
        }
    }