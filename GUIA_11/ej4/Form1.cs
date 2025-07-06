namespace ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int hora = Convert.ToInt32(nudHora.Value);
            int minuto = Convert.ToInt32(nudMinuto.Value);
            int horamin = hora * 60;
            int tiempomin = horamin + minuto;
            lbMinutos.Text= tiempomin.ToString();
        }
    }
}
