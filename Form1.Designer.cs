﻿namespace PassingData
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            returnBtn = new Button();
            globalBtn = new Button();
            referenceBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(439, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(626, 129);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 109);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 4;
            label1.Text = "Num 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 109);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 5;
            label2.Text = "Num 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 109);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 6;
            label3.Text = "Num 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(653, 109);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 7;
            label4.Text = "Answer";
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(178, 282);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(75, 26);
            returnBtn.TabIndex = 8;
            returnBtn.Text = "Return Value";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // globalBtn
            // 
            globalBtn.Location = new Point(363, 282);
            globalBtn.Name = "globalBtn";
            globalBtn.Size = new Size(75, 26);
            globalBtn.TabIndex = 9;
            globalBtn.Text = "Global Data";
            globalBtn.UseVisualStyleBackColor = true;
            globalBtn.Click += globalBtn_Click;
            // 
            // referenceBtn
            // 
            referenceBtn.Location = new Point(552, 282);
            referenceBtn.Name = "referenceBtn";
            referenceBtn.Size = new Size(90, 26);
            referenceBtn.TabIndex = 10;
            referenceBtn.Text = "Pass-by-Ref";
            referenceBtn.UseVisualStyleBackColor = true;
            referenceBtn.Click += referenceBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(referenceBtn);
            Controls.Add(globalBtn);
            Controls.Add(returnBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button returnBtn;
        private Button globalBtn;
        private Button referenceBtn;
    }
}
