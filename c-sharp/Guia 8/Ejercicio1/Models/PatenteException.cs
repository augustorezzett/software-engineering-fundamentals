
namespace Ejercicio1.Models;

internal class PatenteException : ApplicationException
{
    public PatenteException():base("Patente invalida") { }
    
    public PatenteException(string msg) : base(msg) { }
    
    public PatenteException(string msg, Exception inner):base(msg, inner) { }
}
