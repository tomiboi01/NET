using System.Collections;
using Microsoft.VisualBasic;

namespace teoria7;
class Perro : IAtendible, IVendible, ILavable, INombrable, IComparable
{
     public string Nombre { get; set; } ="";
    public void Atender() => Console.WriteLine("Atendiendo perro");
    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo perro a persona");

    public void Lavar() => Console.WriteLine("Lavando perro");

    public void Secar() => Console.WriteLine("Secando perro");

    public int CompareTo(object? obj){
        int result = 0;
        if (obj is INombrable p )
        {
            result = Nombre.CompareTo(p.Nombre);
        }
        return result;
    }

    public override string ToString()
    {
        return Nombre + " es un perro";
    }

}