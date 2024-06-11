namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rectangleButton = new Button();
            triangleButton = new Button();
            circleButton = new Button();
            redButton = new Button();
            blueButton = new Button();
            stopButton = new Button();
            SuspendLayout();
            // 
            // rectangleButton
            // 
            rectangleButton.Location = new Point(12, 12);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(96, 38);
            rectangleButton.TabIndex = 0;
            rectangleButton.Text = "rectangle";
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += rectangle_Click;
            // 
            // triangleButton
            // 
            triangleButton.Location = new Point(114, 12);
            triangleButton.Name = "triangleButton";
            triangleButton.Size = new Size(98, 38);
            triangleButton.TabIndex = 1;
            triangleButton.Text = "triangle";
            triangleButton.UseVisualStyleBackColor = true;
            triangleButton.Click += triangle_Click;
            // 
            // circleButton
            // 
            circleButton.Location = new Point(218, 12);
            circleButton.Name = "circleButton";
            circleButton.Size = new Size(98, 38);
            circleButton.TabIndex = 2;
            circleButton.Text = "circle";
            circleButton.UseVisualStyleBackColor = true;
            circleButton.Click += circle_Click;
            // 
            // redButton
            // 
            redButton.Location = new Point(12, 55);
            redButton.Name = "redButton";
            redButton.Size = new Size(96, 38);
            redButton.TabIndex = 3;
            redButton.Text = "red";
            redButton.UseVisualStyleBackColor = true;
            redButton.Click += red_Click;
            // 
            // blueButton
            // 
            blueButton.Location = new Point(114, 55);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(98, 38);
            blueButton.TabIndex = 4;
            blueButton.Text = "blue";
            blueButton.UseVisualStyleBackColor = true;
            blueButton.Click += blue_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stopButton);
            Controls.Add(blueButton);
            Controls.Add(redButton);
            Controls.Add(circleButton);
            Controls.Add(triangleButton);
            Controls.Add(rectangleButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button rectangleButton;
        private Button triangleButton;
        private Button circleButton;
        private Button redButton;
        private Button blueButton;
        private Button stopButton;
    }
}
