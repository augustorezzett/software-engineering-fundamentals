
namespace Ejercicio3
{
    class Peaje
    {
        int[] cantidades;

        public Peaje()
        {
            cantidades = new int[31];
            for (int n = 0; n < 31; n++)
                cantidades[n] = 0;
        }

        public int VerCantidadAutosEnUnDia(int dia)
        {
            if(dia>=1 && dia<=31)
                return cantidades[dia - 1];
            return -1;
        }

        public double PromCantVehiculosDelMes
        {
            get 
            {
                int acum = 0;
                for (int n = 0; n < 31; n++)
                    acum += cantidades[n];
                return acum / 31d;
            }
        }

        public void RegistrarResumenDia(int dia, int cantidadVehiculos)
        {
            if (dia >= 1 && dia <= 31)
                cantidades[dia-1] = cantidadVehiculos;//indice=dia-1!            
        }

        public int[] CalcularLosDiasMayoresAlPromedio(out int cant)
        {
            cant = 0;
            double promedio = PromCantVehiculosDelMes;

            int[] dias = new int[31];
            for (int n = 0; n < 31; n++)
            {
                if (cantidades[n] > promedio)
                {
                    dias[cant++] = n + 1;//día!
                }
            }

            return dias;
        }

        public int CalcularTercioDelMesMayor()
        {
            int[] periodos = new int[] { 0,0,0};

            #region determino la cantidad de vehículos por cada periodo
            for (int n = 0; n < 31; n++)
            {
                if (n < 10) periodos[0] += cantidades[n];
                else if (n < 20) periodos[1] += cantidades[n];
                else periodos[2] += cantidades[n];                
            }
            #endregion

            #region busqueda del mayor indice
            int m = 0;
            for (int n = 1; n < 3; n++)
            {
                if (periodos[n] > periodos[m]) m = n;
            }
            #endregion

            int mayor =m+ 1;//mayor periodo

            //no está definido si son todos ceros o el empate.

            return mayor;
        }
    }
}
