namespace com.asf.declarantbrige.forms {
    partial class OrganizationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRegionCode = new System.Windows.Forms.TextBox();
            this.lblRegionCode = new System.Windows.Forms.Label();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.lblKpp = new System.Windows.Forms.Label();
            this.lblInn = new System.Windows.Forms.Label();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.txtKpp = new System.Windows.Forms.TextBox();
            this.txtInn = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwDepartments = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(328, 270);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(409, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtRegionCode);
            this.panel1.Controls.Add(this.lblRegionCode);
            this.panel1.Controls.Add(this.lblCountryCode);
            this.panel1.Controls.Add(this.lblIndex);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtCountryCode);
            this.panel1.Controls.Add(this.txtIndex);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblOrgName);
            this.panel1.Controls.Add(this.lblKpp);
            this.panel1.Controls.Add(this.lblInn);
            this.panel1.Controls.Add(this.txtOrgName);
            this.panel1.Controls.Add(this.txtKpp);
            this.panel1.Controls.Add(this.txtInn);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 121);
            this.panel1.TabIndex = 2;
            // 
            // txtRegionCode
            // 
            this.txtRegionCode.Location = new System.Drawing.Point(282, 88);
            this.txtRegionCode.Name = "txtRegionCode";
            this.txtRegionCode.Size = new System.Drawing.Size(64, 20);
            this.txtRegionCode.TabIndex = 15;
            // 
            // lblRegionCode
            // 
            this.lblRegionCode.AutoSize = true;
            this.lblRegionCode.Location = new System.Drawing.Point(203, 91);
            this.lblRegionCode.Name = "lblRegionCode";
            this.lblRegionCode.Size = new System.Drawing.Size(73, 13);
            this.lblRegionCode.TabIndex = 14;
            this.lblRegionCode.Text = "Код региона:";
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Location = new System.Drawing.Point(28, 91);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(69, 13);
            this.lblCountryCode.TabIndex = 13;
            this.lblCountryCode.Text = "Код страны:";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(349, 65);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(48, 13);
            this.lblIndex.TabIndex = 12;
            this.lblIndex.Text = "Индекс:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(214, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "e-mail:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(42, 65);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Телефон:";
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(103, 88);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(86, 20);
            this.txtCountryCode.TabIndex = 9;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(403, 62);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(80, 20);
            this.txtIndex.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(257, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(89, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(103, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(105, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Location = new System.Drawing.Point(11, 39);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(86, 13);
            this.lblOrgName.TabIndex = 5;
            this.lblOrgName.Text = "Наименование:";
            // 
            // lblKpp
            // 
            this.lblKpp.AutoSize = true;
            this.lblKpp.Location = new System.Drawing.Point(203, 13);
            this.lblKpp.Name = "lblKpp";
            this.lblKpp.Size = new System.Drawing.Size(33, 13);
            this.lblKpp.TabIndex = 4;
            this.lblKpp.Text = "КПП:";
            // 
            // lblInn
            // 
            this.lblInn.AutoSize = true;
            this.lblInn.Location = new System.Drawing.Point(63, 13);
            this.lblInn.Name = "lblInn";
            this.lblInn.Size = new System.Drawing.Size(34, 13);
            this.lblInn.TabIndex = 3;
            this.lblInn.Text = "ИНН:";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(103, 36);
            this.txtOrgName.MaxLength = 1000;
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(380, 20);
            this.txtOrgName.TabIndex = 2;
            // 
            // txtKpp
            // 
            this.txtKpp.Location = new System.Drawing.Point(242, 10);
            this.txtKpp.MaxLength = 9;
            this.txtKpp.Name = "txtKpp";
            this.txtKpp.Size = new System.Drawing.Size(83, 20);
            this.txtKpp.TabIndex = 1;
            // 
            // txtInn
            // 
            this.txtInn.Location = new System.Drawing.Point(103, 10);
            this.txtInn.MaxLength = 12;
            this.txtInn.Name = "txtInn";
            this.txtInn.Size = new System.Drawing.Size(83, 20);
            this.txtInn.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgwDepartments);
            this.panel2.Location = new System.Drawing.Point(1, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 133);
            this.panel2.TabIndex = 3;
            // 
            // dgwDepartments
            // 
            this.dgwDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDepartments.Location = new System.Drawing.Point(0, 0);
            this.dgwDepartments.Name = "dgwDepartments";
            this.dgwDepartments.RowHeadersVisible = false;
            this.dgwDepartments.Size = new System.Drawing.Size(490, 129);
            this.dgwDepartments.TabIndex = 0;
            // 
            // OrganizationForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(496, 301);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "OrganizationForm";
            this.Text = "Организация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInn;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.TextBox txtKpp;
        private System.Windows.Forms.Label lblInn;
        private System.Windows.Forms.Label lblKpp;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label lblRegionCode;
        private System.Windows.Forms.TextBox txtRegionCode;
        private System.Windows.Forms.DataGridView dgwDepartments;

    }
}