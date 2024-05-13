namespace teoria7;
class PeliClasica:Pelicula, IVendible
{
    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo película a persona");
}