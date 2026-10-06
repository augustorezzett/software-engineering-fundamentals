namespace Ejercicio3.Models;

public class ServicioDeComunicaciones
{
    public DateTime Inicio { get; private set; }
    public DateTime Fin { get; private set; }

    public double ImporteTotal
    {
        get 
        {
            double total = 0;
            foreach (DetalleServicio dt in detalleServicios)
            {
                total+=dt.CostoTotal;
            }
            return total;
        }
    }

    List<DetalleServicio> detalleServicios=new List<DetalleServicio>();

    public TimeSpan Duracion
    {
        get
        {
            return Fin - Inicio;
        }
    }

    public ServicioDeComunicaciones(DateTime inicio, DateTime fin)
    {
        Inicio = inicio;
        Fin = fin;

        CrearDetalles();
    }

    protected void CrearDetalles()
    {
        DateTime marcador = Inicio.AddDays(0);

        while (marcador < Fin)
        {
            if (marcador.DayOfWeek == DayOfWeek.Monday)
            {
                CrearDetalle(ref marcador, new TimeSpan(5, 0, 0), 9.00);
                CrearDetalle(ref marcador, new TimeSpan(12, 0, 0), 3.01);
                CrearDetalle(ref marcador, new TimeSpan(17, 0, 0), 5.00);
                CrearDetalle(ref marcador, new TimeSpan(24, 0, 0), 9.00);
            }
            else
            {
                CrearDetalle(ref marcador, new TimeSpan(3, 0, 0), 1.00);
                CrearDetalle(ref marcador, new TimeSpan(11, 0, 0), 5.60);
                CrearDetalle(ref marcador, new TimeSpan(12, 0, 0), 5.00);
                CrearDetalle(ref marcador, new TimeSpan(14, 0, 0), 0.00);
                CrearDetalle(ref marcador, new TimeSpan(15, 0, 0), 0.00);
                CrearDetalle(ref marcador, new TimeSpan(18, 0, 0), 9.00);
                CrearDetalle(ref marcador, new TimeSpan(24, 0, 0), 1.00);
            }
        }
    }

    protected void CrearDetalle(ref DateTime marcador, TimeSpan HoraFinFranja, double precioMinuto)
    {
        DateTime finFranja = marcador.Date.Add(HoraFinFranja);
        if (marcador < finFranja)
        {
            bool correrMarcador = false;
            DateTime limite = Fin;
            if (Fin > finFranja)
            {
                limite = finFranja;
                correrMarcador = true;
            }
            DetalleServicio detalle = new DetalleServicio(marcador, limite, precioMinuto);
            detalleServicios.Add(detalle);

            marcador = finFranja;
        }
    }


    public string[] VerImpresionTicket()
    {
        string[] lineas =new string[detalleServicios.Count+1];

        int n = 0;
        foreach (DetalleServicio ds in detalleServicios)
        { 
            lineas[n++] = ds.ToString();
        }
        lineas[n] = $"Precio Total ({Duracion.TotalSeconds/60:f0} S.): ${ImporteTotal:f2}";

        return lineas;
    }
}
