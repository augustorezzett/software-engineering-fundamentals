using System.ComponentModel;

namespace Ejercicio3.Models;

public class DetalleServicio
{
    public DateTime Inicio { get; set; }
    public DateTime Fin { get; set; }

    public int Unidades
    {
        get
        {
            return Convert.ToInt32(Math.Floor((Fin - Inicio).TotalSeconds / 60));
        }
    }

    public double CostoUnitario { get;set; }

    public DetalleServicio(DateTime inicio, DateTime fin, double costoUnitario)
    {
        Inicio = inicio;
        Fin = fin;
        CostoUnitario = costoUnitario;
    }

    public double CostoTotal
    {
        get 
        {
            return Unidades * CostoUnitario;
        }
    }

    public override string ToString()
    {
        return @$"Intervalo: {Inicio:ddd hh:mm}    ${CostoTotal:f2}
    Franja horaria:{Inicio:dd hh:mm}-{Fin:hh:mm}(Udx$:{Unidades}x${CostoUnitario:f2})";
    }
}
