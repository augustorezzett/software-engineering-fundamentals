
using System.Text.RegularExpressions;

namespace Ejercicio1.Models;

public class PersonaJuridica:Persona
{
    protected string cuit;
 
    public PersonaJuridica(string nombre, string cuit):base(nombre)
    {
        this.cuit = cuit;
        if (ValidarCUIT() == false)
        {
            throw new FormatoCUITNoValidoException();
        }

        this.cuit = cuit;
    }

    protected bool ValidarCUIT()
    {
        //Match match = Regex.Match(cuit, @"\d{11}");
        int[] p = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
        bool esValido = cuit.Length == 11;
        int n = 0;
        int acum = 0;
        while (n < 10 && esValido)
        {
            esValido &= char.IsNumber(cuit[n]);
            if (esValido)
            {
                acum += (int)char.GetNumericValue(cuit[n]) * p[n];
            }
            n++;
        }

        if (esValido == true)
        {
            int dv = 0;
            int mod = acum % 11;
            if (mod == 0) dv = 0;
            else if (mod == 1) dv = 1;
            else { dv = 11 - mod; }

            esValido &= dv == (int)char.GetNumericValue(cuit[10]);
        }
        return esValido;
    }

    override public string Describir()
    {
        return $"{nombre}  ( {cuit} )";
    }
}
