namespace MyProject23123
{
        partial class MainForm
        {
            private System.ComponentModel.IContainer components = null;

            private System.Windows.Forms.TabControl tabControl1;
            private System.Windows.Forms.TabPage tabClient;
            private System.Windows.Forms.TabPage tabBuild;
            private System.Windows.Forms.TabPage tabClients;
            private System.Windows.Forms.TabPage tabOrders;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                    components.Dispose();
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.tabControl1 = new System.Windows.Forms.TabControl();
                this.tabClient = new System.Windows.Forms.TabPage();
                this.tabBuild = new System.Windows.Forms.TabPage();
                this.tabClients = new System.Windows.Forms.TabPage();
                this.tabOrders = new System.Windows.Forms.TabPage();
                this.tabControl1.SuspendLayout();
                this.SuspendLayout();
                // 
                // tabControl1
                // 
                this.tabControl1.Controls.Add(this.tabClient);
                this.tabControl1.Controls.Add(this.tabBuild);
                this.tabControl1.Controls.Add(this.tabClients);
                this.tabControl1.Controls.Add(this.tabOrders);
                this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
                this.tabControl1.Location = new System.Drawing.Point(0, 0);
                this.tabControl1.Name = "tabControl1";
                this.tabControl1.SelectedIndex = 0;
                this.tabControl1.Size = new System.Drawing.Size(1184, 661);
                this.tabControl1.TabIndex = 0;
                // 
                // tabClient
                // 
                this.tabClient.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.tabClient.Location = new System.Drawing.Point(4, 29);
                this.tabClient.Name = "tabClient";
                this.tabClient.Padding = new System.Windows.Forms.Padding(3);
                this.tabClient.Size = new System.Drawing.Size(1176, 628);
                this.tabClient.TabIndex = 0;
                this.tabClient.Text = "Данные клиента";
                // 
                // tabBuild
                // 
                this.tabBuild.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.tabBuild.Location = new System.Drawing.Point(4, 29);
                this.tabBuild.Name = "tabBuild";
                this.tabBuild.Padding = new System.Windows.Forms.Padding(3);
                this.tabBuild.Size = new System.Drawing.Size(1176, 628);
                this.tabBuild.TabIndex = 1;
                this.tabBuild.Text = "Конфигуратор ПК";
                // 
                // tabClients
                // 
                this.tabClients.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.tabClients.Location = new System.Drawing.Point(4, 29);
                this.tabClients.Name = "tabClients";
                this.tabClients.Padding = new System.Windows.Forms.Padding(3);
                this.tabClients.Size = new System.Drawing.Size(1176, 628);
                this.tabClients.TabIndex = 2;
                this.tabClients.Text = "База данных клиентов";
                // 
                // tabOrders
                // 
                this.tabOrders.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.tabOrders.Location = new System.Drawing.Point(4, 29);
                this.tabOrders.Name = "tabOrders";
                this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
                this.tabOrders.Size = new System.Drawing.Size(1176, 628);
                this.tabOrders.TabIndex = 3;
                this.tabOrders.Text = "Принятые заказы";
                // 
                // MainForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.ClientSize = new System.Drawing.Size(1184, 661);
                this.Controls.Add(this.tabControl1);
                this.Name = "MainForm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Главная";
                this.Load += new System.EventHandler(this.MainForm_Load);
                this.tabControl1.ResumeLayout(false);
                this.ResumeLayout(false);
            }
        }
    }