namespace ej4
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
            btnConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            lbMinutos = new Label();
            nudHora = new NumericUpDown();
            nudMinuto = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).BeginInit();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(496, 35);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(154, 47);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 1;
            label1.Text = "Tiempo en H:M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 152);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 2;
            label2.Text = "Tiempo en minutos:";
            // 
            // lbMinutos
            // 
            lbMinutos.BackColor = SystemColors.ControlDark;
            lbMinutos.Location = new Point(227, 152);
            lbMinutos.Name = "lbMinutos";
            lbMinutos.Size = new Size(136, 28);
            lbMinutos.TabIndex = 3;
            // 
            // nudHora
            // 
            nudHora.Location = new Point(205, 42);
            nudHora.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            nudHora.Name = "nudHora";
            nudHora.Size = new Size(55, 34);
            nudHora.TabIndex = 4;
            // 
            // nudMinuto
            // 
            nudMinuto.Location = new Point(308, 42);
            nudMinuto.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinuto.Name = "nudMinuto";
            nudMinuto.Size = new Size(55, 34);
            nudMinuto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 44);
            label3.Name = "label3";
            label3.Size = new Size(16, 28);
            label3.TabIndex = 6;
            label3.Text = ":";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 314);
            Controls.Add(label3);
            Controls.Add(nudMinuto);
            Controls.Add(nudHora);
            Controls.Add(lbMinutos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private Label label1;
        private Label label2;
        private Label lbMinutos;
        private NumericUpDown nudHora;
        private NumericUpDown nudMinuto;
        private Label label3;
    }
}
