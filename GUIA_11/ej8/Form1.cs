namespace ej8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lsbServicios.SelectedIndex != -1)
            {
                lsbServiciosElegidos.Items.Add(lsbServicios.SelectedItem.ToString());
                lsbServicios.Items.Remove(lsbServicios.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un servicio.");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(lsbServiciosElegidos.SelectedIndex != -1)
            {
                lsbServicios.Items.Add(lsbServiciosElegidos.SelectedItem.ToString());
                lsbServiciosElegidos.Items.Remove(lsbServiciosElegidos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Elija un objeto a quitar");
            }
        }
    }
}
