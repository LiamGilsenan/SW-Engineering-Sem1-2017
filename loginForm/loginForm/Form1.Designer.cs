namespace loginForm
{
    partial class Form1
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
            this.login_L_lbl = new System.Windows.Forms.Label();
            this.userName_L_lbl = new System.Windows.Forms.Label();
            this.password_L_lbl = new System.Windows.Forms.Label();
            this.userName_L_tb = new System.Windows.Forms.TextBox();
            this.password_L_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_L_lbl
            // 
            this.login_L_lbl.AutoSize = true;
            this.login_L_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_L_lbl.Location = new System.Drawing.Point(193, 35);
            this.login_L_lbl.Name = "login_L_lbl";
            this.login_L_lbl.Size = new System.Drawing.Size(65, 26);
            this.login_L_lbl.TabIndex = 0;
            this.login_L_lbl.Text = "Login";
            // 
            // userName_L_lbl
            // 
            this.userName_L_lbl.AutoSize = true;
            this.userName_L_lbl.Location = new System.Drawing.Point(62, 127);
            this.userName_L_lbl.Name = "userName_L_lbl";
            this.userName_L_lbl.Size = new System.Drawing.Size(60, 13);
            this.userName_L_lbl.TabIndex = 1;
            this.userName_L_lbl.Text = "User Name";
            // 
            // password_L_lbl
            // 
            this.password_L_lbl.AutoSize = true;
            this.password_L_lbl.Location = new System.Drawing.Point(62, 193);
            this.password_L_lbl.Name = "password_L_lbl";
            this.password_L_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_L_lbl.TabIndex = 2;
            this.password_L_lbl.Text = "Password";
            // 
            // userName_L_tb
            // 
            this.userName_L_tb.Location = new System.Drawing.Point(144, 124);
            this.userName_L_tb.Name = "userName_L_tb";
            this.userName_L_tb.Size = new System.Drawing.Size(213, 20);
            this.userName_L_tb.TabIndex = 3;
            this.userName_L_tb.TextChanged += new System.EventHandler(this.userName_L_tb_TextChanged);
            // 
            // password_L_tb
            // 
            this.password_L_tb.Location = new System.Drawing.Point(144, 190);
            this.password_L_tb.Name = "password_L_tb";
            this.password_L_tb.Size = new System.Drawing.Size(213, 20);
            this.password_L_tb.TabIndex = 4;
            this.password_L_tb.TextChanged += new System.EventHandler(this.password_L_tb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 349);
            this.Controls.Add(this.password_L_tb);
            this.Controls.Add(this.userName_L_tb);
            this.Controls.Add(this.password_L_lbl);
            this.Controls.Add(this.userName_L_lbl);
            this.Controls.Add(this.login_L_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_L_lbl;
        private System.Windows.Forms.Label userName_L_lbl;
        private System.Windows.Forms.Label password_L_lbl;
        private System.Windows.Forms.TextBox userName_L_tb;
        private System.Windows.Forms.TextBox password_L_tb;
    }
}

