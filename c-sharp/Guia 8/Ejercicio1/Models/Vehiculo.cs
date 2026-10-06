namespace Ejercicio1.Models;

internal class Vehiculo : IExportable
{
    public string Patente { get; set; }
    public double Importe { get; set; }

    public Vehiculo()
    {
        
    }
    public Vehiculo(string patente, double importe)
    {
        if (patente.Length == 6 || patente.Length == 7)
        {
            Patente = patente;
        }
        else
        {
            throw new PatenteException();
        }
        
        Importe = importe;
    }

    public string Exportar()
    {
        return $"{Patente};{Importe}";
    }

    public void Importar(string cadena)
    {
        cadena = cadena.Trim();
        string[] separator = cadena.Split(';');
        string patente = separator[0];
        double importe = Convert.ToDouble(separator[1]);

        if (patente.Length == 6 || patente.Length == 7)
        {
            Patente = patente;
        }
        else
        {
            throw new PatenteException();
        }

        Importe = importe;
    }

    public override string ToString()
    {
        return $"Patente: {Patente}, Importe: {Importe}";
    }
}
