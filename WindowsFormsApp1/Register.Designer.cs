namespace WindowsFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frstName = new System.Windows.Forms.TextBox();
            this.lstName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.usrName = new System.Windows.Forms.TextBox();
            this.pswd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pswdConfirm = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.exitReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // frstName
            // 
            this.frstName.Location = new System.Drawing.Point(12, 25);
            this.frstName.Name = "frstName";
            this.frstName.Size = new System.Drawing.Size(178, 20);
            this.frstName.TabIndex = 0;
            // 
            // lstName
            // 
            this.lstName.Location = new System.Drawing.Point(193, 25);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(175, 20);
            this.lstName.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 64);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(356, 20);
            this.email.TabIndex = 2;
            // 
            // usrName
            // 
            this.usrName.Location = new System.Drawing.Point(12, 120);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(356, 20);
            this.usrName.TabIndex = 3;
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(12, 159);
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(178, 20);
            this.pswd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm your Password";
            // 
            // pswdConfirm
            // 
            this.pswdConfirm.Location = new System.Drawing.Point(193, 159);
            this.pswdConfirm.Name = "pswdConfirm";
            this.pswdConfirm.Size = new System.Drawing.Size(175, 20);
            this.pswdConfirm.TabIndex = 5;
            // 
            // regButton
            // 
            this.regButton.ForeColor = System.Drawing.Color.Black;
            this.regButton.Location = new System.Drawing.Point(213, 198);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(155, 23);
            this.regButton.TabIndex = 6;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // exitReg
            // 
            this.exitReg.ForeColor = System.Drawing.Color.Black;
            this.exitReg.Location = new System.Drawing.Point(52, 198);
            this.exitReg.Name = "exitReg";
            this.exitReg.Size = new System.Drawing.Size(155, 23);
            this.exitReg.TabIndex = 12;
            this.exitReg.Text = "Exit";
            this.exitReg.UseVisualStyleBackColor = true;
            this.exitReg.Click += new System.EventHandler(this.exitReg_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(377, 233);
            this.Controls.Add(this.exitReg);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pswdConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.usrName);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.frstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frstName;
        private System.Windows.Forms.TextBox lstName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox usrName;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pswdConfirm;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button exitReg;
    }
}