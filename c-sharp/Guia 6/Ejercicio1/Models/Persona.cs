

using System.Text.RegularExpressions;

namespace Ejercicio1.Models;

public class Persona:IComparable<Persona>
{
    protected string nombre;
    public string Nombre
    {
        get { return nombre; }
        set 
        {
            Match match = Regex.Match(value, @"^\s*(?<apellido>[\p{L}\s]{2,}?),\s*(?<nombres>[\p{L}\s]{2,})\s*$");
            if (match.Success==false)
            {
                throw new FormatoNombreNoValidoException();
            }
            nombre = value;
        }
    }

    public Persona(string nombre)
    {
        this.Nombre = nombre;
    }

    public int CompareTo(Persona? other)
    {
        if(other!=null)
            return nombre.CompareTo(other.nombre);
        return -1;
    }

    virtual public string Describir()
    { 
        return nombre;
    }
}
