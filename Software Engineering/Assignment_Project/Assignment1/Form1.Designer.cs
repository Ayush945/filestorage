namespace Assignment1
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
            this.drawPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.syntaxButton = new System.Windows.Forms.Button();
            this.multiLineTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstTextboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondTextboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstTextboxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secongTextboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondmultilinetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.Location = new System.Drawing.Point(713, 31);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(471, 433);
            this.drawPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(13, 408);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(119, 35);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // syntaxButton
            // 
            this.syntaxButton.Location = new System.Drawing.Point(164, 408);
            this.syntaxButton.Name = "syntaxButton";
            this.syntaxButton.Size = new System.Drawing.Size(119, 35);
            this.syntaxButton.TabIndex = 3;
            this.syntaxButton.Text = "Syntax";
            this.syntaxButton.UseVisualStyleBackColor = true;
            this.syntaxButton.Click += new System.EventHandler(this.syntaxButton_Click);
            // 
            // multiLineTextBox
            // 
            this.multiLineTextBox.Location = new System.Drawing.Point(28, 30);
            this.multiLineTextBox.Multiline = true;
            this.multiLineTextBox.Name = "multiLineTextBox";
            this.multiLineTextBox.Size = new System.Drawing.Size(313, 266);
            this.multiLineTextBox.TabIndex = 4;
            this.multiLineTextBox.TextChanged += new System.EventHandler(this.multiLineTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstTextboxToolStripMenuItem,
            this.secondTextboxToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // firstTextboxToolStripMenuItem
            // 
            this.firstTextboxToolStripMenuItem.Name = "firstTextboxToolStripMenuItem";
            this.firstTextboxToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.firstTextboxToolStripMenuItem.Text = "First Textbox";
            this.firstTextboxToolStripMenuItem.Click += new System.EventHandler(this.firstTextboxToolStripMenuItem_Click);
            // 
            // secondTextboxToolStripMenuItem
            // 
            this.secondTextboxToolStripMenuItem.Name = "secondTextboxToolStripMenuItem";
            this.secondTextboxToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.secondTextboxToolStripMenuItem.Text = "Second Textbox";
            this.secondTextboxToolStripMenuItem.Click += new System.EventHandler(this.secondTextboxToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstTextboxToolStripMenuItem1,
            this.secongTextboxToolStripMenuItem,
            this.imageToolStripMenuItem1});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // firstTextboxToolStripMenuItem1
            // 
            this.firstTextboxToolStripMenuItem1.Name = "firstTextboxToolStripMenuItem1";
            this.firstTextboxToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.firstTextboxToolStripMenuItem1.Text = "First Textbox";
            this.firstTextboxToolStripMenuItem1.Click += new System.EventHandler(this.firstTextboxToolStripMenuItem1_Click);
            // 
            // secongTextboxToolStripMenuItem
            // 
            this.secongTextboxToolStripMenuItem.Name = "secongTextboxToolStripMenuItem";
            this.secongTextboxToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.secongTextboxToolStripMenuItem.Text = "Secong Textbox";
            this.secongTextboxToolStripMenuItem.Click += new System.EventHandler(this.secongTextboxToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem1
            // 
            this.imageToolStripMenuItem1.Name = "imageToolStripMenuItem1";
            this.imageToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.imageToolStripMenuItem1.Text = "Image";
            this.imageToolStripMenuItem1.Click += new System.EventHandler(this.imageToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // secondmultilinetextBox
            // 
            this.secondmultilinetextBox.Location = new System.Drawing.Point(364, 30);
            this.secondmultilinetextBox.Multiline = true;
            this.secondmultilinetextBox.Name = "secondmultilinetextBox";
            this.secondmultilinetextBox.Size = new System.Drawing.Size(343, 265);
            this.secondmultilinetextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countdownToolStripMenuItem,
            this.spinToolStripMenuItem,
            this.freeDrawToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // countdownToolStripMenuItem
            // 
            this.countdownToolStripMenuItem.Name = "countdownToolStripMenuItem";
            this.countdownToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.countdownToolStripMenuItem.Text = "Countdown";
            this.countdownToolStripMenuItem.Click += new System.EventHandler(this.countdownToolStripMenuItem_Click);
            // 
            // spinToolStripMenuItem
            // 
            this.spinToolStripMenuItem.Name = "spinToolStripMenuItem";
            this.spinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.spinToolStripMenuItem.Text = "Spin";
            this.spinToolStripMenuItem.Click += new System.EventHandler(this.spinToolStripMenuItem_Click);
            // 
            // freeDrawToolStripMenuItem
            // 
            this.freeDrawToolStripMenuItem.Name = "freeDrawToolStripMenuItem";
            this.freeDrawToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.freeDrawToolStripMenuItem.Text = "Free Draw";
            this.freeDrawToolStripMenuItem.Click += new System.EventHandler(this.freeDrawToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondmultilinetextBox);
            this.Controls.Add(this.multiLineTextBox);
            this.Controls.Add(this.syntaxButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button syntaxButton;
        private System.Windows.Forms.TextBox multiLineTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox secondmultilinetextBox;
        private System.Windows.Forms.ToolStripMenuItem firstTextboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondTextboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstTextboxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secongTextboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeDrawToolStripMenuItem;
    }
}

