namespace ej6
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
            chbOpcion1 = new CheckBox();
            chbOpcion2 = new CheckBox();
            chbOpcion3 = new CheckBox();
            btnResponder = new Button();
            label2 = new Label();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "Una variable local:";
            // 
            // chbOpcion1
            // 
            chbOpcion1.AutoSize = true;
            chbOpcion1.Location = new Point(81, 65);
            chbOpcion1.Name = "chbOpcion1";
            chbOpcion1.Size = new Size(285, 32);
            chbOpcion1.TabIndex = 1;
            chbOpcion1.Text = "No siempre debe inicializarse";
            chbOpcion1.UseVisualStyleBackColor = true;
            // 
            // chbOpcion2
            // 
            chbOpcion2.AutoSize = true;
            chbOpcion2.Location = new Point(81, 103);
            chbOpcion2.Name = "chbOpcion2";
            chbOpcion2.Size = new Size(240, 32);
            chbOpcion2.TabIndex = 2;
            chbOpcion2.Text = "Nunca debe inicializarse";
            chbOpcion2.UseVisualStyleBackColor = true;
            // 
            // chbOpcion3
            // 
            chbOpcion3.AutoSize = true;
            chbOpcion3.Location = new Point(81, 141);
            chbOpcion3.Name = "chbOpcion3";
            chbOpcion3.Size = new Size(256, 32);
            chbOpcion3.TabIndex = 3;
            chbOpcion3.Text = "Siempre debe inicializarse";
            chbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            btnResponder.Location = new Point(404, 92);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(188, 52);
            btnResponder.TabIndex = 4;
            btnResponder.Text = "Responder";
            btnResponder.UseVisualStyleBackColor = true;
            btnResponder.Click += btnResponder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 221);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 5;
            label2.Text = "Resultado:";
            // 
            // lbResultado
            // 
            lbResultado.BackColor = SystemColors.ControlDark;
            lbResultado.Location = new Point(189, 221);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(403, 207);
            lbResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 575);
            Controls.Add(lbResultado);
            Controls.Add(label2);
            Controls.Add(btnResponder);
            Controls.Add(chbOpcion3);
            Controls.Add(chbOpcion2);
            Controls.Add(chbOpcion1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Examen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chbOpcion1;
        private CheckBox chbOpcion2;
        private CheckBox chbOpcion3;
        private Button btnResponder;
        private Label label2;
        private Label lbResultado;
    }
}
