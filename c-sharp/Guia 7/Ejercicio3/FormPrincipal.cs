using Ejercicio3.Models;
using System;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarServicio_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpInicio.Value;
            DateTime fin = dtpFin.Value;

            ServicioDeComunicaciones servicio = new ServicioDeComunicaciones(inicio, fin);

            tbTicket.Clear();
            foreach (string linea in servicio.VerImpresionTicket())
            {
                tbTicket.Text += linea+"\r\n";
            }
        }
    }
}

