namespace LAB05
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(213, 228);
            button1.Name = "button1";
            button1.Size = new Size(103, 42);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onPlusCLick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(322, 228);
            button2.Name = "button2";
            button2.Size = new Size(93, 42);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += onMinusClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(421, 228);
            button3.Name = "button3";
            button3.Size = new Size(95, 42);
            button3.TabIndex = 2;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += onMultiplyClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(522, 228);
            button4.Name = "button4";
            button4.Size = new Size(100, 42);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += onDivideClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(355, 276);
            button5.Name = "button5";
            button5.Size = new Size(127, 39);
            button5.TabIndex = 4;
            button5.Text = "Очистить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += onClearClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(145, 74);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 5;
            label1.Text = "Число 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(145, 156);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 6;
            label2.Text = "Число 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(150, 360);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 7;
            label3.Text = "Результат:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.YellowGreen;
            label4.Location = new Point(406, 360);
            label4.Name = "label4";
            label4.Size = new Size(27, 31);
            label4.TabIndex = 8;
            label4.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 27);
            textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
