namespace PracticeWindowsForm
{
    partial class Form8
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
            this.penColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorOfPen = new System.Windows.Forms.Button();
            this.penThickness = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // penColor
            // 
            this.penColor.Location = new System.Drawing.Point(53, 28);
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(108, 40);
            this.penColor.TabIndex = 0;
            this.penColor.Text = "Pen Color";
            this.penColor.UseVisualStyleBackColor = true;
            this.penColor.Click += new System.EventHandler(this.penColor_Click);
            // 
            // colorOfPen
            // 
            this.colorOfPen.Location = new System.Drawing.Point(230, 28);
            this.colorOfPen.Name = "colorOfPen";
            this.colorOfPen.Size = new System.Drawing.Size(108, 40);
            this.colorOfPen.TabIndex = 1;
            this.colorOfPen.Text = "Color Of Pen";
            this.colorOfPen.UseVisualStyleBackColor = true;
            // 
            // penThickness
            // 
            this.penThickness.FormattingEnabled = true;
            this.penThickness.Location = new System.Drawing.Point(623, 28);
            this.penThickness.Name = "penThickness";
            this.penThickness.Size = new System.Drawing.Size(121, 24);
            this.penThickness.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(53, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 267);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(395, 28);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(108, 40);
            this.canvas.TabIndex = 4;
            this.canvas.Text = "Canvas Color";
            this.canvas.UseVisualStyleBackColor = true;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(395, 105);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(108, 40);
            this.circle.TabIndex = 1;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(230, 105);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(108, 40);
            this.rectangle.TabIndex = 2;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(53, 105);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(108, 40);
            this.square.TabIndex = 3;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(623, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.square);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.penThickness);
            this.Controls.Add(this.colorOfPen);
            this.Controls.Add(this.penColor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form8";
            this.Text = "Form8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button penColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorOfPen;
        private System.Windows.Forms.ComboBox penThickness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button canvas;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}