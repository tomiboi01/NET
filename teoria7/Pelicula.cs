namespace teoria7;
class Pelicula: IAlquilable{

    public void SeAlquilaA(Persona p) => Console.WriteLine("Alquilando película a persona");

    public void Devolver(Persona p) => Console.WriteLine("Película devuelta por persona");


}