namespace MyProject23123
{
        partial class SelectComponentForm
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.ListBox lstItems;
            private System.Windows.Forms.Button btnOk;
            private System.Windows.Forms.Button btnCancel;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                    components.Dispose();
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.lblTitle = new System.Windows.Forms.Label();
                this.lstItems = new System.Windows.Forms.ListBox();
                this.btnOk = new System.Windows.Forms.Button();
                this.btnCancel = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // lblTitle
                // 
                this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
                this.lblTitle.ForeColor = System.Drawing.Color.White;
                this.lblTitle.Location = new System.Drawing.Point(20, 15);
                this.lblTitle.Name = "lblTitle";
                this.lblTitle.Size = new System.Drawing.Size(500, 30);
                this.lblTitle.TabIndex = 0;
                this.lblTitle.Text = "Выберите комплектующее";
                // 
                // lstItems
                // 
                this.lstItems.BackColor = System.Drawing.Color.Black;
                this.lstItems.Font = new System.Drawing.Font("Segoe UI", 12F);
                this.lstItems.ForeColor = System.Drawing.Color.White;
                this.lstItems.FormattingEnabled = true;
                this.lstItems.ItemHeight = 21;
                this.lstItems.Location = new System.Drawing.Point(20, 60);
                this.lstItems.Name = "lstItems";
                this.lstItems.Size = new System.Drawing.Size(500, 235);
                this.lstItems.TabIndex = 1;
                // 
                // btnOk
                // 
                this.btnOk.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
                this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnOk.Font = new System.Drawing.Font("Segoe UI", 11F);
                this.btnOk.ForeColor = System.Drawing.Color.White;
                this.btnOk.Location = new System.Drawing.Point(20, 310);
                this.btnOk.Name = "btnOk";
                this.btnOk.Size = new System.Drawing.Size(240, 40);
                this.btnOk.TabIndex = 2;
                this.btnOk.Text = "Добавить";
                this.btnOk.UseVisualStyleBackColor = false;
                this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
                // 
                // btnCancel
                // 
                this.btnCancel.BackColor = System.Drawing.Color.White;
                this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
                this.btnCancel.Location = new System.Drawing.Point(280, 310);
                this.btnCancel.Name = "btnCancel";
                this.btnCancel.Size = new System.Drawing.Size(240, 40);
                this.btnCancel.TabIndex = 3;
                this.btnCancel.Text = "Отмена";
                this.btnCancel.UseVisualStyleBackColor = false;
                this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
                // 
                // SelectComponentForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.ClientSize = new System.Drawing.Size(540, 370);
                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnOk);
                this.Controls.Add(this.lstItems);
                this.Controls.Add(this.lblTitle);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "SelectComponentForm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "Выбор комплектующего";
                this.ResumeLayout(false);
            }
        }
    }