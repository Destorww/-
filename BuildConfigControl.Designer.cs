namespace MyProject23123
{
    partial class BuildConfigControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpRequired;
        private System.Windows.Forms.Label lblRequiredTitle;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar1;

        // Обязательные
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.Label lblCpuReq;
        private System.Windows.Forms.Button btnAddCpu;

        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.TextBox txtMotherboard;
        private System.Windows.Forms.Label lblMotherboardReq;
        private System.Windows.Forms.Button btnAddMotherboard;

        private System.Windows.Forms.Label lblPsu;
        private System.Windows.Forms.TextBox txtPsu;
        private System.Windows.Forms.Label lblPsuReq;
        private System.Windows.Forms.Button btnAddPsu;

        private System.Windows.Forms.Label lblGpu;
        private System.Windows.Forms.TextBox txtGpu;
        private System.Windows.Forms.Label lblGpuReq;
        private System.Windows.Forms.Button btnAddGpu;

        private System.Windows.Forms.Label lblCooling;
        private System.Windows.Forms.TextBox txtCooling;
        private System.Windows.Forms.Label lblCoolingReq;
        private System.Windows.Forms.Button btnAddCooling;

        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label lblRamReq;
        private System.Windows.Forms.Button btnAddRam;

        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Label lblStorageReq;
        private System.Windows.Forms.Button btnAddStorage;

        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.TextBox txtCase;
        private System.Windows.Forms.Label lblCaseReq;
        private System.Windows.Forms.Button btnAddCase;

        // Опциональные
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.Button btnAddSound;

        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button btnAddExtra;

        private System.Windows.Forms.Label lblPeripheral;
        private System.Windows.Forms.TextBox txtPeripheral;
        private System.Windows.Forms.Button btnAddPeripheral;

        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.TextBox txtSoftware;
        private System.Windows.Forms.Button btnAddSoftware;

        // Панель справа
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblCountTitle;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Label lblSumTitle;
        private System.Windows.Forms.Label lblSumValue;
        private System.Windows.Forms.Button btnSendToBuilder;
        private System.Windows.Forms.Button btnSaveBuild;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpRequired = new System.Windows.Forms.GroupBox();
            this.lblRequiredTitle = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();

            this.lblCpu = new System.Windows.Forms.Label();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.lblCpuReq = new System.Windows.Forms.Label();
            this.btnAddCpu = new System.Windows.Forms.Button();

            this.lblMotherboard = new System.Windows.Forms.Label();
            this.txtMotherboard = new System.Windows.Forms.TextBox();
            this.lblMotherboardReq = new System.Windows.Forms.Label();
            this.btnAddMotherboard = new System.Windows.Forms.Button();

            this.lblPsu = new System.Windows.Forms.Label();
            this.txtPsu = new System.Windows.Forms.TextBox();
            this.lblPsuReq = new System.Windows.Forms.Label();
            this.btnAddPsu = new System.Windows.Forms.Button();

            this.lblGpu = new System.Windows.Forms.Label();
            this.txtGpu = new System.Windows.Forms.TextBox();
            this.lblGpuReq = new System.Windows.Forms.Label();
            this.btnAddGpu = new System.Windows.Forms.Button();

            this.lblCooling = new System.Windows.Forms.Label();
            this.txtCooling = new System.Windows.Forms.TextBox();
            this.lblCoolingReq = new System.Windows.Forms.Label();
            this.btnAddCooling = new System.Windows.Forms.Button();

            this.lblRam = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.lblRamReq = new System.Windows.Forms.Label();
            this.btnAddRam = new System.Windows.Forms.Button();

            this.lblStorage = new System.Windows.Forms.Label();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.lblStorageReq = new System.Windows.Forms.Label();
            this.btnAddStorage = new System.Windows.Forms.Button();

            this.lblCase = new System.Windows.Forms.Label();
            this.txtCase = new System.Windows.Forms.TextBox();
            this.lblCaseReq = new System.Windows.Forms.Label();
            this.btnAddCase = new System.Windows.Forms.Button();

            this.lblSound = new System.Windows.Forms.Label();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.btnAddSound = new System.Windows.Forms.Button();

            this.lblExtra = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.btnAddExtra = new System.Windows.Forms.Button();

            this.lblPeripheral = new System.Windows.Forms.Label();
            this.txtPeripheral = new System.Windows.Forms.TextBox();
            this.btnAddPeripheral = new System.Windows.Forms.Button();

            this.lblSoftware = new System.Windows.Forms.Label();
            this.txtSoftware = new System.Windows.Forms.TextBox();
            this.btnAddSoftware = new System.Windows.Forms.Button();

            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblCountTitle = new System.Windows.Forms.Label();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.lblSumTitle = new System.Windows.Forms.Label();
            this.lblSumValue = new System.Windows.Forms.Label();
            this.btnSendToBuilder = new System.Windows.Forms.Button();
            this.btnSaveBuild = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.grpRequired.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();

            int rowH = 55;
            int startY = 70;
            int labelX = 20;
            int textX = 200;
            int reqX = 410;
            int btnX = 540;
            int textW = 200;
            int btnW = 90;
            int rowW = 640;

            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(700, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Конфигуратор ПК";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRequired
            // 
            this.grpRequired.Controls.Add(this.lblRequiredTitle);
            this.grpRequired.Controls.Add(this.lblProgress);
            this.grpRequired.Controls.Add(this.progressBar1);

            this.grpRequired.Controls.Add(this.lblCpu);
            this.grpRequired.Controls.Add(this.txtCpu);
            this.grpRequired.Controls.Add(this.lblCpuReq);
            this.grpRequired.Controls.Add(this.btnAddCpu);

            this.grpRequired.Controls.Add(this.lblMotherboard);
            this.grpRequired.Controls.Add(this.txtMotherboard);
            this.grpRequired.Controls.Add(this.lblMotherboardReq);
            this.grpRequired.Controls.Add(this.btnAddMotherboard);

            this.grpRequired.Controls.Add(this.lblPsu);
            this.grpRequired.Controls.Add(this.txtPsu);
            this.grpRequired.Controls.Add(this.lblPsuReq);
            this.grpRequired.Controls.Add(this.btnAddPsu);

            this.grpRequired.Controls.Add(this.lblGpu);
            this.grpRequired.Controls.Add(this.txtGpu);
            this.grpRequired.Controls.Add(this.lblGpuReq);
            this.grpRequired.Controls.Add(this.btnAddGpu);

            this.grpRequired.Controls.Add(this.lblCooling);
            this.grpRequired.Controls.Add(this.txtCooling);
            this.grpRequired.Controls.Add(this.lblCoolingReq);
            this.grpRequired.Controls.Add(this.btnAddCooling);

            this.grpRequired.Controls.Add(this.lblRam);
            this.grpRequired.Controls.Add(this.txtRam);
            this.grpRequired.Controls.Add(this.lblRamReq);
            this.grpRequired.Controls.Add(this.btnAddRam);

            this.grpRequired.Controls.Add(this.lblStorage);
            this.grpRequired.Controls.Add(this.txtStorage);
            this.grpRequired.Controls.Add(this.lblStorageReq);
            this.grpRequired.Controls.Add(this.btnAddStorage);

            this.grpRequired.Controls.Add(this.lblCase);
            this.grpRequired.Controls.Add(this.txtCase);
            this.grpRequired.Controls.Add(this.lblCaseReq);
            this.grpRequired.Controls.Add(this.btnAddCase);

            this.grpRequired.Controls.Add(this.lblSound);
            this.grpRequired.Controls.Add(this.txtSound);
            this.grpRequired.Controls.Add(this.btnAddSound);

            this.grpRequired.Controls.Add(this.lblExtra);
            this.grpRequired.Controls.Add(this.txtExtra);
            this.grpRequired.Controls.Add(this.btnAddExtra);

            this.grpRequired.Controls.Add(this.lblPeripheral);
            this.grpRequired.Controls.Add(this.txtPeripheral);
            this.grpRequired.Controls.Add(this.btnAddPeripheral);

            this.grpRequired.Controls.Add(this.lblSoftware);
            this.grpRequired.Controls.Add(this.txtSoftware);
            this.grpRequired.Controls.Add(this.btnAddSoftware);

            this.grpRequired.ForeColor = System.Drawing.Color.White;
            this.grpRequired.Location = new System.Drawing.Point(20, 60);
            this.grpRequired.Name = "grpRequired";
            this.grpRequired.Size = new System.Drawing.Size(680, 860);
            this.grpRequired.TabIndex = 1;
            this.grpRequired.TabStop = false;
            // 
            // lblRequiredTitle
            // 
            this.lblRequiredTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblRequiredTitle.ForeColor = System.Drawing.Color.White;
            this.lblRequiredTitle.Location = new System.Drawing.Point(20, 25);
            this.lblRequiredTitle.Name = "lblRequiredTitle";
            this.lblRequiredTitle.Size = new System.Drawing.Size(400, 30);
            this.lblRequiredTitle.TabIndex = 0;
            this.lblRequiredTitle.Text = "Обязательные комплектующие";
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(540, 25);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(120, 30);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0/8";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(640, 10);
            this.progressBar1.TabIndex = 2;

            // ====== Обязательные: шаблон строки ======
            // CPU
            this.lblCpu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCpu.ForeColor = System.Drawing.Color.White;
            this.lblCpu.Location = new System.Drawing.Point(labelX, startY);
            this.lblCpu.Size = new System.Drawing.Size(170, 25);
            this.lblCpu.Text = "Процессор:";
            this.txtCpu.BackColor = System.Drawing.Color.White;
            this.txtCpu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCpu.Location = new System.Drawing.Point(textX, startY - 2);
            this.txtCpu.Size = new System.Drawing.Size(textW, 25);
            this.lblCpuReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCpuReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblCpuReq.Location = new System.Drawing.Point(reqX, startY);
            this.lblCpuReq.Size = new System.Drawing.Size(120, 25);
            this.lblCpuReq.Text = "Обязательно";
            this.btnAddCpu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddCpu.Location = new System.Drawing.Point(btnX, startY - 3);
            this.btnAddCpu.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddCpu.Text = "Добавить";
            this.btnAddCpu.Click += new System.EventHandler(this.btnAddCpu_Click);

            // Motherboard
            this.lblMotherboard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMotherboard.ForeColor = System.Drawing.Color.White;
            this.lblMotherboard.Location = new System.Drawing.Point(labelX, startY + rowH * 1);
            this.lblMotherboard.Size = new System.Drawing.Size(170, 25);
            this.lblMotherboard.Text = "Мат. плата:";
            this.txtMotherboard.BackColor = System.Drawing.Color.White;
            this.txtMotherboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotherboard.Location = new System.Drawing.Point(textX, startY + rowH * 1 - 2);
            this.txtMotherboard.Size = new System.Drawing.Size(textW, 25);
            this.lblMotherboardReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblMotherboardReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblMotherboardReq.Location = new System.Drawing.Point(reqX, startY + rowH * 1);
            this.lblMotherboardReq.Size = new System.Drawing.Size(120, 25);
            this.lblMotherboardReq.Text = "Обязательно";
            this.btnAddMotherboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddMotherboard.Location = new System.Drawing.Point(btnX, startY + rowH * 1 - 3);
            this.btnAddMotherboard.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddMotherboard.Text = "Добавить";
            this.btnAddMotherboard.Click += new System.EventHandler(this.btnAddMotherboard_Click);

            // PSU
            this.lblPsu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPsu.ForeColor = System.Drawing.Color.White;
            this.lblPsu.Location = new System.Drawing.Point(labelX, startY + rowH * 2);
            this.lblPsu.Size = new System.Drawing.Size(170, 25);
            this.lblPsu.Text = "Блок питания:";
            this.txtPsu.BackColor = System.Drawing.Color.White;
            this.txtPsu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPsu.Location = new System.Drawing.Point(textX, startY + rowH * 2 - 2);
            this.txtPsu.Size = new System.Drawing.Size(textW, 25);
            this.lblPsuReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblPsuReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblPsuReq.Location = new System.Drawing.Point(reqX, startY + rowH * 2);
            this.lblPsuReq.Size = new System.Drawing.Size(120, 25);
            this.lblPsuReq.Text = "Обязательно";
            this.btnAddPsu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddPsu.Location = new System.Drawing.Point(btnX, startY + rowH * 2 - 3);
            this.btnAddPsu.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddPsu.Text = "Добавить";
            this.btnAddPsu.Click += new System.EventHandler(this.btnAddPsu_Click);

            // GPU
            this.lblGpu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblGpu.ForeColor = System.Drawing.Color.White;
            this.lblGpu.Location = new System.Drawing.Point(labelX, startY + rowH * 3);
            this.lblGpu.Size = new System.Drawing.Size(170, 25);
            this.lblGpu.Text = "Видеокарта:";
            this.txtGpu.BackColor = System.Drawing.Color.White;
            this.txtGpu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGpu.Location = new System.Drawing.Point(textX, startY + rowH * 3 - 2);
            this.txtGpu.Size = new System.Drawing.Size(textW, 25);
            this.lblGpuReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblGpuReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblGpuReq.Location = new System.Drawing.Point(reqX, startY + rowH * 3);
            this.lblGpuReq.Size = new System.Drawing.Size(120, 25);
            this.lblGpuReq.Text = "Обязательно";
            this.btnAddGpu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddGpu.Location = new System.Drawing.Point(btnX, startY + rowH * 3 - 3);
            this.btnAddGpu.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddGpu.Text = "Добавить";
            this.btnAddGpu.Click += new System.EventHandler(this.btnAddGpu_Click);

            // Cooling
            this.lblCooling.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCooling.ForeColor = System.Drawing.Color.White;
            this.lblCooling.Location = new System.Drawing.Point(labelX, startY + rowH * 4);
            this.lblCooling.Size = new System.Drawing.Size(170, 25);
            this.lblCooling.Text = "Охлаждение процессора:";
            this.txtCooling.BackColor = System.Drawing.Color.White;
            this.txtCooling.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCooling.Location = new System.Drawing.Point(textX, startY + rowH * 4 - 2);
            this.txtCooling.Size = new System.Drawing.Size(textW, 25);
            this.lblCoolingReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCoolingReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoolingReq.Location = new System.Drawing.Point(reqX, startY + rowH * 4);
            this.lblCoolingReq.Size = new System.Drawing.Size(120, 25);
            this.lblCoolingReq.Text = "Обязательно";
            this.btnAddCooling.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddCooling.Location = new System.Drawing.Point(btnX, startY + rowH * 4 - 3);
            this.btnAddCooling.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddCooling.Text = "Добавить";
            this.btnAddCooling.Click += new System.EventHandler(this.btnAddCooling_Click);

            // RAM
            this.lblRam.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRam.ForeColor = System.Drawing.Color.White;
            this.lblRam.Location = new System.Drawing.Point(labelX, startY + rowH * 5);
            this.lblRam.Size = new System.Drawing.Size(170, 25);
            this.lblRam.Text = "ОЗУ:";
            this.txtRam.BackColor = System.Drawing.Color.White;
            this.txtRam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRam.Location = new System.Drawing.Point(textX, startY + rowH * 5 - 2);
            this.txtRam.Size = new System.Drawing.Size(textW, 25);
            this.lblRamReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRamReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblRamReq.Location = new System.Drawing.Point(reqX, startY + rowH * 5);
            this.lblRamReq.Size = new System.Drawing.Size(120, 25);
            this.lblRamReq.Text = "Обязательно";
            this.btnAddRam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddRam.Location = new System.Drawing.Point(btnX, startY + rowH * 5 - 3);
            this.btnAddRam.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddRam.Text = "Добавить";
            this.btnAddRam.Click += new System.EventHandler(this.btnAddRam_Click);

            // Storage
            this.lblStorage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStorage.ForeColor = System.Drawing.Color.White;
            this.lblStorage.Location = new System.Drawing.Point(labelX, startY + rowH * 6);
            this.lblStorage.Size = new System.Drawing.Size(170, 25);
            this.lblStorage.Text = "Накопители:";
            this.txtStorage.BackColor = System.Drawing.Color.White;
            this.txtStorage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStorage.Location = new System.Drawing.Point(textX, startY + rowH * 6 - 2);
            this.txtStorage.Size = new System.Drawing.Size(textW, 25);
            this.lblStorageReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStorageReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblStorageReq.Location = new System.Drawing.Point(reqX, startY + rowH * 6);
            this.lblStorageReq.Size = new System.Drawing.Size(120, 25);
            this.lblStorageReq.Text = "Обязательно";
            this.btnAddStorage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddStorage.Location = new System.Drawing.Point(btnX, startY + rowH * 6 - 3);
            this.btnAddStorage.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddStorage.Text = "Добавить";
            this.btnAddStorage.Click += new System.EventHandler(this.btnAddStorage_Click);

            // Case
            this.lblCase.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCase.ForeColor = System.Drawing.Color.White;
            this.lblCase.Location = new System.Drawing.Point(labelX, startY + rowH * 7);
            this.lblCase.Size = new System.Drawing.Size(170, 25);
            this.lblCase.Text = "Корпус:";
            this.txtCase.BackColor = System.Drawing.Color.White;
            this.txtCase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCase.Location = new System.Drawing.Point(textX, startY + rowH * 7 - 2);
            this.txtCase.Size = new System.Drawing.Size(textW, 25);
            this.lblCaseReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCaseReq.ForeColor = System.Drawing.Color.LightGray;
            this.lblCaseReq.Location = new System.Drawing.Point(reqX, startY + rowH * 7);
            this.lblCaseReq.Size = new System.Drawing.Size(120, 25);
            this.lblCaseReq.Text = "Обязательно";
            this.btnAddCase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddCase.Location = new System.Drawing.Point(btnX, startY + rowH * 7 - 3);
            this.btnAddCase.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddCase.Text = "Добавить";
            this.btnAddCase.Click += new System.EventHandler(this.btnAddCase_Click);

            // Sound
            this.lblSound.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSound.ForeColor = System.Drawing.Color.White;
            this.lblSound.Location = new System.Drawing.Point(labelX, startY + rowH * 8);
            this.lblSound.Size = new System.Drawing.Size(170, 25);
            this.lblSound.Text = "Звуковая карта:";
            this.txtSound.BackColor = System.Drawing.Color.White;
            this.txtSound.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSound.Location = new System.Drawing.Point(textX, startY + rowH * 8 - 2);
            this.txtSound.Size = new System.Drawing.Size(textW, 25);
            this.btnAddSound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddSound.Location = new System.Drawing.Point(btnX, startY + rowH * 8 - 3);
            this.btnAddSound.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddSound.Text = "Добавить";
            this.btnAddSound.Click += new System.EventHandler(this.btnAddSound_Click);

            // Extra
            this.lblExtra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblExtra.ForeColor = System.Drawing.Color.White;
            this.lblExtra.Location = new System.Drawing.Point(labelX, startY + rowH * 9);
            this.lblExtra.Size = new System.Drawing.Size(170, 25);
            this.lblExtra.Text = "Доп. детали:";
            this.txtExtra.BackColor = System.Drawing.Color.White;
            this.txtExtra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExtra.Location = new System.Drawing.Point(textX, startY + rowH * 9 - 2);
            this.txtExtra.Size = new System.Drawing.Size(textW, 25);
            this.btnAddExtra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddExtra.Location = new System.Drawing.Point(btnX, startY + rowH * 9 - 3);
            this.btnAddExtra.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddExtra.Text = "Добавить";
            this.btnAddExtra.Click += new System.EventHandler(this.btnAddExtra_Click);

            // Peripheral
            this.lblPeripheral.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPeripheral.ForeColor = System.Drawing.Color.White;
            this.lblPeripheral.Location = new System.Drawing.Point(labelX, startY + rowH * 10);
            this.lblPeripheral.Size = new System.Drawing.Size(170, 25);
            this.lblPeripheral.Text = "Периферия:";
            this.txtPeripheral.BackColor = System.Drawing.Color.White;
            this.txtPeripheral.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPeripheral.Location = new System.Drawing.Point(textX, startY + rowH * 10 - 2);
            this.txtPeripheral.Size = new System.Drawing.Size(textW, 25);
            this.btnAddPeripheral.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddPeripheral.Location = new System.Drawing.Point(btnX, startY + rowH * 10 - 3);
            this.btnAddPeripheral.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddPeripheral.Text = "Добавить";
            this.btnAddPeripheral.Click += new System.EventHandler(this.btnAddPeripheral_Click);

            // Software
            this.lblSoftware.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSoftware.ForeColor = System.Drawing.Color.White;
            this.lblSoftware.Location = new System.Drawing.Point(labelX, startY + rowH * 11);
            this.lblSoftware.Size = new System.Drawing.Size(170, 25);
            this.lblSoftware.Text = "ПО:";
            this.txtSoftware.BackColor = System.Drawing.Color.White;
            this.txtSoftware.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoftware.Location = new System.Drawing.Point(textX, startY + rowH * 11 - 2);
            this.txtSoftware.Size = new System.Drawing.Size(textW, 25);
            this.btnAddSoftware.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddSoftware.Location = new System.Drawing.Point(btnX, startY + rowH * 11 - 3);
            this.btnAddSoftware.Size = new System.Drawing.Size(btnW, 27);
            this.btnAddSoftware.Text = "Добавить";
            this.btnAddSoftware.Click += new System.EventHandler(this.btnAddSoftware_Click);

            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblCountTitle);
            this.grpSummary.Controls.Add(this.lblCountValue);
            this.grpSummary.Controls.Add(this.lblSumTitle);
            this.grpSummary.Controls.Add(this.lblSumValue);
            this.grpSummary.Controls.Add(this.btnSendToBuilder);
            this.grpSummary.Controls.Add(this.btnSaveBuild);
            this.grpSummary.Controls.Add(this.btnClear);
            this.grpSummary.ForeColor = System.Drawing.Color.White;
            this.grpSummary.Location = new System.Drawing.Point(720, 60);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(440, 260);
            this.grpSummary.TabIndex = 2;
            this.grpSummary.TabStop = false;

            // lblCountTitle
            this.lblCountTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCountTitle.ForeColor = System.Drawing.Color.White;
            this.lblCountTitle.Location = new System.Drawing.Point(20, 25);
            this.lblCountTitle.Size = new System.Drawing.Size(200, 25);
            this.lblCountTitle.Text = "(Сколько товаров)";
            // lblCountValue
            this.lblCountValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCountValue.ForeColor = System.Drawing.Color.White;
            this.lblCountValue.Location = new System.Drawing.Point(220, 22);
            this.lblCountValue.Size = new System.Drawing.Size(200, 30);
            this.lblCountValue.Text = "0";
            this.lblCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblSumTitle
            this.lblSumTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSumTitle.ForeColor = System.Drawing.Color.White;
            this.lblSumTitle.Location = new System.Drawing.Point(20, 60);
            this.lblSumTitle.Size = new System.Drawing.Size(200, 25);
            this.lblSumTitle.Text = "(Итоговая сумма)";
            // lblSumValue
            this.lblSumValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSumValue.ForeColor = System.Drawing.Color.White;
            this.lblSumValue.Location = new System.Drawing.Point(220, 57);
            this.lblSumValue.Size = new System.Drawing.Size(200, 30);
            this.lblSumValue.Text = "0 ₽";
            this.lblSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblNote
            this.lblSumTitle.Name = "lblSumTitle";

            // btnSendToBuilder
            this.btnSendToBuilder.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnSendToBuilder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSendToBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToBuilder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSendToBuilder.ForeColor = System.Drawing.Color.White;
            this.btnSendToBuilder.Location = new System.Drawing.Point(20, 105);
            this.btnSendToBuilder.Size = new System.Drawing.Size(400, 45);
            this.btnSendToBuilder.Text = "Отправить заказ сборщику";
            this.btnSendToBuilder.UseVisualStyleBackColor = false;
            this.btnSendToBuilder.Click += new System.EventHandler(this.btnSendToBuilder_Click);

            // btnSaveBuild
            this.btnSaveBuild.BackColor = System.Drawing.Color.White;
            this.btnSaveBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBuild.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSaveBuild.ForeColor = System.Drawing.Color.Black;
            this.btnSaveBuild.Location = new System.Drawing.Point(20, 165);
            this.btnSaveBuild.Size = new System.Drawing.Size(190, 40);
            this.btnSaveBuild.Text = "Сохранить";
            this.btnSaveBuild.UseVisualStyleBackColor = false;
            this.btnSaveBuild.Click += new System.EventHandler(this.btnSaveBuild_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(230, 165);
            this.btnClear.Size = new System.Drawing.Size(190, 40);
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // BuildConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpRequired);
            this.Controls.Add(this.lblHeader);
            this.Name = "BuildConfigControl";
            this.Size = new System.Drawing.Size(1184, 628);
            this.Load += new System.EventHandler(this.BuildConfigControl_Load);

            this.grpRequired.ResumeLayout(false);
            this.grpRequired.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}