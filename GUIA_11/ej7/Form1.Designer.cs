namespace ej7
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
            groupBox1 = new GroupBox();
            rbInsuficiente = new RadioButton();
            rbBueno = new RadioButton();
            rbExcelente = new RadioButton();
            btnVotar = new Button();
            groupBox2 = new GroupBox();
            rbFull = new RadioButton();
            rbBase = new RadioButton();
            groupBox3 = new GroupBox();
            lbFull = new Label();
            lbBase = new Label();
            lbInsuficientes = new Label();
            lbBuenos = new Label();
            lbExcelentes = new Label();
            lbTotal = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbInsuficiente);
            groupBox1.Controls.Add(rbBueno);
            groupBox1.Controls.Add(rbExcelente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opinión";
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(6, 149);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(128, 32);
            rbInsuficiente.TabIndex = 2;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(6, 98);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(85, 32);
            rbBueno.TabIndex = 1;
            rbBueno.TabStop = true;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(6, 48);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(111, 32);
            rbExcelente.TabIndex = 0;
            rbExcelente.TabStop = true;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(310, 199);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(150, 47);
            btnVotar.TabIndex = 1;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbFull);
            groupBox2.Controls.Add(rbBase);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 154);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de producto";
            // 
            // rbFull
            // 
            rbFull.AutoSize = true;
            rbFull.Location = new Point(6, 106);
            rbFull.Name = "rbFull";
            rbFull.Size = new Size(72, 32);
            rbFull.TabIndex = 1;
            rbFull.TabStop = true;
            rbFull.Text = "FULL";
            rbFull.UseVisualStyleBackColor = true;
            // 
            // rbBase
            // 
            rbBase.AutoSize = true;
            rbBase.Location = new Point(6, 51);
            rbBase.Name = "rbBase";
            rbBase.Size = new Size(69, 32);
            rbBase.TabIndex = 0;
            rbBase.TabStop = true;
            rbBase.Text = "Base";
            rbBase.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbFull);
            groupBox3.Controls.Add(lbBase);
            groupBox3.Controls.Add(lbInsuficientes);
            groupBox3.Controls.Add(lbBuenos);
            groupBox3.Controls.Add(lbExcelentes);
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 405);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(483, 317);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados de la encuesta";
            // 
            // lbFull
            // 
            lbFull.BackColor = SystemColors.ControlDark;
            lbFull.Location = new Point(265, 271);
            lbFull.Name = "lbFull";
            lbFull.Size = new Size(64, 28);
            lbFull.TabIndex = 11;
            // 
            // lbBase
            // 
            lbBase.BackColor = SystemColors.ControlDark;
            lbBase.Location = new Point(265, 222);
            lbBase.Name = "lbBase";
            lbBase.Size = new Size(64, 28);
            lbBase.TabIndex = 10;
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.BackColor = SystemColors.ControlDark;
            lbInsuficientes.Location = new Point(265, 178);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(64, 28);
            lbInsuficientes.TabIndex = 9;
            // 
            // lbBuenos
            // 
            lbBuenos.BackColor = SystemColors.ControlDark;
            lbBuenos.Location = new Point(265, 135);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(64, 28);
            lbBuenos.TabIndex = 8;
            // 
            // lbExcelentes
            // 
            lbExcelentes.BackColor = SystemColors.ControlDark;
            lbExcelentes.Location = new Point(265, 91);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(64, 28);
            lbExcelentes.TabIndex = 7;
            lbExcelentes.Click += lbExcelentes_Click;
            // 
            // lbTotal
            // 
            lbTotal.BackColor = SystemColors.ControlDark;
            lbTotal.Location = new Point(265, 49);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(64, 28);
            lbTotal.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 271);
            label6.Name = "label6";
            label6.Size = new Size(169, 28);
            label6.TabIndex = 5;
            label6.Text = "Cantidad de FULL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 222);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 4;
            label5.Text = "Cantidad de Base:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 178);
            label4.Name = "label4";
            label4.Size = new Size(233, 28);
            label4.TabIndex = 3;
            label4.Text = "Cantidad de Insuficientes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 135);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Buenos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 91);
            label2.Name = "label2";
            label2.Size = new Size(216, 28);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de Excelentes:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de Votaciones:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 747);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnVotar);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Encuesta de servicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbInsuficiente;
        private RadioButton rbBueno;
        private RadioButton rbExcelente;
        private Button btnVotar;
        private GroupBox groupBox2;
        private RadioButton rbFull;
        private RadioButton rbBase;
        private GroupBox groupBox3;
        private Label lbTotal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbInsuficientes;
        private Label lbBuenos;
        private Label lbExcelentes;
        private Label lbFull;
        private Label lbBase;
    }
}
