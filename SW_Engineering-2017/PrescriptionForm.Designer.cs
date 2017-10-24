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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
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
            this.prsPatientGrp.SuspendLayout();
            this.prsAddressGrp.SuspendLayout();
            this.prsPrescriptionGrp.SuspendLayout();
            this.prsNotesGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // prsPatientGrp
            // 
            resources.ApplyResources(this.prsPatientGrp, "prsPatientGrp");
            this.prsPatientGrp.Controls.Add(this.prsDOBPicker);
            this.prsPatientGrp.Controls.Add(this.prsTitleCombo);
            this.prsPatientGrp.Controls.Add(this.prsTitleLbl);
            this.prsPatientGrp.Controls.Add(this.prsDateOfBirthLbl);
            this.prsPatientGrp.Controls.Add(this.prsAddressGrp);
            this.prsPatientGrp.Controls.Add(this.prsFornameEntry);
            this.prsPatientGrp.Controls.Add(this.prsForenameLbl);
            this.prsPatientGrp.Controls.Add(this.presSurnameLbl);
            this.prsPatientGrp.Controls.Add(this.prsSurnameEntry);
            this.prsPatientGrp.Name = "prsPatientGrp";
            this.prsPatientGrp.TabStop = false;
            this.prsPatientGrp.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // prsDOBPicker
            // 
            resources.ApplyResources(this.prsDOBPicker, "prsDOBPicker");
            this.prsDOBPicker.Name = "prsDOBPicker";
            // 
            // prsTitleCombo
            // 
            resources.ApplyResources(this.prsTitleCombo, "prsTitleCombo");
            this.prsTitleCombo.FormattingEnabled = true;
            this.prsTitleCombo.Name = "prsTitleCombo";
            // 
            // prsTitleLbl
            // 
            resources.ApplyResources(this.prsTitleLbl, "prsTitleLbl");
            this.prsTitleLbl.Name = "prsTitleLbl";
            // 
            // prsDateOfBirthLbl
            // 
            resources.ApplyResources(this.prsDateOfBirthLbl, "prsDateOfBirthLbl");
            this.prsDateOfBirthLbl.Name = "prsDateOfBirthLbl";
            // 
            // prsAddressGrp
            // 
            resources.ApplyResources(this.prsAddressGrp, "prsAddressGrp");
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
            this.prsAddressGrp.Name = "prsAddressGrp";
            this.prsAddressGrp.TabStop = false;
            // 
            // prsPostCodeEntry
            // 
            resources.ApplyResources(this.prsPostCodeEntry, "prsPostCodeEntry");
            this.prsPostCodeEntry.Name = "prsPostCodeEntry";
            // 
            // prsPostCodeLbl
            // 
            resources.ApplyResources(this.prsPostCodeLbl, "prsPostCodeLbl");
            this.prsPostCodeLbl.Name = "prsPostCodeLbl";
            // 
            // prsTownLbl
            // 
            resources.ApplyResources(this.prsTownLbl, "prsTownLbl");
            this.prsTownLbl.Name = "prsTownLbl";
            // 
            // prsCountyEntry
            // 
            resources.ApplyResources(this.prsCountyEntry, "prsCountyEntry");
            this.prsCountyEntry.Name = "prsCountyEntry";
            // 
            // prsCountyLbl
            // 
            resources.ApplyResources(this.prsCountyLbl, "prsCountyLbl");
            this.prsCountyLbl.Name = "prsCountyLbl";
            // 
            // prsTownEntry
            // 
            resources.ApplyResources(this.prsTownEntry, "prsTownEntry");
            this.prsTownEntry.Name = "prsTownEntry";
            // 
            // prsAddLn2Entry
            // 
            resources.ApplyResources(this.prsAddLn2Entry, "prsAddLn2Entry");
            this.prsAddLn2Entry.Name = "prsAddLn2Entry";
            // 
            // prsAddLn2Lbl
            // 
            resources.ApplyResources(this.prsAddLn2Lbl, "prsAddLn2Lbl");
            this.prsAddLn2Lbl.Name = "prsAddLn2Lbl";
            // 
            // prsAddLn1Entry
            // 
            resources.ApplyResources(this.prsAddLn1Entry, "prsAddLn1Entry");
            this.prsAddLn1Entry.Name = "prsAddLn1Entry";
            // 
            // prsAddLn1Lbl
            // 
            resources.ApplyResources(this.prsAddLn1Lbl, "prsAddLn1Lbl");
            this.prsAddLn1Lbl.Name = "prsAddLn1Lbl";
            // 
            // prsFornameEntry
            // 
            resources.ApplyResources(this.prsFornameEntry, "prsFornameEntry");
            this.prsFornameEntry.Name = "prsFornameEntry";
            // 
            // prsForenameLbl
            // 
            resources.ApplyResources(this.prsForenameLbl, "prsForenameLbl");
            this.prsForenameLbl.Name = "prsForenameLbl";
            // 
            // presSurnameLbl
            // 
            resources.ApplyResources(this.presSurnameLbl, "presSurnameLbl");
            this.presSurnameLbl.Name = "presSurnameLbl";
            // 
            // prsSurnameEntry
            // 
            resources.ApplyResources(this.prsSurnameEntry, "prsSurnameEntry");
            this.prsSurnameEntry.Name = "prsSurnameEntry";
            // 
            // prsPrescriptionGrp
            // 
            resources.ApplyResources(this.prsPrescriptionGrp, "prsPrescriptionGrp");
            this.prsPrescriptionGrp.Controls.Add(this.prsRenewCombo);
            this.prsPrescriptionGrp.Controls.Add(this.prsRenewLbl);
            this.prsPrescriptionGrp.Controls.Add(this.prsNotesGrp);
            this.prsPrescriptionGrp.Controls.Add(this.prsQuantityEntry);
            this.prsPrescriptionGrp.Controls.Add(this.prsPrescriptionNameEntry);
            this.prsPrescriptionGrp.Controls.Add(this.prsDatePicker);
            this.prsPrescriptionGrp.Controls.Add(this.prsDateLbl);
            this.prsPrescriptionGrp.Controls.Add(this.prsQuantityLbl);
            this.prsPrescriptionGrp.Controls.Add(this.prsPrescriptionNameLbl);
            this.prsPrescriptionGrp.Name = "prsPrescriptionGrp";
            this.prsPrescriptionGrp.TabStop = false;
            // 
            // prsRenewCombo
            // 
            resources.ApplyResources(this.prsRenewCombo, "prsRenewCombo");
            this.prsRenewCombo.FormattingEnabled = true;
            this.prsRenewCombo.Name = "prsRenewCombo";
            // 
            // prsRenewLbl
            // 
            resources.ApplyResources(this.prsRenewLbl, "prsRenewLbl");
            this.prsRenewLbl.Name = "prsRenewLbl";
            // 
            // prsNotesGrp
            // 
            resources.ApplyResources(this.prsNotesGrp, "prsNotesGrp");
            this.prsNotesGrp.Controls.Add(this.prsNotesEntry);
            this.prsNotesGrp.Name = "prsNotesGrp";
            this.prsNotesGrp.TabStop = false;
            this.prsNotesGrp.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // prsNotesEntry
            // 
            resources.ApplyResources(this.prsNotesEntry, "prsNotesEntry");
            this.prsNotesEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prsNotesEntry.Name = "prsNotesEntry";
            // 
            // prsQuantityEntry
            // 
            resources.ApplyResources(this.prsQuantityEntry, "prsQuantityEntry");
            this.prsQuantityEntry.Name = "prsQuantityEntry";
            // 
            // prsPrescriptionNameEntry
            // 
            resources.ApplyResources(this.prsPrescriptionNameEntry, "prsPrescriptionNameEntry");
            this.prsPrescriptionNameEntry.Name = "prsPrescriptionNameEntry";
            // 
            // prsDatePicker
            // 
            resources.ApplyResources(this.prsDatePicker, "prsDatePicker");
            this.prsDatePicker.Name = "prsDatePicker";
            // 
            // prsDateLbl
            // 
            resources.ApplyResources(this.prsDateLbl, "prsDateLbl");
            this.prsDateLbl.Name = "prsDateLbl";
            // 
            // prsQuantityLbl
            // 
            resources.ApplyResources(this.prsQuantityLbl, "prsQuantityLbl");
            this.prsQuantityLbl.Name = "prsQuantityLbl";
            // 
            // prsPrescriptionNameLbl
            // 
            resources.ApplyResources(this.prsPrescriptionNameLbl, "prsPrescriptionNameLbl");
            this.prsPrescriptionNameLbl.Name = "prsPrescriptionNameLbl";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // PrescriptionForm
            // 
            this.AcceptButton = this.btnApply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.prsPrescriptionGrp);
            this.Controls.Add(this.prsPatientGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrescriptionForm";
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
    }
}