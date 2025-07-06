namespace ej5
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
            btnVotar = new Button();
            rbExcelente = new RadioButton();
            rbBueno = new RadioButton();
            rbInsuficiente = new RadioButton();
            label1 = new Label();
            lbTotal = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbExcelentes = new Label();
            lbBuenos = new Label();
            lbInsuficientes = new Label();
            SuspendLayout();
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(321, 107);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(140, 50);
            btnVotar.TabIndex = 0;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(78, 80);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(111, 32);
            rbExcelente.TabIndex = 1;
            rbExcelente.TabStop = true;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(78, 125);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(85, 32);
            rbBueno.TabIndex = 2;
            rbBueno.TabStop = true;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(78, 175);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(128, 32);
            rbInsuficiente.TabIndex = 3;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 260);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de votaciones:";
            // 
            // lbTotal
            // 
            lbTotal.BackColor = SystemColors.ControlDark;
            lbTotal.Location = new Point(259, 260);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(84, 28);
            lbTotal.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 311);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 6;
            label2.Text = "Excelentes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 361);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 7;
            label3.Text = "Buenos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 419);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 8;
            label4.Text = "Insuficientes:";
            // 
            // lbExcelentes
            // 
            lbExcelentes.BackColor = SystemColors.ControlDark;
            lbExcelentes.Location = new Point(258, 311);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(65, 28);
            lbExcelentes.TabIndex = 9;
            // 
            // lbBuenos
            // 
            lbBuenos.BackColor = SystemColors.ControlDark;
            lbBuenos.Location = new Point(258, 361);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(65, 28);
            lbBuenos.TabIndex = 10;
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.BackColor = SystemColors.ControlDark;
            lbInsuficientes.Location = new Point(258, 419);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(65, 28);
            lbInsuficientes.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 606);
            Controls.Add(lbInsuficientes);
            Controls.Add(lbBuenos);
            Controls.Add(lbExcelentes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbTotal);
            Controls.Add(label1);
            Controls.Add(rbInsuficiente);
            Controls.Add(rbBueno);
            Controls.Add(rbExcelente);
            Controls.Add(btnVotar);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Encuesta de servicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVotar;
        private RadioButton rbExcelente;
        private RadioButton rbBueno;
        private RadioButton rbInsuficiente;
        private Label label1;
        private Label lbTotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbExcelentes;
        private Label lbBuenos;
        private Label lbInsuficientes;
    }
}
