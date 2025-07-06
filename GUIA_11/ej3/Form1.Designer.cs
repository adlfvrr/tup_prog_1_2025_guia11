namespace ej3
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
            label1 = new Label();
            tbNombre = new TextBox();
            btnImprimirNombre = new Button();
            lsbInvitaciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre del invitado";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(212, 27);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(191, 34);
            tbNombre.TabIndex = 1;
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(441, 12);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(148, 64);
            btnImprimirNombre.TabIndex = 2;
            btnImprimirNombre.Text = "Imprimir nombre";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // lsbInvitaciones
            // 
            lsbInvitaciones.FormattingEnabled = true;
            lsbInvitaciones.ItemHeight = 28;
            lsbInvitaciones.Location = new Point(12, 91);
            lsbInvitaciones.Name = "lsbInvitaciones";
            lsbInvitaciones.Size = new Size(478, 172);
            lsbInvitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 304);
            Controls.Add(lsbInvitaciones);
            Controls.Add(btnImprimirNombre);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Invitaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Button btnImprimirNombre;
        private ListBox lsbInvitaciones;
    }
}
