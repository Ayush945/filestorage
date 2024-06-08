namespace PracticeWindowsForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.textRegistration = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(150, 382);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 31);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(117, 124);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(287, 121);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 2;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(117, 167);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(97, 16);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone Number";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(287, 161);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 22);
            this.textPhone.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(120, 209);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(287, 209);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 22);
            this.textEmail.TabIndex = 6;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(120, 256);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(287, 256);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 22);
            this.textAddress.TabIndex = 8;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Location = new System.Drawing.Point(117, 80);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(130, 16);
            this.labelRegistration.TabIndex = 9;
            this.labelRegistration.Text = "Registration Number";
            // 
            // textRegistration
            // 
            this.textRegistration.Location = new System.Drawing.Point(287, 80);
            this.textRegistration.Name = "textRegistration";
            this.textRegistration.Size = new System.Drawing.Size(100, 22);
            this.textRegistration.TabIndex = 10;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(120, 301);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(40, 16);
            this.labelLevel.TabIndex = 11;
            this.labelLevel.Text = "Level";
            // 
            // textLevel
            // 
            this.textLevel.Location = new System.Drawing.Point(287, 301);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(100, 22);
            this.textLevel.TabIndex = 12;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(120, 341);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(41, 16);
            this.labelClass.TabIndex = 13;
            this.labelClass.Text = "Class";
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(287, 341);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(100, 22);
            this.textClass.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textRegistration);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form1";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.TextBox textRegistration;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textClass;
    }
}

