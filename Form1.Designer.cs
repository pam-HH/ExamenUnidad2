namespace ExamenUnidad2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvAgenda = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAgenda
            // 
            dataGridViewCellStyle1.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgenda.BackgroundColor = Color.FloralWhite;
            dgvAgenda.BorderStyle = BorderStyle.None;
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(12, 101);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FloralWhite;
            dgvAgenda.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvAgenda.Size = new Size(762, 337);
            dgvAgenda.TabIndex = 0;
            dgvAgenda.CellContentClick += dgvAgenda_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FloralWhite;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(134, 12);
            button2.Name = "button2";
            button2.Size = new Size(103, 29);
            button2.TabIndex = 2;
            button2.Text = "CERRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cafe2;
            pictureBox1.Location = new Point(675, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 95);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvAgenda);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAgenda;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
