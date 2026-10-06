namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
    }


    private void btnAgregar_Click(object sender, EventArgs e)
    {
        DateTime fecha = dtpFechaNacimiento.Value;
        lsbFechas.Items.Add(fecha);
    }

    private void listBox1_SelectedValueChanged(object sender, EventArgs e)
    {
        DateTime FechaNacimiento = dtpFechaNacimiento.Value;
        TimeSpan ts = DateTime.Now - FechaNacimiento;
        int años = ts.Days / 365;

        lbEdad.Text = $"{años}";
    }
}
