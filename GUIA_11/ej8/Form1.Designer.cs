namespace ej8
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
            lsbServicios = new ListBox();
            btnAgregar = new Button();
            lsbServiciosElegidos = new ListBox();
            btnQuitar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Servicios";
            // 
            // lsbServicios
            // 
            lsbServicios.FormattingEnabled = true;
            lsbServicios.ItemHeight = 28;
            lsbServicios.Items.AddRange(new object[] { "Cambio de aceite", "Reemplazo batería", "Reemplazar filtros de aire", "Alineación y balanceo", "Verificación de frenos", "Verificación de luces", "Reemplazo de bobina de arranque" });
            lsbServicios.Location = new Point(38, 122);
            lsbServicios.Name = "lsbServicios";
            lsbServicios.Size = new Size(329, 200);
            lsbServicios.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(373, 211);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(101, 50);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lsbServiciosElegidos
            // 
            lsbServiciosElegidos.FormattingEnabled = true;
            lsbServiciosElegidos.ItemHeight = 28;
            lsbServiciosElegidos.Location = new Point(480, 122);
            lsbServiciosElegidos.Name = "lsbServiciosElegidos";
            lsbServiciosElegidos.Size = new Size(329, 200);
            lsbServiciosElegidos.TabIndex = 3;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(693, 60);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(101, 50);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 557);
            Controls.Add(btnQuitar);
            Controls.Add(lsbServiciosElegidos);
            Controls.Add(btnAgregar);
            Controls.Add(lsbServicios);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Servicio Técnico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lsbServicios;
        private Button btnAgregar;
        private ListBox lsbServiciosElegidos;
        private Button btnQuitar;
    }
}
