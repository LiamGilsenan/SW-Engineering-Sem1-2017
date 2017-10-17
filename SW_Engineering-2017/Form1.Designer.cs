namespace SW_Engineering_2017
{
    partial class mainForm
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
            this.newPatientPanel = new System.Windows.Forms.Panel();
            this.confirm_NP_BTN = new System.Windows.Forms.Button();
            this.cancel_NP_BTN = new System.Windows.Forms.Button();
            this.town_NP_TB = new System.Windows.Forms.TextBox();
            this.town_NP_L = new System.Windows.Forms.Label();
            this.city_NP_TB = new System.Windows.Forms.TextBox();
            this.city_NP_L = new System.Windows.Forms.Label();
            this.postcode_NP_TB = new System.Windows.Forms.TextBox();
            this.postcode_NP_L = new System.Windows.Forms.Label();
            this.address_NP_TB = new System.Windows.Forms.TextBox();
            this.address_NP_L = new System.Windows.Forms.Label();
            this.dob_NP_PCK = new System.Windows.Forms.DateTimePicker();
            this.newPatient_L = new System.Windows.Forms.Label();
            this.dob_NP_L = new System.Windows.Forms.Label();
            this.surname_NP_TB = new System.Windows.Forms.TextBox();
            this.surname_NP_L = new System.Windows.Forms.Label();
            this.firstName_NP_TB = new System.Windows.Forms.TextBox();
            this.firstName_NP_L = new System.Windows.Forms.Label();
            this.error_NP_L = new System.Windows.Forms.Label();
            this.findPatientPanel = new System.Windows.Forms.Panel();
            this.error_FP_L = new System.Windows.Forms.Label();
            this.confirm_FP_BT = new System.Windows.Forms.Button();
            this.cancel_FP_BT = new System.Windows.Forms.Button();
            this.findPatient_L = new System.Windows.Forms.Label();
            this.surname_FP_L = new System.Windows.Forms.Label();
            this.surname_FP_TB = new System.Windows.Forms.TextBox();
            this.dob_FP_L = new System.Windows.Forms.Label();
            this.dob_FP_TB = new System.Windows.Forms.DateTimePicker();
            this.address_FP_L = new System.Windows.Forms.Label();
            this.address_FP_TB = new System.Windows.Forms.TextBox();
            this.patientID_FP_TB = new System.Windows.Forms.TextBox();
            this.patientID_FP_L = new System.Windows.Forms.Label();
            this.firstName_FP_TB = new System.Windows.Forms.TextBox();
            this.firstName_FP_L = new System.Windows.Forms.Label();
            this.or_L = new System.Windows.Forms.Label();
            this.patientTable_FP_LV = new System.Windows.Forms.ListView();
            this.edit_FP_B = new System.Windows.Forms.Button();
            this.newPatientPanel.SuspendLayout();
            this.findPatientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newPatientPanel
            // 
            this.newPatientPanel.Controls.Add(this.error_NP_L);
            this.newPatientPanel.Controls.Add(this.confirm_NP_BTN);
            this.newPatientPanel.Controls.Add(this.cancel_NP_BTN);
            this.newPatientPanel.Controls.Add(this.town_NP_TB);
            this.newPatientPanel.Controls.Add(this.town_NP_L);
            this.newPatientPanel.Controls.Add(this.city_NP_TB);
            this.newPatientPanel.Controls.Add(this.city_NP_L);
            this.newPatientPanel.Controls.Add(this.postcode_NP_TB);
            this.newPatientPanel.Controls.Add(this.postcode_NP_L);
            this.newPatientPanel.Controls.Add(this.address_NP_TB);
            this.newPatientPanel.Controls.Add(this.address_NP_L);
            this.newPatientPanel.Controls.Add(this.dob_NP_PCK);
            this.newPatientPanel.Controls.Add(this.newPatient_L);
            this.newPatientPanel.Controls.Add(this.dob_NP_L);
            this.newPatientPanel.Controls.Add(this.surname_NP_TB);
            this.newPatientPanel.Controls.Add(this.surname_NP_L);
            this.newPatientPanel.Controls.Add(this.firstName_NP_TB);
            this.newPatientPanel.Controls.Add(this.firstName_NP_L);
            this.newPatientPanel.Location = new System.Drawing.Point(21, 12);
            this.newPatientPanel.Name = "newPatientPanel";
            this.newPatientPanel.Size = new System.Drawing.Size(316, 386);
            this.newPatientPanel.TabIndex = 0;
            // 
            // confirm_NP_BTN
            // 
            this.confirm_NP_BTN.Location = new System.Drawing.Point(197, 335);
            this.confirm_NP_BTN.Name = "confirm_NP_BTN";
            this.confirm_NP_BTN.Size = new System.Drawing.Size(75, 23);
            this.confirm_NP_BTN.TabIndex = 8;
            this.confirm_NP_BTN.Text = "Confirm";
            this.confirm_NP_BTN.UseVisualStyleBackColor = true;
            // 
            // cancel_NP_BTN
            // 
            this.cancel_NP_BTN.Location = new System.Drawing.Point(30, 335);
            this.cancel_NP_BTN.Name = "cancel_NP_BTN";
            this.cancel_NP_BTN.Size = new System.Drawing.Size(75, 23);
            this.cancel_NP_BTN.TabIndex = 9;
            this.cancel_NP_BTN.Text = "Cancel";
            this.cancel_NP_BTN.UseVisualStyleBackColor = true;
            // 
            // town_NP_TB
            // 
            this.town_NP_TB.Location = new System.Drawing.Point(109, 186);
            this.town_NP_TB.Name = "town_NP_TB";
            this.town_NP_TB.Size = new System.Drawing.Size(100, 22);
            this.town_NP_TB.TabIndex = 5;
            // 
            // town_NP_L
            // 
            this.town_NP_L.AutoSize = true;
            this.town_NP_L.Location = new System.Drawing.Point(29, 186);
            this.town_NP_L.Name = "town_NP_L";
            this.town_NP_L.Size = new System.Drawing.Size(42, 17);
            this.town_NP_L.TabIndex = 17;
            this.town_NP_L.Text = "Town";
            // 
            // city_NP_TB
            // 
            this.city_NP_TB.Location = new System.Drawing.Point(109, 214);
            this.city_NP_TB.Name = "city_NP_TB";
            this.city_NP_TB.Size = new System.Drawing.Size(100, 22);
            this.city_NP_TB.TabIndex = 6;
            // 
            // city_NP_L
            // 
            this.city_NP_L.AutoSize = true;
            this.city_NP_L.Location = new System.Drawing.Point(29, 214);
            this.city_NP_L.Name = "city_NP_L";
            this.city_NP_L.Size = new System.Drawing.Size(31, 17);
            this.city_NP_L.TabIndex = 13;
            this.city_NP_L.Text = "City";
            // 
            // postcode_NP_TB
            // 
            this.postcode_NP_TB.Location = new System.Drawing.Point(109, 242);
            this.postcode_NP_TB.Name = "postcode_NP_TB";
            this.postcode_NP_TB.Size = new System.Drawing.Size(100, 22);
            this.postcode_NP_TB.TabIndex = 7;
            // 
            // postcode_NP_L
            // 
            this.postcode_NP_L.AutoSize = true;
            this.postcode_NP_L.Location = new System.Drawing.Point(29, 242);
            this.postcode_NP_L.Name = "postcode_NP_L";
            this.postcode_NP_L.Size = new System.Drawing.Size(67, 17);
            this.postcode_NP_L.TabIndex = 11;
            this.postcode_NP_L.Text = "Postcode";
            // 
            // address_NP_TB
            // 
            this.address_NP_TB.Location = new System.Drawing.Point(109, 158);
            this.address_NP_TB.Name = "address_NP_TB";
            this.address_NP_TB.Size = new System.Drawing.Size(163, 22);
            this.address_NP_TB.TabIndex = 4;
            // 
            // address_NP_L
            // 
            this.address_NP_L.AutoSize = true;
            this.address_NP_L.Location = new System.Drawing.Point(29, 158);
            this.address_NP_L.Name = "address_NP_L";
            this.address_NP_L.Size = new System.Drawing.Size(60, 17);
            this.address_NP_L.TabIndex = 9;
            this.address_NP_L.Text = "Address";
            // 
            // dob_NP_PCK
            // 
            this.dob_NP_PCK.Location = new System.Drawing.Point(109, 130);
            this.dob_NP_PCK.MaxDate = new System.DateTime(2017, 10, 17, 15, 6, 31, 0);
            this.dob_NP_PCK.Name = "dob_NP_PCK";
            this.dob_NP_PCK.Size = new System.Drawing.Size(163, 22);
            this.dob_NP_PCK.TabIndex = 3;
            this.dob_NP_PCK.Value = new System.DateTime(2017, 10, 17, 0, 0, 0, 0);
            // 
            // newPatient_L
            // 
            this.newPatient_L.AutoSize = true;
            this.newPatient_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatient_L.Location = new System.Drawing.Point(29, 13);
            this.newPatient_L.Name = "newPatient_L";
            this.newPatient_L.Size = new System.Drawing.Size(143, 29);
            this.newPatient_L.TabIndex = 6;
            this.newPatient_L.Text = "New Patient";
            // 
            // dob_NP_L
            // 
            this.dob_NP_L.AutoSize = true;
            this.dob_NP_L.Location = new System.Drawing.Point(29, 130);
            this.dob_NP_L.Name = "dob_NP_L";
            this.dob_NP_L.Size = new System.Drawing.Size(38, 17);
            this.dob_NP_L.TabIndex = 4;
            this.dob_NP_L.Text = "DOB";
            // 
            // surname_NP_TB
            // 
            this.surname_NP_TB.Location = new System.Drawing.Point(109, 102);
            this.surname_NP_TB.Name = "surname_NP_TB";
            this.surname_NP_TB.Size = new System.Drawing.Size(163, 22);
            this.surname_NP_TB.TabIndex = 2;
            // 
            // surname_NP_L
            // 
            this.surname_NP_L.AutoSize = true;
            this.surname_NP_L.Location = new System.Drawing.Point(29, 102);
            this.surname_NP_L.Name = "surname_NP_L";
            this.surname_NP_L.Size = new System.Drawing.Size(65, 17);
            this.surname_NP_L.TabIndex = 2;
            this.surname_NP_L.Text = "Surname";
            // 
            // firstName_NP_TB
            // 
            this.firstName_NP_TB.Location = new System.Drawing.Point(109, 74);
            this.firstName_NP_TB.Name = "firstName_NP_TB";
            this.firstName_NP_TB.Size = new System.Drawing.Size(163, 22);
            this.firstName_NP_TB.TabIndex = 1;
            // 
            // firstName_NP_L
            // 
            this.firstName_NP_L.AutoSize = true;
            this.firstName_NP_L.Location = new System.Drawing.Point(29, 74);
            this.firstName_NP_L.Name = "firstName_NP_L";
            this.firstName_NP_L.Size = new System.Drawing.Size(76, 17);
            this.firstName_NP_L.TabIndex = 0;
            this.firstName_NP_L.Text = "First Name";
            // 
            // error_NP_L
            // 
            this.error_NP_L.AutoSize = true;
            this.error_NP_L.Location = new System.Drawing.Point(31, 287);
            this.error_NP_L.Name = "error_NP_L";
            this.error_NP_L.Size = new System.Drawing.Size(79, 17);
            this.error_NP_L.TabIndex = 18;
            this.error_NP_L.Text = "Error Label";
            // 
            // findPatientPanel
            // 
            this.findPatientPanel.Controls.Add(this.edit_FP_B);
            this.findPatientPanel.Controls.Add(this.patientTable_FP_LV);
            this.findPatientPanel.Controls.Add(this.or_L);
            this.findPatientPanel.Controls.Add(this.patientID_FP_TB);
            this.findPatientPanel.Controls.Add(this.patientID_FP_L);
            this.findPatientPanel.Controls.Add(this.error_FP_L);
            this.findPatientPanel.Controls.Add(this.confirm_FP_BT);
            this.findPatientPanel.Controls.Add(this.cancel_FP_BT);
            this.findPatientPanel.Controls.Add(this.address_FP_TB);
            this.findPatientPanel.Controls.Add(this.address_FP_L);
            this.findPatientPanel.Controls.Add(this.dob_FP_TB);
            this.findPatientPanel.Controls.Add(this.findPatient_L);
            this.findPatientPanel.Controls.Add(this.dob_FP_L);
            this.findPatientPanel.Controls.Add(this.surname_FP_TB);
            this.findPatientPanel.Controls.Add(this.surname_FP_L);
            this.findPatientPanel.Controls.Add(this.firstName_FP_TB);
            this.findPatientPanel.Controls.Add(this.firstName_FP_L);
            this.findPatientPanel.Location = new System.Drawing.Point(360, 12);
            this.findPatientPanel.Name = "findPatientPanel";
            this.findPatientPanel.Size = new System.Drawing.Size(668, 386);
            this.findPatientPanel.TabIndex = 19;
            // 
            // error_FP_L
            // 
            this.error_FP_L.AutoSize = true;
            this.error_FP_L.Location = new System.Drawing.Point(31, 287);
            this.error_FP_L.Name = "error_FP_L";
            this.error_FP_L.Size = new System.Drawing.Size(79, 17);
            this.error_FP_L.TabIndex = 18;
            this.error_FP_L.Text = "Error Label";
            // 
            // confirm_FP_BT
            // 
            this.confirm_FP_BT.Location = new System.Drawing.Point(197, 335);
            this.confirm_FP_BT.Name = "confirm_FP_BT";
            this.confirm_FP_BT.Size = new System.Drawing.Size(75, 23);
            this.confirm_FP_BT.TabIndex = 8;
            this.confirm_FP_BT.Text = "Confirm";
            this.confirm_FP_BT.UseVisualStyleBackColor = true;
            // 
            // cancel_FP_BT
            // 
            this.cancel_FP_BT.Location = new System.Drawing.Point(30, 335);
            this.cancel_FP_BT.Name = "cancel_FP_BT";
            this.cancel_FP_BT.Size = new System.Drawing.Size(75, 23);
            this.cancel_FP_BT.TabIndex = 9;
            this.cancel_FP_BT.Text = "Cancel";
            this.cancel_FP_BT.UseVisualStyleBackColor = true;
            // 
            // findPatient_L
            // 
            this.findPatient_L.AutoSize = true;
            this.findPatient_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPatient_L.Location = new System.Drawing.Point(29, 13);
            this.findPatient_L.Name = "findPatient_L";
            this.findPatient_L.Size = new System.Drawing.Size(141, 29);
            this.findPatient_L.TabIndex = 6;
            this.findPatient_L.Text = "Find Patient";
            // 
            // surname_FP_L
            // 
            this.surname_FP_L.AutoSize = true;
            this.surname_FP_L.Location = new System.Drawing.Point(10, 140);
            this.surname_FP_L.Name = "surname_FP_L";
            this.surname_FP_L.Size = new System.Drawing.Size(65, 17);
            this.surname_FP_L.TabIndex = 2;
            this.surname_FP_L.Text = "Surname";
            // 
            // surname_FP_TB
            // 
            this.surname_FP_TB.Location = new System.Drawing.Point(90, 140);
            this.surname_FP_TB.Name = "surname_FP_TB";
            this.surname_FP_TB.Size = new System.Drawing.Size(163, 22);
            this.surname_FP_TB.TabIndex = 2;
            // 
            // dob_FP_L
            // 
            this.dob_FP_L.AutoSize = true;
            this.dob_FP_L.Location = new System.Drawing.Point(10, 168);
            this.dob_FP_L.Name = "dob_FP_L";
            this.dob_FP_L.Size = new System.Drawing.Size(38, 17);
            this.dob_FP_L.TabIndex = 4;
            this.dob_FP_L.Text = "DOB";
            // 
            // dob_FP_TB
            // 
            this.dob_FP_TB.Location = new System.Drawing.Point(90, 168);
            this.dob_FP_TB.MaxDate = new System.DateTime(2017, 10, 17, 15, 6, 31, 0);
            this.dob_FP_TB.Name = "dob_FP_TB";
            this.dob_FP_TB.Size = new System.Drawing.Size(163, 22);
            this.dob_FP_TB.TabIndex = 3;
            this.dob_FP_TB.Value = new System.DateTime(2017, 10, 17, 0, 0, 0, 0);
            // 
            // address_FP_L
            // 
            this.address_FP_L.AutoSize = true;
            this.address_FP_L.Location = new System.Drawing.Point(10, 196);
            this.address_FP_L.Name = "address_FP_L";
            this.address_FP_L.Size = new System.Drawing.Size(60, 17);
            this.address_FP_L.TabIndex = 9;
            this.address_FP_L.Text = "Address";
            // 
            // address_FP_TB
            // 
            this.address_FP_TB.Location = new System.Drawing.Point(90, 196);
            this.address_FP_TB.Name = "address_FP_TB";
            this.address_FP_TB.Size = new System.Drawing.Size(163, 22);
            this.address_FP_TB.TabIndex = 4;
            // 
            // patientID_FP_TB
            // 
            this.patientID_FP_TB.Location = new System.Drawing.Point(90, 65);
            this.patientID_FP_TB.Name = "patientID_FP_TB";
            this.patientID_FP_TB.Size = new System.Drawing.Size(163, 22);
            this.patientID_FP_TB.TabIndex = 20;
            // 
            // patientID_FP_L
            // 
            this.patientID_FP_L.AutoSize = true;
            this.patientID_FP_L.Location = new System.Drawing.Point(10, 65);
            this.patientID_FP_L.Name = "patientID_FP_L";
            this.patientID_FP_L.Size = new System.Drawing.Size(69, 17);
            this.patientID_FP_L.TabIndex = 19;
            this.patientID_FP_L.Text = "Patient ID";
            // 
            // firstName_FP_TB
            // 
            this.firstName_FP_TB.Location = new System.Drawing.Point(90, 112);
            this.firstName_FP_TB.Name = "firstName_FP_TB";
            this.firstName_FP_TB.Size = new System.Drawing.Size(163, 22);
            this.firstName_FP_TB.TabIndex = 1;
            // 
            // firstName_FP_L
            // 
            this.firstName_FP_L.AutoSize = true;
            this.firstName_FP_L.Location = new System.Drawing.Point(10, 112);
            this.firstName_FP_L.Name = "firstName_FP_L";
            this.firstName_FP_L.Size = new System.Drawing.Size(76, 17);
            this.firstName_FP_L.TabIndex = 0;
            this.firstName_FP_L.Text = "First Name";
            // 
            // or_L
            // 
            this.or_L.AutoSize = true;
            this.or_L.Location = new System.Drawing.Point(127, 91);
            this.or_L.Name = "or_L";
            this.or_L.Size = new System.Drawing.Size(21, 17);
            this.or_L.TabIndex = 21;
            this.or_L.Text = "or";
            // 
            // patientTable_FP_LV
            // 
            this.patientTable_FP_LV.Location = new System.Drawing.Point(289, 13);
            this.patientTable_FP_LV.Name = "patientTable_FP_LV";
            this.patientTable_FP_LV.Size = new System.Drawing.Size(365, 299);
            this.patientTable_FP_LV.TabIndex = 22;
            this.patientTable_FP_LV.UseCompatibleStateImageBehavior = false;
            // 
            // edit_FP_B
            // 
            this.edit_FP_B.Location = new System.Drawing.Point(579, 335);
            this.edit_FP_B.Name = "edit_FP_B";
            this.edit_FP_B.Size = new System.Drawing.Size(75, 23);
            this.edit_FP_B.TabIndex = 23;
            this.edit_FP_B.Text = "Edit";
            this.edit_FP_B.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 524);
            this.Controls.Add(this.findPatientPanel);
            this.Controls.Add(this.newPatientPanel);
            this.Name = "mainForm";
            this.Text = "Surgery System";
            this.newPatientPanel.ResumeLayout(false);
            this.newPatientPanel.PerformLayout();
            this.findPatientPanel.ResumeLayout(false);
            this.findPatientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newPatientPanel;
        private System.Windows.Forms.TextBox city_NP_TB;
        private System.Windows.Forms.Label city_NP_L;
        private System.Windows.Forms.TextBox postcode_NP_TB;
        private System.Windows.Forms.Label postcode_NP_L;
        private System.Windows.Forms.TextBox address_NP_TB;
        private System.Windows.Forms.Label address_NP_L;
        private System.Windows.Forms.DateTimePicker dob_NP_PCK;
        private System.Windows.Forms.Label newPatient_L;
        private System.Windows.Forms.Label dob_NP_L;
        private System.Windows.Forms.TextBox surname_NP_TB;
        private System.Windows.Forms.Label surname_NP_L;
        private System.Windows.Forms.TextBox firstName_NP_TB;
        private System.Windows.Forms.Label firstName_NP_L;
        private System.Windows.Forms.Button confirm_NP_BTN;
        private System.Windows.Forms.Button cancel_NP_BTN;
        private System.Windows.Forms.TextBox town_NP_TB;
        private System.Windows.Forms.Label town_NP_L;
        private System.Windows.Forms.Label error_NP_L;
        private System.Windows.Forms.Panel findPatientPanel;
        private System.Windows.Forms.Button edit_FP_B;
        private System.Windows.Forms.ListView patientTable_FP_LV;
        private System.Windows.Forms.Label or_L;
        private System.Windows.Forms.TextBox patientID_FP_TB;
        private System.Windows.Forms.Label patientID_FP_L;
        private System.Windows.Forms.Label error_FP_L;
        private System.Windows.Forms.Button confirm_FP_BT;
        private System.Windows.Forms.Button cancel_FP_BT;
        private System.Windows.Forms.TextBox address_FP_TB;
        private System.Windows.Forms.Label address_FP_L;
        private System.Windows.Forms.DateTimePicker dob_FP_TB;
        private System.Windows.Forms.Label findPatient_L;
        private System.Windows.Forms.Label dob_FP_L;
        private System.Windows.Forms.TextBox surname_FP_TB;
        private System.Windows.Forms.Label surname_FP_L;
        private System.Windows.Forms.TextBox firstName_FP_TB;
        private System.Windows.Forms.Label firstName_FP_L;
    }
}

