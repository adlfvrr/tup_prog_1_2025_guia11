namespace ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            
            if (chbOpcion1.Checked || chbOpcion2.Checked)
            {
                lbResultado.Text += @"Respuesta Incorrecta:
                    No siempre se debe inicializar. Es falso.
                    Nunca debe inicializarse. Es falso
                    Siempre debe inicializarse. Es verdadera";
            }
            else if (chbOpcion3.Checked)
            {
                lbResultado.Text += @"Respuesta Correcta:
                    Siempre debe inicializarse. Es verdadera";
            }
        }
    }
}
