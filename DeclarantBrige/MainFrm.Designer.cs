namespace DeclarantBrige {
    partial class MainFrm {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btnLoadContragents = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadDeclaration = new System.Windows.Forms.Button();
            this.cmbDeclarations = new System.Windows.Forms.ComboBox();
            this.cbClearDeclaration = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOrganizations = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.обToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckDeclaration = new System.Windows.Forms.Button();
            this.btnCheckOrganization = new System.Windows.Forms.Button();
            this.btnRefreshDeclaration = new System.Windows.Forms.Button();
            this.btnRefreshOrganization = new System.Windows.Forms.Button();
            this.btnShowDeclaration = new System.Windows.Forms.Button();
            this.btnShowOrganization = new System.Windows.Forms.Button();
            this.btnShowContragents = new System.Windows.Forms.Button();
            this.logList = new DeclarantBrige.com.asf.component.LogListBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadContragents
            // 
            this.btnLoadContragents.Location = new System.Drawing.Point(311, 13);
            this.btnLoadContragents.Name = "btnLoadContragents";
            this.btnLoadContragents.Size = new System.Drawing.Size(76, 23);
            this.btnLoadContragents.TabIndex = 2;
            this.btnLoadContragents.Text = "Загрузить";
            this.btnLoadContragents.UseVisualStyleBackColor = true;
            this.btnLoadContragents.Click += new System.EventHandler(this.btnLoadContragents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Контрагенты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Декларация:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoadDeclaration
            // 
            this.btnLoadDeclaration.Location = new System.Drawing.Point(311, 98);
            this.btnLoadDeclaration.Name = "btnLoadDeclaration";
            this.btnLoadDeclaration.Size = new System.Drawing.Size(76, 23);
            this.btnLoadDeclaration.TabIndex = 5;
            this.btnLoadDeclaration.Text = "Загрузить";
            this.btnLoadDeclaration.UseVisualStyleBackColor = true;
            this.btnLoadDeclaration.Click += new System.EventHandler(this.btnLoadDeclaration11_Click);
            // 
            // cmbDeclarations
            // 
            this.cmbDeclarations.FormattingEnabled = true;
            this.cmbDeclarations.Location = new System.Drawing.Point(148, 71);
            this.cmbDeclarations.Name = "cmbDeclarations";
            this.cmbDeclarations.Size = new System.Drawing.Size(239, 21);
            this.cmbDeclarations.TabIndex = 6;
            // 
            // cbClearDeclaration
            // 
            this.cbClearDeclaration.AutoSize = true;
            this.cbClearDeclaration.Location = new System.Drawing.Point(148, 102);
            this.cbClearDeclaration.Name = "cbClearDeclaration";
            this.cbClearDeclaration.Size = new System.Drawing.Size(136, 17);
            this.cbClearDeclaration.TabIndex = 8;
            this.cbClearDeclaration.Text = "Очищать декларацию";
            this.cbClearDeclaration.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Организация:";
            // 
            // cmbOrganizations
            // 
            this.cmbOrganizations.FormattingEnabled = true;
            this.cmbOrganizations.Location = new System.Drawing.Point(148, 44);
            this.cmbOrganizations.Name = "cmbOrganizations";
            this.cmbOrganizations.Size = new System.Drawing.Size(239, 21);
            this.cmbOrganizations.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckDeclaration);
            this.groupBox1.Controls.Add(this.btnCheckOrganization);
            this.groupBox1.Controls.Add(this.btnRefreshDeclaration);
            this.groupBox1.Controls.Add(this.btnRefreshOrganization);
            this.groupBox1.Controls.Add(this.btnShowDeclaration);
            this.groupBox1.Controls.Add(this.btnShowOrganization);
            this.groupBox1.Controls.Add(this.btnShowContragents);
            this.groupBox1.Controls.Add(this.cbClearDeclaration);
            this.groupBox1.Controls.Add(this.cmbOrganizations);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLoadDeclaration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLoadContragents);
            this.groupBox1.Controls.Add(this.cmbDeclarations);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 129);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка в декларант";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(72, 17);
            this.tsStatus.Text = "Ожидание...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiService,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(45, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiService
            // 
            this.tsmiService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProperties});
            this.tsmiService.Name = "tsmiService";
            this.tsmiService.Size = new System.Drawing.Size(55, 20);
            this.tsmiService.Text = "Сервис";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обToolStripMenuItem});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(62, 20);
            this.tsmiHelp.Text = "Справка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "База Декларант-Алко:";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(134, 30);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(284, 21);
            this.cmbDatabases.TabIndex = 18;
            // 
            // btnConnect
            // 
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConnect.Location = new System.Drawing.Point(424, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(22, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnErase
            // 
            this.btnErase.Image = global::DeclarantBrige.Properties.Resources.erase;
            this.btnErase.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnErase.Location = new System.Drawing.Point(452, 28);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(22, 23);
            this.btnErase.TabIndex = 5;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::DeclarantBrige.Properties.Resources.close;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(107, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiProperties
            // 
            this.tsmiProperties.Image = global::DeclarantBrige.Properties.Resources.properties;
            this.tsmiProperties.Name = "tsmiProperties";
            this.tsmiProperties.Size = new System.Drawing.Size(143, 22);
            this.tsmiProperties.Text = "Параметры...";
            this.tsmiProperties.Click += new System.EventHandler(this.tsmiProperties_Click);
            // 
            // обToolStripMenuItem
            // 
            this.обToolStripMenuItem.Image = global::DeclarantBrige.Properties.Resources.help;
            this.обToolStripMenuItem.Name = "обToolStripMenuItem";
            this.обToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.обToolStripMenuItem.Text = "О\'б";
            this.обToolStripMenuItem.Click += new System.EventHandler(this.обToolStripMenuItem_Click);
            // 
            // btnCheckDeclaration
            // 
            this.btnCheckDeclaration.Image = global::DeclarantBrige.Properties.Resources.check;
            this.btnCheckDeclaration.Location = new System.Drawing.Point(393, 69);
            this.btnCheckDeclaration.Name = "btnCheckDeclaration";
            this.btnCheckDeclaration.Size = new System.Drawing.Size(22, 23);
            this.btnCheckDeclaration.TabIndex = 16;
            this.btnCheckDeclaration.UseVisualStyleBackColor = true;
            this.btnCheckDeclaration.Click += new System.EventHandler(this.btnCheckDeclaration_Click);
            // 
            // btnCheckOrganization
            // 
            this.btnCheckOrganization.Enabled = false;
            this.btnCheckOrganization.Image = global::DeclarantBrige.Properties.Resources.check;
            this.btnCheckOrganization.Location = new System.Drawing.Point(393, 42);
            this.btnCheckOrganization.Name = "btnCheckOrganization";
            this.btnCheckOrganization.Size = new System.Drawing.Size(22, 23);
            this.btnCheckOrganization.TabIndex = 15;
            this.btnCheckOrganization.UseVisualStyleBackColor = true;
            // 
            // btnRefreshDeclaration
            // 
            this.btnRefreshDeclaration.Image = global::DeclarantBrige.Properties.Resources.refresh1;
            this.btnRefreshDeclaration.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRefreshDeclaration.Location = new System.Drawing.Point(449, 69);
            this.btnRefreshDeclaration.Name = "btnRefreshDeclaration";
            this.btnRefreshDeclaration.Size = new System.Drawing.Size(22, 23);
            this.btnRefreshDeclaration.TabIndex = 14;
            this.btnRefreshDeclaration.UseVisualStyleBackColor = true;
            this.btnRefreshDeclaration.Click += new System.EventHandler(this.btnRefreshDeclaration_Click);
            // 
            // btnRefreshOrganization
            // 
            this.btnRefreshOrganization.Image = global::DeclarantBrige.Properties.Resources.refresh1;
            this.btnRefreshOrganization.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRefreshOrganization.Location = new System.Drawing.Point(449, 42);
            this.btnRefreshOrganization.Name = "btnRefreshOrganization";
            this.btnRefreshOrganization.Size = new System.Drawing.Size(22, 23);
            this.btnRefreshOrganization.TabIndex = 13;
            this.btnRefreshOrganization.UseVisualStyleBackColor = true;
            this.btnRefreshOrganization.Click += new System.EventHandler(this.btnRefreshOrganization_Click);
            // 
            // btnShowDeclaration
            // 
            this.btnShowDeclaration.Image = global::DeclarantBrige.Properties.Resources.open1;
            this.btnShowDeclaration.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnShowDeclaration.Location = new System.Drawing.Point(421, 69);
            this.btnShowDeclaration.Name = "btnShowDeclaration";
            this.btnShowDeclaration.Size = new System.Drawing.Size(22, 23);
            this.btnShowDeclaration.TabIndex = 12;
            this.btnShowDeclaration.UseVisualStyleBackColor = true;
            this.btnShowDeclaration.Click += new System.EventHandler(this.btnShowDeclaration_Click);
            // 
            // btnShowOrganization
            // 
            this.btnShowOrganization.Image = global::DeclarantBrige.Properties.Resources.open1;
            this.btnShowOrganization.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnShowOrganization.Location = new System.Drawing.Point(421, 42);
            this.btnShowOrganization.Name = "btnShowOrganization";
            this.btnShowOrganization.Size = new System.Drawing.Size(22, 23);
            this.btnShowOrganization.TabIndex = 11;
            this.btnShowOrganization.UseVisualStyleBackColor = true;
            this.btnShowOrganization.Click += new System.EventHandler(this.btnShowOrganization_Click);
            // 
            // btnShowContragents
            // 
            this.btnShowContragents.Image = global::DeclarantBrige.Properties.Resources.open1;
            this.btnShowContragents.Location = new System.Drawing.Point(421, 13);
            this.btnShowContragents.Name = "btnShowContragents";
            this.btnShowContragents.Size = new System.Drawing.Size(22, 23);
            this.btnShowContragents.TabIndex = 4;
            this.btnShowContragents.UseVisualStyleBackColor = true;
            this.btnShowContragents.Click += new System.EventHandler(this.btnShowContragents_Click);
            // 
            // logList
            // 
            this.logList.FormattingEnabled = true;
            this.logList.Location = new System.Drawing.Point(3, 190);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(478, 147);
            this.logList.TabIndex = 14;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 363);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbDatabases);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.logList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "Загрузка данных в Декларант-Алко";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadContragents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadDeclaration;
        private System.Windows.Forms.ComboBox cmbDeclarations;
        private System.Windows.Forms.CheckBox cbClearDeclaration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOrganizations;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowContragents;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnRefreshDeclaration;
        private System.Windows.Forms.Button btnRefreshOrganization;
        private System.Windows.Forms.Button btnShowDeclaration;
        private System.Windows.Forms.Button btnShowOrganization;
        private com.asf.component.LogListBox logList;
        private System.Windows.Forms.ToolTip ttMainForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiService;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiProperties;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem обToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Button btnCheckOrganization;
        private System.Windows.Forms.Button btnCheckDeclaration;


    }
}

namespace DeclarantBrige.com.asf.component
{
    internal class LogListBox : global::com.asf.component.LogListBox
    {
    }
}

