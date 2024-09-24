using System;

namespace Calculadora
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
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            labelSeperator = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(60, 60, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(38, 351);
            button1.Name = "button1";
            button1.Size = new Size(77, 67);
            button1.TabIndex = 0;
            button1.Text = "AC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += fullClear_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(60, 60, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Roboto", 44F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(23, 221);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(383, 71);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(60, 60, 60);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 25.8000011F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(329, 351);
            button4.Name = "button4";
            button4.Size = new Size(77, 67);
            button4.TabIndex = 4;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = false;
            button4.Click += operation_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(60, 60, 60);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Roboto", 25.8000011F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(329, 439);
            button5.Name = "button5";
            button5.Size = new Size(77, 67);
            button5.TabIndex = 8;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = false;
            button5.Click += operation_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(60, 60, 60);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Roboto", 25.8000011F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(204, 439);
            button6.Name = "button6";
            button6.Size = new Size(77, 67);
            button6.TabIndex = 7;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = false;
            button6.Click += anyButton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(60, 60, 60);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Roboto", 25.8000011F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(121, 439);
            button7.Name = "button7";
            button7.Size = new Size(77, 67);
            button7.TabIndex = 6;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = false;
            button7.Click += anyButton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(60, 60, 60);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Roboto", 25.8000011F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(38, 439);
            button8.Name = "button8";
            button8.Size = new Size(77, 67);
            button8.TabIndex = 5;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = false;
            button8.Click += anyButton_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(60, 60, 60);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Roboto", 25.8000011F);
            button9.ForeColor = Color.White;
            button9.Location = new Point(329, 528);
            button9.Name = "button9";
            button9.Size = new Size(77, 67);
            button9.TabIndex = 12;
            button9.Text = "x";
            button9.UseVisualStyleBackColor = false;
            button9.Click += operation_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(60, 60, 60);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Roboto", 25.8000011F);
            button10.ForeColor = Color.White;
            button10.Location = new Point(204, 528);
            button10.Name = "button10";
            button10.Size = new Size(77, 67);
            button10.TabIndex = 11;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            button10.Click += anyButton_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(60, 60, 60);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Roboto", 25.8000011F);
            button11.ForeColor = Color.White;
            button11.Location = new Point(121, 528);
            button11.Name = "button11";
            button11.Size = new Size(77, 67);
            button11.TabIndex = 10;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            button11.Click += anyButton_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(60, 60, 60);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Roboto", 25.8000011F);
            button12.ForeColor = Color.White;
            button12.Location = new Point(38, 528);
            button12.Name = "button12";
            button12.Size = new Size(77, 67);
            button12.TabIndex = 9;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = false;
            button12.Click += anyButton_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(60, 60, 60);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Roboto", 25.8000011F);
            button13.ForeColor = Color.White;
            button13.Location = new Point(329, 616);
            button13.Name = "button13";
            button13.Size = new Size(77, 67);
            button13.TabIndex = 16;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = false;
            button13.Click += operation_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(60, 60, 60);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Roboto", 25.8000011F);
            button14.ForeColor = Color.White;
            button14.Location = new Point(204, 616);
            button14.Name = "button14";
            button14.Size = new Size(77, 67);
            button14.TabIndex = 15;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = false;
            button14.Click += anyButton_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(60, 60, 60);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Roboto", 25.8000011F);
            button15.ForeColor = Color.White;
            button15.Location = new Point(121, 616);
            button15.Name = "button15";
            button15.Size = new Size(77, 67);
            button15.TabIndex = 14;
            button15.Text = "8";
            button15.UseVisualStyleBackColor = false;
            button15.Click += anyButton_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(60, 60, 60);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Roboto", 25.8000011F);
            button16.ForeColor = Color.White;
            button16.Location = new Point(38, 616);
            button16.Name = "button16";
            button16.Size = new Size(77, 67);
            button16.TabIndex = 13;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = false;
            button16.Click += anyButton_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Cornsilk;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Roboto", 25.8000011F);
            button17.ForeColor = Color.Black;
            button17.Location = new Point(298, 709);
            button17.Name = "button17";
            button17.Size = new Size(135, 123);
            button17.TabIndex = 20;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;
            button17.Click += equals_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(60, 60, 60);
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Roboto", 25.8000011F);
            button18.ForeColor = Color.White;
            button18.Location = new Point(204, 720);
            button18.Name = "button18";
            button18.Size = new Size(77, 67);
            button18.TabIndex = 19;
            button18.Text = ",";
            button18.UseVisualStyleBackColor = false;
            button18.Click += anyButton_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(60, 60, 60);
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Roboto", 25.8000011F);
            button19.ForeColor = Color.White;
            button19.Location = new Point(121, 720);
            button19.Name = "button19";
            button19.Size = new Size(77, 67);
            button19.TabIndex = 18;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = false;
            button19.Click += anyButton_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(60, 60, 60);
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Roboto", 25.8000011F);
            button20.ForeColor = Color.White;
            button20.Location = new Point(204, 350);
            button20.Name = "button20";
            button20.Size = new Size(77, 67);
            button20.TabIndex = 17;
            button20.Text = "<";
            button20.UseVisualStyleBackColor = false;
            button20.Click += clear_Click;
            // 
            // labelSeperator
            // 
            labelSeperator.BorderStyle = BorderStyle.Fixed3D;
            labelSeperator.ForeColor = SystemColors.ButtonFace;
            labelSeperator.Location = new Point(-1, 327);
            labelSeperator.Name = "labelSeperator";
            labelSeperator.Size = new Size(716, 1);
            labelSeperator.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(298, 327);
            label1.Name = "label1";
            label1.Size = new Size(1, 505);
            label1.TabIndex = 21;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(298, 709);
            label2.Name = "label2";
            label2.Size = new Size(142, 1);
            label2.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(60, 60, 60);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Roboto", 18F);
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(23, 178);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(383, 29);
            textBox2.TabIndex = 23;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(60, 60, 60);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto", 25.8000011F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(38, 720);
            button3.Name = "button3";
            button3.Size = new Size(77, 67);
            button3.TabIndex = 24;
            button3.Text = "00";
            button3.UseVisualStyleBackColor = false;
            button3.Click += anyButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(427, 832);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelSeperator);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Button button1;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Label labelSeperator;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
    }
}
