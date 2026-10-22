namespace MyProject23123
{
    partial class ClientDataControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpClient;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.Label lblDeliveryType;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.CheckBox chkPickup;

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblEntrance;
        private System.Windows.Forms.TextBox txtEntrance;
        private System.Windows.Forms.Label lblFlat;
        private System.Windows.Forms.TextBox txtFlat;

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnSend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDeliveryType = new System.Windows.Forms.Label();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.chkPickup = new System.Windows.Forms.CheckBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblEntrance = new System.Windows.Forms.Label();
            this.txtEntrance = new System.Windows.Forms.TextBox();
            this.lblFlat = new System.Windows.Forms.Label();
            this.txtFlat = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1100, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Редактирование данных клиента";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.lblName);
            this.grpClient.Controls.Add(this.txtName);
            this.grpClient.Controls.Add(this.lblEmail);
            this.grpClient.Controls.Add(this.txtEmail);
            this.grpClient.Controls.Add(this.lblPhone);
            this.grpClient.Controls.Add(this.txtPhone);
            this.grpClient.Controls.Add(this.lblDeliveryType);
            this.grpClient.Controls.Add(this.chkDelivery);
            this.grpClient.Controls.Add(this.chkPickup);
            this.grpClient.Controls.Add(this.lblAddress);
            this.grpClient.Controls.Add(this.lblCity);
            this.grpClient.Controls.Add(this.txtCity);
            this.grpClient.Controls.Add(this.lblStreet);
            this.grpClient.Controls.Add(this.txtStreet);
            this.grpClient.Controls.Add(this.lblEntrance);
            this.grpClient.Controls.Add(this.txtEntrance);
            this.grpClient.Controls.Add(this.lblFlat);
            this.grpClient.Controls.Add(this.txtFlat);
            this.grpClient.ForeColor = System.Drawing.Color.White;
            this.grpClient.Location = new System.Drawing.Point(180, 70);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(780, 400);
            this.grpClient.TabIndex = 1;
            this.grpClient.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(40, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя клиента:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(210, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(40, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Эл. почта:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(210, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(40, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 25);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Моб. телефон:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Black;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(210, 128);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 27);
            this.txtPhone.TabIndex = 5;
            // 
            // lblDeliveryType
            // 
            this.lblDeliveryType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDeliveryType.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryType.Location = new System.Drawing.Point(40, 175);
            this.lblDeliveryType.Name = "lblDeliveryType";
            this.lblDeliveryType.Size = new System.Drawing.Size(220, 25);
            this.lblDeliveryType.TabIndex = 6;
            this.lblDeliveryType.Text = "Доставка/самовывоз:";
            // 
            // chkDelivery
            // 
            this.chkDelivery.ForeColor = System.Drawing.Color.White;
            this.chkDelivery.Location = new System.Drawing.Point(270, 175);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(110, 25);
            this.chkDelivery.TabIndex = 7;
            this.chkDelivery.Text = "Доставка";
            this.chkDelivery.CheckedChanged += new System.EventHandler(this.chkDelivery_CheckedChanged);
            // 
            // chkPickup
            // 
            this.chkPickup.ForeColor = System.Drawing.Color.White;
            this.chkPickup.Location = new System.Drawing.Point(390, 175);
            this.chkPickup.Name = "chkPickup";
            this.chkPickup.Size = new System.Drawing.Size(130, 25);
            this.chkPickup.TabIndex = 8;
            this.chkPickup.Text = "Самовывоз";
            this.chkPickup.CheckedChanged += new System.EventHandler(this.chkPickup_CheckedChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(40, 220);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(220, 25);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Адрес (доставки):";
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(60, 255);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(70, 25);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "Город:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.Black;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(140, 253);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 25);
            this.txtCity.TabIndex = 11;
            // 
            // lblStreet
            // 
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStreet.ForeColor = System.Drawing.Color.White;
            this.lblStreet.Location = new System.Drawing.Point(60, 290);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(70, 25);
            this.lblStreet.TabIndex = 12;
            this.lblStreet.Text = "Улица:";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.Black;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStreet.ForeColor = System.Drawing.Color.White;
            this.txtStreet.Location = new System.Drawing.Point(140, 288);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(300, 25);
            this.txtStreet.TabIndex = 13;
            // 
            // lblEntrance
            // 
            this.lblEntrance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEntrance.ForeColor = System.Drawing.Color.White;
            this.lblEntrance.Location = new System.Drawing.Point(60, 325);
            this.lblEntrance.Name = "lblEntrance";
            this.lblEntrance.Size = new System.Drawing.Size(70, 25);
            this.lblEntrance.TabIndex = 14;
            this.lblEntrance.Text = "Подъезд:";
            // 
            // txtEntrance
            // 
            this.txtEntrance.BackColor = System.Drawing.Color.Black;
            this.txtEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntrance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEntrance.ForeColor = System.Drawing.Color.White;
            this.txtEntrance.Location = new System.Drawing.Point(140, 323);
            this.txtEntrance.Name = "txtEntrance";
            this.txtEntrance.Size = new System.Drawing.Size(300, 25);
            this.txtEntrance.TabIndex = 15;
            // 
            // lblFlat
            // 
            this.lblFlat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFlat.ForeColor = System.Drawing.Color.White;
            this.lblFlat.Location = new System.Drawing.Point(60, 360);
            this.lblFlat.Name = "lblFlat";
            this.lblFlat.Size = new System.Drawing.Size(70, 25);
            this.lblFlat.TabIndex = 16;
            this.lblFlat.Text = "Квартира:";
            // 
            // txtFlat
            // 
            this.txtFlat.BackColor = System.Drawing.Color.Black;
            this.txtFlat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFlat.ForeColor = System.Drawing.Color.White;
            this.txtFlat.Location = new System.Drawing.Point(140, 358);
            this.txtFlat.Name = "txtFlat";
            this.txtFlat.Size = new System.Drawing.Size(300, 25);
            this.txtFlat.TabIndex = 17;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(180, 490);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(380, 45);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(580, 490);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(380, 45);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ClientDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.lblHeader);
            this.Name = "ClientDataControl";
            this.Size = new System.Drawing.Size(1184, 628);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}