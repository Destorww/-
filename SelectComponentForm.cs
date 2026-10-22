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
    public partial class SelectComponentForm : Form
    {
        public ComponentItem SelectedItem { get; private set; }

        public SelectComponentForm(string categoryKey, string categoryTitle)
        {
            InitializeComponent();
            lblTitle.Text = "Выберите: " + categoryTitle;

            if (ComponentCatalog.Items.ContainsKey(categoryKey))
            {
                lstItems.Items.Clear();
                foreach (var item in ComponentCatalog.Items[categoryKey])
                {
                    lstItems.Items.Add(item);
                }
                if (lstItems.Items.Count > 0)
                    lstItems.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem is ComponentItem item)
            {
                SelectedItem = item;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите комплектующее из списка.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
