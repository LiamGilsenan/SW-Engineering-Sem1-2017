namespace SW_Engineering_2017
{
    partial class PrescriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prsPatientGrp = new System.Windows.Forms.GroupBox();
            this.prsDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.prsTitleCombo = new System.Windows.Forms.ComboBox();
            this.prsTitleLbl = new System.Windows.Forms.Label();
            this.prsDateOfBirthLbl = new System.Windows.Forms.Label();
            this.prsAddressGrp = new System.Windows.Forms.GroupBox();
            this.prsPostCodeEntry = new System.Windows.Forms.TextBox();
            this.prsPostCodeLbl = new System.Windows.Forms.Label();
            this.prsTownLbl = new System.Windows.Forms.Label();
            this.prsCountyEntry = new System.Windows.Forms.TextBox();
            this.prsCountyLbl = new System.Windows.Forms.Label();
            this.prsTownEntry = new System.Windows.Forms.TextBox();
            this.prsAddLn2Entry = new System.Windows.Forms.TextBox();
            this.prsAddLn2Lbl = new System.Windows.Forms.Label();
            this.prsAddLn1Entry = new System.Windows.Forms.TextBox();
            this.prsAddLn1Lbl = new System.Windows.Forms.Label();
            this.prsFornameEntry = new System.Windows.Forms.TextBox();
            this.prsForenameLbl = new System.Windows.Forms.Label();
            this.presSurnameLbl = new System.Windows.Forms.Label();
            this.prsSurnameEntry = new System.Windows.Forms.TextBox();
            this.prsPrescriptionGrp = new System.Windows.Forms.GroupBox();
            this.prsRenewCombo = new System.Windows.Forms.ComboBox();
            this.prsRenewLbl = new System.Windows.Forms.Label();
            this.prsNotesGrp = new System.Windows.Forms.GroupBox();
            this.prsNotesEntry = new System.Windows.Forms.TextBox();
            this.prsQuantityEntry = new System.Windows.Forms.TextBox();
            this.prsPrescriptionNameEntry = new System.Windows.Forms.TextBox();
            this.prsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.prsDateLbl = new System.Windows.Forms.Label();
            this.prsQuantityLbl = new System.Windows.Forms.Label();
            this.prsPrescriptionNameLbl = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.prescriptionPanel = new System.Windows.Forms.Panel();
            this.prsPatientGrp.SuspendLayout();
            this.prsAddressGrp.SuspendLayout();
            this.prsPrescriptionGrp.SuspendLayout();
            this.prsNotesGrp.SuspendLayout();
            this.prescriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prsPatientGrp
            // 
            this.prsPatientGrp.AccessibleName = "Patient Details";
            this.prsPatientGrp.Controls.Add(this.prsDOBPicker);
            this.prsPatientGrp.Controls.Add(this.prsTitleCombo);
            this.prsPatientGrp.Controls.Add(this.prsTitleLbl);
            this.prsPatientGrp.Controls.Add(this.prsDateOfBirthLbl);
            this.prsPatientGrp.Controls.Add(this.prsAddressGrp);
            this.prsPatientGrp.Controls.Add(this.prsFornameEntry);
            this.prsPatientGrp.Controls.Add(this.prsForenameLbl);
            this.prsPatientGrp.Controls.Add(this.presSurnameLbl);
            this.prsPatientGrp.Controls.Add(this.prsSurnameEntry);
            this.prsPatientGrp.Location = new System.Drawing.Point(25, 13);
            this.prsPatientGrp.Name = "prsPatientGrp";
            this.prsPatientGrp.Size = new System.Drawing.Size(339, 207);
            this.prsPatientGrp.TabIndex = 0;
            this.prsPatientGrp.TabStop = false;
            this.prsPatientGrp.Text = "Patient Details";
            this.prsPatientGrp.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // prsDOBPicker
            // 
            this.prsDOBPicker.Location = new System.Drawing.Point(203, 44);
            this.prsDOBPicker.Name = "prsDOBPicker";
            this.prsDOBPicker.Size = new System.Drawing.Size(125, 20);
            this.prsDOBPicker.TabIndex = 9;
            // 
            // prsTitleCombo
            // 
            this.prsTitleCombo.FormattingEnabled = true;
            this.prsTitleCombo.Location = new System.Drawing.Point(61, 45);
            this.prsTitleCombo.Name = "prsTitleCombo";
            this.prsTitleCombo.Size = new System.Drawing.Size(100, 21);
            this.prsTitleCombo.TabIndex = 8;
            // 
            // prsTitleLbl
            // 
            this.prsTitleLbl.AutoSize = true;
            this.prsTitleLbl.Location = new System.Drawing.Point(6, 48);
            this.prsTitleLbl.Name = "prsTitleLbl";
            this.prsTitleLbl.Size = new System.Drawing.Size(27, 13);
            this.prsTitleLbl.TabIndex = 7;
            this.prsTitleLbl.Text = "Title";
            // 
            // prsDateOfBirthLbl
            // 
            this.prsDateOfBirthLbl.AutoSize = true;
            this.prsDateOfBirthLbl.Location = new System.Drawing.Point(167, 48);
            this.prsDateOfBirthLbl.Name = "prsDateOfBirthLbl";
            this.prsDateOfBirthLbl.Size = new System.Drawing.Size(30, 13);
            this.prsDateOfBirthLbl.TabIndex = 6;
            this.prsDateOfBirthLbl.Text = "DOB";
            // 
            // prsAddressGrp
            // 
            this.prsAddressGrp.Controls.Add(this.prsPostCodeEntry);
            this.prsAddressGrp.Controls.Add(this.prsPostCodeLbl);
            this.prsAddressGrp.Controls.Add(this.prsTownLbl);
            this.prsAddressGrp.Controls.Add(this.prsCountyEntry);
            this.prsAddressGrp.Controls.Add(this.prsCountyLbl);
            this.prsAddressGrp.Controls.Add(this.prsTownEntry);
            this.prsAddressGrp.Controls.Add(this.prsAddLn2Entry);
            this.prsAddressGrp.Controls.Add(this.prsAddLn2Lbl);
            this.prsAddressGrp.Controls.Add(this.prsAddLn1Entry);
            this.prsAddressGrp.Controls.Add(this.prsAddLn1Lbl);
            this.prsAddressGrp.Location = new System.Drawing.Point(9, 72);
            this.prsAddressGrp.Name = "prsAddressGrp";
            this.prsAddressGrp.Size = new System.Drawing.Size(319, 126);
            this.prsAddressGrp.TabIndex = 4;
            this.prsAddressGrp.TabStop = false;
            this.prsAddressGrp.Text = "Address";
            // 
            // prsPostCodeEntry
            // 
            this.prsPostCodeEntry.Location = new System.Drawing.Point(84, 97);
            this.prsPostCodeEntry.Name = "prsPostCodeEntry";
            this.prsPostCodeEntry.Size = new System.Drawing.Size(68, 20);
            this.prsPostCodeEntry.TabIndex = 10;
            // 
            // prsPostCodeLbl
            // 
            this.prsPostCodeLbl.AutoSize = true;
            this.prsPostCodeLbl.Location = new System.Drawing.Point(6, 100);
            this.prsPostCodeLbl.Name = "prsPostCodeLbl";
            this.prsPostCodeLbl.Size = new System.Drawing.Size(56, 13);
            this.prsPostCodeLbl.TabIndex = 9;
            this.prsPostCodeLbl.Text = "Post Code";
            // 
            // prsTownLbl
            // 
            this.prsTownLbl.AutoSize = true;
            this.prsTownLbl.Location = new System.Drawing.Point(6, 74);
            this.prsTownLbl.Name = "prsTownLbl";
            this.prsTownLbl.Size = new System.Drawing.Size(56, 13);
            this.prsTownLbl.TabIndex = 8;
            this.prsTownLbl.Text = "Town/City";
            // 
            // prsCountyEntry
            // 
            this.prsCountyEntry.Location = new System.Drawing.Point(204, 71);
            this.prsCountyEntry.Name = "prsCountyEntry";
            this.prsCountyEntry.Size = new System.Drawing.Size(108, 20);
            this.prsCountyEntry.TabIndex = 7;
            // 
            // prsCountyLbl
            // 
            this.prsCountyLbl.AutoSize = true;
            this.prsCountyLbl.Location = new System.Drawing.Point(158, 74);
            this.prsCountyLbl.Name = "prsCountyLbl";
            this.prsCountyLbl.Size = new System.Drawing.Size(40, 13);
            this.prsCountyLbl.TabIndex = 6;
            this.prsCountyLbl.Text = "County";
            // 
            // prsTownEntry
            // 
            this.prsTownEntry.Location = new System.Drawing.Point(84, 71);
            this.prsTownEntry.Name = "prsTownEntry";
            this.prsTownEntry.Size = new System.Drawing.Size(68, 20);
            this.prsTownEntry.TabIndex = 5;
            // 
            // prsAddLn2Entry
            // 
            this.prsAddLn2Entry.Location = new System.Drawing.Point(84, 45);
            this.prsAddLn2Entry.Name = "prsAddLn2Entry";
            this.prsAddLn2Entry.Size = new System.Drawing.Size(228, 20);
            this.prsAddLn2Entry.TabIndex = 4;
            // 
            // prsAddLn2Lbl
            // 
            this.prsAddLn2Lbl.AutoSize = true;
            this.prsAddLn2Lbl.Location = new System.Drawing.Point(6, 48);
            this.prsAddLn2Lbl.Name = "prsAddLn2Lbl";
            this.prsAddLn2Lbl.Size = new System.Drawing.Size(72, 13);
            this.prsAddLn2Lbl.TabIndex = 3;
            this.prsAddLn2Lbl.Text = "Address Ln. 2";
            // 
            // prsAddLn1Entry
            // 
            this.prsAddLn1Entry.Location = new System.Drawing.Point(84, 17);
            this.prsAddLn1Entry.Name = "prsAddLn1Entry";
            this.prsAddLn1Entry.Size = new System.Drawing.Size(228, 20);
            this.prsAddLn1Entry.TabIndex = 2;
            // 
            // prsAddLn1Lbl
            // 
            this.prsAddLn1Lbl.AutoSize = true;
            this.prsAddLn1Lbl.Location = new System.Drawing.Point(7, 20);
            this.prsAddLn1Lbl.Name = "prsAddLn1Lbl";
            this.prsAddLn1Lbl.Size = new System.Drawing.Size(72, 13);
            this.prsAddLn1Lbl.TabIndex = 0;
            this.prsAddLn1Lbl.Text = "Address Ln. 1";
            // 
            // prsFornameEntry
            // 
            this.prsFornameEntry.Location = new System.Drawing.Point(228, 18);
            this.prsFornameEntry.Name = "prsFornameEntry";
            this.prsFornameEntry.Size = new System.Drawing.Size(100, 20);
            this.prsFornameEntry.TabIndex = 3;
            // 
            // prsForenameLbl
            // 
            this.prsForenameLbl.AutoSize = true;
            this.prsForenameLbl.Location = new System.Drawing.Point(167, 22);
            this.prsForenameLbl.Name = "prsForenameLbl";
            this.prsForenameLbl.Size = new System.Drawing.Size(54, 13);
            this.prsForenameLbl.TabIndex = 2;
            this.prsForenameLbl.Text = "Forename";
            // 
            // presSurnameLbl
            // 
            this.presSurnameLbl.AutoSize = true;
            this.presSurnameLbl.Location = new System.Drawing.Point(6, 22);
            this.presSurnameLbl.Name = "presSurnameLbl";
            this.presSurnameLbl.Size = new System.Drawing.Size(49, 13);
            this.presSurnameLbl.TabIndex = 1;
            this.presSurnameLbl.Text = "Surname";
            // 
            // prsSurnameEntry
            // 
            this.prsSurnameEntry.Location = new System.Drawing.Point(61, 19);
            this.prsSurnameEntry.Name = "prsSurnameEntry";
            this.prsSurnameEntry.Size = new System.Drawing.Size(100, 20);
            this.prsSurnameEntry.TabIndex = 0;
            // 
            // prsPrescriptionGrp
            // 
            this.prsPrescriptionGrp.Controls.Add(this.prsRenewCombo);
            this.prsPrescriptionGrp.Controls.Add(this.prsRenewLbl);
            this.prsPrescriptionGrp.Controls.Add(this.prsNotesGrp);
            this.prsPrescriptionGrp.Controls.Add(this.prsQuantityEntry);
            this.prsPrescriptionGrp.Controls.Add(this.prsPrescriptionNameEntry);
            this.prsPrescriptionGrp.Controls.Add(this.prsDatePicker);
            this.prsPrescriptionGrp.Controls.Add(this.prsDateLbl);
            this.prsPrescriptionGrp.Controls.Add(this.prsQuantityLbl);
            this.prsPrescriptionGrp.Controls.Add(this.prsPrescriptionNameLbl);
            this.prsPrescriptionGrp.Location = new System.Drawing.Point(370, 13);
            this.prsPrescriptionGrp.Name = "prsPrescriptionGrp";
            this.prsPrescriptionGrp.Size = new System.Drawing.Size(256, 207);
            this.prsPrescriptionGrp.TabIndex = 1;
            this.prsPrescriptionGrp.TabStop = false;
            this.prsPrescriptionGrp.Text = "Prescription Details";
            // 
            // prsRenewCombo
            // 
            this.prsRenewCombo.FormattingEnabled = true;
            this.prsRenewCombo.Location = new System.Drawing.Point(58, 96);
            this.prsRenewCombo.Name = "prsRenewCombo";
            this.prsRenewCombo.Size = new System.Drawing.Size(54, 21);
            this.prsRenewCombo.TabIndex = 8;
            // 
            // prsRenewLbl
            // 
            this.prsRenewLbl.AutoSize = true;
            this.prsRenewLbl.Location = new System.Drawing.Point(6, 99);
            this.prsRenewLbl.Name = "prsRenewLbl";
            this.prsRenewLbl.Size = new System.Drawing.Size(41, 13);
            this.prsRenewLbl.TabIndex = 7;
            this.prsRenewLbl.Text = "Renew";
            // 
            // prsNotesGrp
            // 
            this.prsNotesGrp.Controls.Add(this.prsNotesEntry);
            this.prsNotesGrp.Location = new System.Drawing.Point(6, 123);
            this.prsNotesGrp.Name = "prsNotesGrp";
            this.prsNotesGrp.Size = new System.Drawing.Size(244, 78);
            this.prsNotesGrp.TabIndex = 6;
            this.prsNotesGrp.TabStop = false;
            this.prsNotesGrp.Text = "Additional Notes";
            this.prsNotesGrp.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // prsNotesEntry
            // 
            this.prsNotesEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prsNotesEntry.Location = new System.Drawing.Point(6, 19);
            this.prsNotesEntry.Multiline = true;
            this.prsNotesEntry.Name = "prsNotesEntry";
            this.prsNotesEntry.Size = new System.Drawing.Size(232, 56);
            this.prsNotesEntry.TabIndex = 0;
            // 
            // prsQuantityEntry
            // 
            this.prsQuantityEntry.Location = new System.Drawing.Point(58, 44);
            this.prsQuantityEntry.Name = "prsQuantityEntry";
            this.prsQuantityEntry.Size = new System.Drawing.Size(116, 20);
            this.prsQuantityEntry.TabIndex = 5;
            // 
            // prsPrescriptionNameEntry
            // 
            this.prsPrescriptionNameEntry.Location = new System.Drawing.Point(58, 19);
            this.prsPrescriptionNameEntry.Name = "prsPrescriptionNameEntry";
            this.prsPrescriptionNameEntry.Size = new System.Drawing.Size(192, 20);
            this.prsPrescriptionNameEntry.TabIndex = 4;
            // 
            // prsDatePicker
            // 
            this.prsDatePicker.Location = new System.Drawing.Point(58, 70);
            this.prsDatePicker.Name = "prsDatePicker";
            this.prsDatePicker.Size = new System.Drawing.Size(116, 20);
            this.prsDatePicker.TabIndex = 3;
            // 
            // prsDateLbl
            // 
            this.prsDateLbl.AutoSize = true;
            this.prsDateLbl.Location = new System.Drawing.Point(6, 73);
            this.prsDateLbl.Name = "prsDateLbl";
            this.prsDateLbl.Size = new System.Drawing.Size(30, 13);
            this.prsDateLbl.TabIndex = 2;
            this.prsDateLbl.Text = "Date";
            // 
            // prsQuantityLbl
            // 
            this.prsQuantityLbl.AutoSize = true;
            this.prsQuantityLbl.Location = new System.Drawing.Point(6, 48);
            this.prsQuantityLbl.Name = "prsQuantityLbl";
            this.prsQuantityLbl.Size = new System.Drawing.Size(46, 13);
            this.prsQuantityLbl.TabIndex = 1;
            this.prsQuantityLbl.Text = "Quantity";
            // 
            // prsPrescriptionNameLbl
            // 
            this.prsPrescriptionNameLbl.AutoSize = true;
            this.prsPrescriptionNameLbl.Location = new System.Drawing.Point(6, 22);
            this.prsPrescriptionNameLbl.Name = "prsPrescriptionNameLbl";
            this.prsPrescriptionNameLbl.Size = new System.Drawing.Size(35, 13);
            this.prsPrescriptionNameLbl.TabIndex = 0;
            this.prsPrescriptionNameLbl.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(551, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(451, 250);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // prescriptionPanel
            // 
            this.prescriptionPanel.Controls.Add(this.prsPatientGrp);
            this.prescriptionPanel.Controls.Add(this.btnCancel);
            this.prescriptionPanel.Controls.Add(this.btnApply);
            this.prescriptionPanel.Controls.Add(this.prsPrescriptionGrp);
            this.prescriptionPanel.Location = new System.Drawing.Point(12, 12);
            this.prescriptionPanel.Name = "prescriptionPanel";
            this.prescriptionPanel.Size = new System.Drawing.Size(673, 312);
            this.prescriptionPanel.TabIndex = 4;
            // 
            // PrescriptionForm
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.prescriptionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Prescription";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.prsPatientGrp.ResumeLayout(false);
            this.prsPatientGrp.PerformLayout();
            this.prsAddressGrp.ResumeLayout(false);
            this.prsAddressGrp.PerformLayout();
            this.prsPrescriptionGrp.ResumeLayout(false);
            this.prsPrescriptionGrp.PerformLayout();
            this.prsNotesGrp.ResumeLayout(false);
            this.prsNotesGrp.PerformLayout();
            this.prescriptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox prsPatientGrp;
        private System.Windows.Forms.GroupBox prsAddressGrp;
        private System.Windows.Forms.TextBox prsAddLn1Entry;
        private System.Windows.Forms.Label prsAddLn1Lbl;
        private System.Windows.Forms.TextBox prsFornameEntry;
        private System.Windows.Forms.Label prsForenameLbl;
        private System.Windows.Forms.Label presSurnameLbl;
        private System.Windows.Forms.TextBox prsSurnameEntry;
        private System.Windows.Forms.ComboBox prsTitleCombo;
        private System.Windows.Forms.Label prsTitleLbl;
        private System.Windows.Forms.Label prsDateOfBirthLbl;
        private System.Windows.Forms.TextBox prsPostCodeEntry;
        private System.Windows.Forms.Label prsPostCodeLbl;
        private System.Windows.Forms.Label prsTownLbl;
        private System.Windows.Forms.TextBox prsCountyEntry;
        private System.Windows.Forms.Label prsCountyLbl;
        private System.Windows.Forms.TextBox prsTownEntry;
        private System.Windows.Forms.TextBox prsAddLn2Entry;
        private System.Windows.Forms.Label prsAddLn2Lbl;
        private System.Windows.Forms.DateTimePicker prsDOBPicker;
        private System.Windows.Forms.GroupBox prsPrescriptionGrp;
        private System.Windows.Forms.GroupBox prsNotesGrp;
        private System.Windows.Forms.TextBox prsQuantityEntry;
        private System.Windows.Forms.TextBox prsPrescriptionNameEntry;
        private System.Windows.Forms.DateTimePicker prsDatePicker;
        private System.Windows.Forms.Label prsDateLbl;
        private System.Windows.Forms.Label prsQuantityLbl;
        private System.Windows.Forms.Label prsPrescriptionNameLbl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox prsRenewCombo;
        private System.Windows.Forms.Label prsRenewLbl;
        private System.Windows.Forms.TextBox prsNotesEntry;
        private System.Windows.Forms.Panel prescriptionPanel;
    }
}