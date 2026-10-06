namespace Ejercicio1.Models;

public class FormatoNombreNoValidoException:ApplicationException
{
    public FormatoNombreNoValidoException() : base("El nombre ingresado no cumple con el formato 'Apellido, Nombre(s)'.")
    { }

    public FormatoNombreNoValidoException(string message) : base(message)
    { }

    public FormatoNombreNoValidoException(string message, Exception inner) : base(message, inner)
    { }
}
