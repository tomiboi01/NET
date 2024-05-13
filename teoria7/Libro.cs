namespace teoria7;
class Libro:IAlquilable,IReciclable
{

    public void SeAlquilaA(Persona p) => Console.WriteLine("Alquilando libro a persona");

    public void Devolver(Persona p) => Console.WriteLine("El libro se devuelve a persona");

    public void Reciclar() => Console.WriteLine("Reciclando libro");
}