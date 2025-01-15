namespace Controle2
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtnom = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtprenom = new TextBox();
            label3 = new Label();
            button5 = new Button();
            label4 = new Label();
            txtchercher = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "NOM";
            // 
            // txtnom
            // 
            txtnom.Location = new Point(165, 3);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(345, 23);
            txtnom.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(345, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 5;
            label2.Text = "DEPARTEMENT";
            // 
            // txtprenom
            // 
            txtprenom.Location = new Point(165, 63);
            txtprenom.Name = "txtprenom";
            txtprenom.Size = new Size(345, 23);
            txtprenom.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "PRENOM";
            // 
            // button5
            // 
            button5.Location = new Point(211, 234);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 11;
            button5.Text = "CHERCHER";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 238);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 12;
            label4.Text = "CHERCHER PAR MATRICULE";
            // 
            // txtchercher
            // 
            txtchercher.Location = new Point(332, 234);
            txtchercher.Name = "txtchercher";
            txtchercher.Size = new Size(178, 23);
            txtchercher.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(642, 36);
            button1.Name = "button1";
            button1.Size = new Size(146, 33);
            button1.TabIndex = 14;
            button1.Text = "AJOUTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(642, 102);
            button2.Name = "button2";
            button2.Size = new Size(146, 33);
            button2.TabIndex = 15;
            button2.Text = "MODIFIER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(642, 177);
            button3.Name = "button3";
            button3.Size = new Size(146, 33);
            button3.TabIndex = 16;
            button3.Text = "SUPPRIMER";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(642, 390);
            button4.Name = "button4";
            button4.Size = new Size(146, 33);
            button4.TabIndex = 17;
            button4.Text = "EXPORTER JSON";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtchercher);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(txtprenom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(txtnom);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtnom;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtprenom;
        private Label label3;
        private Button button5;
        private Label label4;
        private TextBox txtchercher;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
