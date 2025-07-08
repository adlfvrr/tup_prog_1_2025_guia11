namespace ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int votaciones = 0; int excelente = 0; int bueno = 0; int insuf = 0; int Base = 0; int full = 0;
        private void lbExcelentes_Click(object sender, EventArgs e)
        {

        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked)
            {
                excelente++;
            }
            else if (rbBueno.Checked)
            {
                bueno++;
            }
            else if (rbInsuficiente.Checked)
            {
                insuf++;
            }
            if (rbBase.Checked)
            {
                Base++;
            }
            else if (rbFull.Checked)
            {
                full++;
            }
            votaciones++;

            lbExcelentes.Text = excelente.ToString();
            lbBuenos.Text = bueno.ToString();
            lbInsuficientes.Text = insuf.ToString();
            lbTotal.Text = votaciones.ToString();
            lbBase.Text = Base.ToString();
            lbFull.Text = full.ToString();
        }
    }
}
