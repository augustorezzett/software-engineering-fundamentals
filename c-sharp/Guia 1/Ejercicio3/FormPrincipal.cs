using System;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        Peaje peaje = new Peaje();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {
            FormRegistroResumenPeaje cargaResumen=new FormRegistroResumenPeaje();

            if (cargaResumen.ShowDialog() == DialogResult.OK)
            {
                int dia = Convert.ToInt32(cargaResumen.nudDia.Value);
                int cantidadVehiculos = Convert.ToInt32(cargaResumen.tbCantidadAutos.Text);

                peaje.RegistrarResumenDia(dia, cantidadVehiculos);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lbVer.Items.Clear();

            lbVer.Items.Add("Los días en que ingresaron más autos que el promedio en el mes:");
            int[] dias=peaje.CalcularLosDiasMayoresAlPromedio(out int cantDias);

            for (int n = 0; n < cantDias; n++)
            {
                lbVer.Items.Add($"{dias[n]} (cantidad: {peaje.VerCantidadAutosEnUnDia(dias[n])})");
            }

            lbVer.Items.Add("¿Cuál de los tercios del mes tuvo mayor movimiento?");
            int tercio = peaje.CalcularTercioDelMesMayor();
            
            lbVer.Items.Add(tercio);
            

        }
    }
}
