﻿namespace ExamenUnidad2
{
    partial class frmActualizar
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(444, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 291);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(283, 282);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 27);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 125);
            label1.Name = "label1";
            label1.Size = new Size(89, 22);
            label1.TabIndex = 6;
            label1.Text = "PATERNO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 7;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(29, 23);
            label3.TabIndex = 8;
            label3.Text = "ID";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(444, 125);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 9;
            label4.Text = "MATERNO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 234);
            label5.Name = "label5";
            label5.Size = new Size(97, 22);
            label5.TabIndex = 10;
            label5.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(283, 246);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 11;
            label6.Text = "CORREO";
            // 
            // button1
            // 
            button1.Cursor = Cursors.AppStarting;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(46, 409);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 12;
            button1.Text = "CAMBIOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.AppStarting;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(238, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "BAJA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.AppStarting;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(383, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "CERRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cafe2;
            pictureBox1.Location = new Point(679, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmActualizar";
            Text = "CAMBIOS";
            Load += frmActualizar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}