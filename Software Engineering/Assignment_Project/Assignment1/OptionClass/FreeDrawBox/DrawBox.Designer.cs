namespace Assignment1.OptionClass.FreeDrawBox
{
    partial class DrawBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.penButton = new System.Windows.Forms.Button();
            this.penColorButton = new System.Windows.Forms.Button();
            this.canvasButton = new System.Windows.Forms.Button();
            this.canvasColorButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.thicknessText = new System.Windows.Forms.TextBox();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 328);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // penButton
            // 
            this.penButton.Location = new System.Drawing.Point(25, 26);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(91, 23);
            this.penButton.TabIndex = 1;
            this.penButton.Text = "Pen Color";
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // penColorButton
            // 
            this.penColorButton.Location = new System.Drawing.Point(150, 26);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(96, 23);
            this.penColorButton.TabIndex = 2;
            this.penColorButton.Text = "Color of Pen";
            this.penColorButton.UseVisualStyleBackColor = true;
            // 
            // canvasButton
            // 
            this.canvasButton.Location = new System.Drawing.Point(276, 26);
            this.canvasButton.Name = "canvasButton";
            this.canvasButton.Size = new System.Drawing.Size(114, 23);
            this.canvasButton.TabIndex = 3;
            this.canvasButton.Text = "Canvas Color";
            this.canvasButton.UseVisualStyleBackColor = true;
            this.canvasButton.Click += new System.EventHandler(this.canvasButton_Click);
            // 
            // canvasColorButton
            // 
            this.canvasColorButton.Location = new System.Drawing.Point(411, 25);
            this.canvasColorButton.Name = "canvasColorButton";
            this.canvasColorButton.Size = new System.Drawing.Size(121, 23);
            this.canvasColorButton.TabIndex = 4;
            this.canvasColorButton.Text = "Color of Canvas";
            this.canvasColorButton.UseVisualStyleBackColor = true;
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(25, 78);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(91, 23);
            this.rectangleButton.TabIndex = 5;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(150, 78);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 6;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(276, 78);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(75, 23);
            this.triangleButton.TabIndex = 7;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(411, 78);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 23);
            this.squareButton.TabIndex = 8;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            this.squareButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.squareButton_MouseMove);
            // 
            // thicknessText
            // 
            this.thicknessText.Location = new System.Drawing.Point(552, 26);
            this.thicknessText.Name = "thicknessText";
            this.thicknessText.Size = new System.Drawing.Size(100, 22);
            this.thicknessText.TabIndex = 9;
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(552, 78);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(100, 22);
            this.sizeText.TabIndex = 10;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(708, 51);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // DrawBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.thicknessText);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.canvasColorButton);
            this.Controls.Add(this.canvasButton);
            this.Controls.Add(this.penColorButton);
            this.Controls.Add(this.penButton);
            this.Controls.Add(this.panel1);
            this.Name = "DrawBox";
            this.Text = "DrawBox";
            this.Load += new System.EventHandler(this.DrawBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.Button canvasButton;
        private System.Windows.Forms.Button canvasColorButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.TextBox thicknessText;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.Button clearButton;
    }
}