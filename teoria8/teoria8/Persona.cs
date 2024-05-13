namespace teoria7;
class Persona : IAtendible, INombrable, IComparable
{
    public string Nombre { get; set; } = "";
    public void Atender() => Console.WriteLine("Atendiendo persona");

    public int CompareTo(object? obj)
    {
        int result = 0;
        if (obj is INombrable p)
        {
            result = Nombre.CompareTo(p.Nombre);
        }
        return result;
    }

    public override string ToString()
    {
        return Nombre + " es una persona";
    }

}