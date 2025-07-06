namespace ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 0;
        int excelentes = 0; int buenos = 0; int insuficientes = 0;
        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked)
            {
                excelentes++;
                contador++;
            }
            else if(rbBueno.Checked)
            {
                buenos++;
                contador++;
            }
            else if (rbInsuficiente.Checked)
            {
                insuficientes++;
                contador++;
            }
                lbTotal.Text = contador.ToString();
                lbBuenos.Text = buenos.ToString();
                lbExcelentes.Text = excelentes.ToString();
                lbInsuficientes.Text = insuficientes.ToString();   
        }
    }
}
