﻿namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(65, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 39);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Nilai 1 :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 69);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Nilai 2 :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 98);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Nilai 3 :";
            // 
            // button1
            // 
            button1.Location = new Point(25, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 73);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(106, 229);
            button2.Name = "button2";
            button2.Size = new Size(75, 73);
            button2.TabIndex = 7;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(25, 308);
            button3.Name = "button3";
            button3.Size = new Size(75, 73);
            button3.TabIndex = 8;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(106, 308);
            button4.Name = "button4";
            button4.Size = new Size(75, 73);
            button4.TabIndex = 9;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(187, 229);
            button5.Name = "button5";
            button5.Size = new Size(75, 152);
            button5.TabIndex = 10;
            button5.Text = "C";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(291, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 416);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}