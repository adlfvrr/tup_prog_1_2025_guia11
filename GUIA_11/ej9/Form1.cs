namespace ej9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbServicios.SelectedIndex != -1)
            {
                lsbServiciosElegidos.Items.Add(cmbServicios.SelectedItem.ToString());
                cmbServicios.Items.Remove(cmbServicios.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un servicio");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(lsbServiciosElegidos.SelectedIndex != -1)
            {
                cmbServicios.Items.Add(lsbServiciosElegidos.SelectedItem.ToString());
                lsbServiciosElegidos.Items.Remove(lsbServiciosElegidos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un servicio para remover");
            }
        }
    }
}
