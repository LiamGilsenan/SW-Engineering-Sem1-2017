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
            this.patientDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientTitle = new System.Windows.Forms.Label();
            this.patientDateOfBirth = new System.Windows.Forms.Label();
            this.patientAddress = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.patientPostCode = new System.Windows.Forms.Label();
            this.patientTown = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.patientCounty = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.patientAddressLn2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.patientAddressLn1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.patientForename = new System.Windows.Forms.Label();
            this.patientSurname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prescriptionInfo = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prescriptionNotes = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.prescriptionDate = new System.Windows.Forms.Label();
            this.prescriptionQuantity = new System.Windows.Forms.Label();
            this.prescriptionName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.patientDetails.SuspendLayout();
            this.patientAddress.SuspendLayout();
            this.prescriptionInfo.SuspendLayout();
            this.prescriptionNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientDetails
            // 
            resources.ApplyResources(this.patientDetails, "patientDetails");
            this.patientDetails.Controls.Add(this.dateTimePicker1);
            this.patientDetails.Controls.Add(this.comboBox1);
            this.patientDetails.Controls.Add(this.patientTitle);
            this.patientDetails.Controls.Add(this.patientDateOfBirth);
            this.patientDetails.Controls.Add(this.patientAddress);
            this.patientDetails.Controls.Add(this.textBox2);
            this.patientDetails.Controls.Add(this.patientForename);
            this.patientDetails.Controls.Add(this.patientSurname);
            this.patientDetails.Controls.Add(this.textBox1);
            this.patientDetails.Name = "patientDetails";
            this.patientDetails.TabStop = false;
            this.patientDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // patientTitle
            // 
            resources.ApplyResources(this.patientTitle, "patientTitle");
            this.patientTitle.Name = "patientTitle";
            // 
            // patientDateOfBirth
            // 
            resources.ApplyResources(this.patientDateOfBirth, "patientDateOfBirth");
            this.patientDateOfBirth.Name = "patientDateOfBirth";
            // 
            // patientAddress
            // 
            resources.ApplyResources(this.patientAddress, "patientAddress");
            this.patientAddress.Controls.Add(this.textBox8);
            this.patientAddress.Controls.Add(this.patientPostCode);
            this.patientAddress.Controls.Add(this.patientTown);
            this.patientAddress.Controls.Add(this.textBox7);
            this.patientAddress.Controls.Add(this.patientCounty);
            this.patientAddress.Controls.Add(this.textBox6);
            this.patientAddress.Controls.Add(this.textBox5);
            this.patientAddress.Controls.Add(this.patientAddressLn2);
            this.patientAddress.Controls.Add(this.textBox3);
            this.patientAddress.Controls.Add(this.patientAddressLn1);
            this.patientAddress.Name = "patientAddress";
            this.patientAddress.TabStop = false;
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // patientPostCode
            // 
            resources.ApplyResources(this.patientPostCode, "patientPostCode");
            this.patientPostCode.Name = "patientPostCode";
            // 
            // patientTown
            // 
            resources.ApplyResources(this.patientTown, "patientTown");
            this.patientTown.Name = "patientTown";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // patientCounty
            // 
            resources.ApplyResources(this.patientCounty, "patientCounty");
            this.patientCounty.Name = "patientCounty";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // patientAddressLn2
            // 
            resources.ApplyResources(this.patientAddressLn2, "patientAddressLn2");
            this.patientAddressLn2.Name = "patientAddressLn2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // patientAddressLn1
            // 
            resources.ApplyResources(this.patientAddressLn1, "patientAddressLn1");
            this.patientAddressLn1.Name = "patientAddressLn1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // patientForename
            // 
            resources.ApplyResources(this.patientForename, "patientForename");
            this.patientForename.Name = "patientForename";
            // 
            // patientSurname
            // 
            resources.ApplyResources(this.patientSurname, "patientSurname");
            this.patientSurname.Name = "patientSurname";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // prescriptionInfo
            // 
            resources.ApplyResources(this.prescriptionInfo, "prescriptionInfo");
            this.prescriptionInfo.Controls.Add(this.comboBox2);
            this.prescriptionInfo.Controls.Add(this.label1);
            this.prescriptionInfo.Controls.Add(this.prescriptionNotes);
            this.prescriptionInfo.Controls.Add(this.textBox9);
            this.prescriptionInfo.Controls.Add(this.textBox4);
            this.prescriptionInfo.Controls.Add(this.dateTimePicker2);
            this.prescriptionInfo.Controls.Add(this.prescriptionDate);
            this.prescriptionInfo.Controls.Add(this.prescriptionQuantity);
            this.prescriptionInfo.Controls.Add(this.prescriptionName);
            this.prescriptionInfo.Name = "prescriptionInfo";
            this.prescriptionInfo.TabStop = false;
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // prescriptionNotes
            // 
            resources.ApplyResources(this.prescriptionNotes, "prescriptionNotes");
            this.prescriptionNotes.Controls.Add(this.textBox10);
            this.prescriptionNotes.Name = "prescriptionNotes";
            this.prescriptionNotes.TabStop = false;
            this.prescriptionNotes.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Name = "textBox10";
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // prescriptionDate
            // 
            resources.ApplyResources(this.prescriptionDate, "prescriptionDate");
            this.prescriptionDate.Name = "prescriptionDate";
            // 
            // prescriptionQuantity
            // 
            resources.ApplyResources(this.prescriptionQuantity, "prescriptionQuantity");
            this.prescriptionQuantity.Name = "prescriptionQuantity";
            // 
            // prescriptionName
            // 
            resources.ApplyResources(this.prescriptionName, "prescriptionName");
            this.prescriptionName.Name = "prescriptionName";
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
            this.Controls.Add(this.prescriptionInfo);
            this.Controls.Add(this.patientDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrescriptionForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.patientDetails.ResumeLayout(false);
            this.patientDetails.PerformLayout();
            this.patientAddress.ResumeLayout(false);
            this.patientAddress.PerformLayout();
            this.prescriptionInfo.ResumeLayout(false);
            this.prescriptionInfo.PerformLayout();
            this.prescriptionNotes.ResumeLayout(false);
            this.prescriptionNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patientDetails;
        private System.Windows.Forms.GroupBox patientAddress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label patientAddressLn1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label patientForename;
        private System.Windows.Forms.Label patientSurname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label patientTitle;
        private System.Windows.Forms.Label patientDateOfBirth;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label patientPostCode;
        private System.Windows.Forms.Label patientTown;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label patientCounty;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label patientAddressLn2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox prescriptionInfo;
        private System.Windows.Forms.GroupBox prescriptionNotes;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label prescriptionDate;
        private System.Windows.Forms.Label prescriptionQuantity;
        private System.Windows.Forms.Label prescriptionName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox10;
    }
}