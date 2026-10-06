using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    //BindingList<Persona> personas = new BindingList<Persona>();

    List<Persona> personas = new List<Persona>();

    public FormPrincipal()
    {
        InitializeComponent();

        //listBox1.DataSource = personas;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        FormDatos formDatos = new FormDatos();

        formDatos.ShowDialog();

        bool volver = true;

        while (formDatos.DialogResult == DialogResult.OK && volver)
        {
            string nombre = formDatos.tbNombre.Text;
            string cuit = formDatos.tbCUIT.Text;

            Persona persona = null;
                        
            try
            {
                #region factoria del registro
                if (formDatos.rbFisica.Checked)
                {
                    persona = new Persona(nombre);
                }
                else if (formDatos.rbJuridica.Checked)
                {
                    persona = new PersonaJuridica(nombre, cuit);
                }
                #endregion

                if (persona != null)
                {
                    personas.Add(persona);
                    ActualizarListado();
                    volver = false;
                }
                else
                    MessageBox.Show("Seleccione un tipo de persona");
            }
            catch(FormatoNombreNoValidoException ex)
            {
                formDatos.lbMensajeNombre.Visible = true;
                formDatos.lbMensajeNombre.Text = ex.Message;
            }
            catch (FormatoCUITNoValidoException ex)
            {
                formDatos.lbMensajeCUIT.Visible = true;
                formDatos.lbMensajeCUIT.Text = ex.Message;
            }

            if(volver)
                formDatos.ShowDialog();
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        Persona persona=ltbPersonas.SelectedItem as Persona;
        if (persona != null)
        {
            personas.Remove(persona);
            ActualizarListado();
        }
    }

    public void ActualizarListado()
    {
        personas.Sort();

        ltbPersonas.Items.Clear();
        foreach (Persona p in personas)
        {
            ltbPersonas.Items.Add(p.Describir());
        }
    }
}
