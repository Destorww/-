namespace MyProject23123
{
    partial class OrdersControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblTotalItemsTitle;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalSumTitle;
        private System.Windows.Forms.Label lblTotalSumValue;
        private System.Windows.Forms.Label lblCompositionTitle;
        private System.Windows.Forms.ListBox lstComposition;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalItemsTitle = new System.Windows.Forms.Label();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalSumTitle = new System.Windows.Forms.Label();
            this.lblTotalSumValue = new System.Windows.Forms.Label();
            this.lblCompositionTitle = new System.Windows.Forms.Label();
            this.lstComposition = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1140, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Принятые заказы";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 70);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(700, 480);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblTotalItemsTitle);
            this.grpDetails.Controls.Add(this.lblTotalItemsValue);
            this.grpDetails.Controls.Add(this.lblTotalSumTitle);
            this.grpDetails.Controls.Add(this.lblTotalSumValue);
            this.grpDetails.Controls.Add(this.lblCompositionTitle);
            this.grpDetails.Controls.Add(this.lstComposition);
            this.grpDetails.ForeColor = System.Drawing.Color.White;
            this.grpDetails.Location = new System.Drawing.Point(740, 70);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(420, 480);
            this.grpDetails.TabIndex = 2;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Детали заказа";
            // 
            // lblTotalItemsTitle
            // 
            this.lblTotalItemsTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalItemsTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalItemsTitle.Location = new System.Drawing.Point(20, 30);
            this.lblTotalItemsTitle.Name = "lblTotalItemsTitle";
            this.lblTotalItemsTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTotalItemsTitle.TabIndex = 0;
            this.lblTotalItemsTitle.Text = "Количество товаров:";
            // 
            // lblTotalItemsValue
            // 
            this.lblTotalItemsValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalItemsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalItemsValue.Location = new System.Drawing.Point(220, 30);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Size = new System.Drawing.Size(180, 25);
            this.lblTotalItemsValue.TabIndex = 1;
            this.lblTotalItemsValue.Text = "0";
            this.lblTotalItemsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalSumTitle
            // 
            this.lblTotalSumTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalSumTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalSumTitle.Location = new System.Drawing.Point(20, 65);
            this.lblTotalSumTitle.Name = "lblTotalSumTitle";
            this.lblTotalSumTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTotalSumTitle.TabIndex = 2;
            this.lblTotalSumTitle.Text = "Итоговая сумма:";
            // 
            // lblTotalSumValue
            // 
            this.lblTotalSumValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalSumValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalSumValue.Location = new System.Drawing.Point(220, 65);
            this.lblTotalSumValue.Name = "lblTotalSumValue";
            this.lblTotalSumValue.Size = new System.Drawing.Size(180, 25);
            this.lblTotalSumValue.TabIndex = 3;
            this.lblTotalSumValue.Text = "0 ₽";
            this.lblTotalSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompositionTitle
            // 
            this.lblCompositionTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCompositionTitle.ForeColor = System.Drawing.Color.White;
            this.lblCompositionTitle.Location = new System.Drawing.Point(20, 110);
            this.lblCompositionTitle.Name = "lblCompositionTitle";
            this.lblCompositionTitle.Size = new System.Drawing.Size(380, 25);
            this.lblCompositionTitle.TabIndex = 4;
            this.lblCompositionTitle.Text = "Состав заказа:";
            // 
            // lstComposition
            // 
            this.lstComposition.BackColor = System.Drawing.Color.Black;
            this.lstComposition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstComposition.ForeColor = System.Drawing.Color.White;
            this.lstComposition.FormattingEnabled = true;
            this.lstComposition.ItemHeight = 17;
            this.lstComposition.Location = new System.Drawing.Point(20, 140);
            this.lstComposition.Name = "lstComposition";
            this.lstComposition.Size = new System.Drawing.Size(380, 310);
            this.lstComposition.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRefresh.Location = new System.Drawing.Point(20, 565);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(240, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить выбранный";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lblHeader);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(1184, 628);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}