using Ejercicio1.Models;
using System.Numerics;
using System.Security.Cryptography;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    List<Vehiculo> vehiculos = new List<Vehiculo>();
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void Listar_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            string name = ofd.FileName;
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(name, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                //descarto la primer linea (cabecera)   
                sr.ReadLine();

                while (sr.EndOfStream != true)
                {
                    string cadena = sr.ReadLine();

                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Importar(cadena);

                    vehiculos.Add(vehiculo);
                }

            }
            catch (PatenteException pe)
            {
                MessageBox.Show(pe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            if (vehiculos.Count != 0)
            {
                foreach (Vehiculo v in vehiculos)
                {
                    txtMostrar.Text += v.ToString() + "\r\n";
                }
            }
        }
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";

        if(sfd.ShowDialog() == DialogResult.OK)
        {
            string name = sfd.FileName;
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach (Vehiculo v in vehiculos)
                {
                    string cadena = v.Exportar();
                    sw.WriteLine(cadena);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
