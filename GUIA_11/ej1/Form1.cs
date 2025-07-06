namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random numeroAleatorio = new Random();
            int numero = numeroAleatorio.Next(1,100);
            lbNumero.Text = $"{numero}";
        }
    }
}
