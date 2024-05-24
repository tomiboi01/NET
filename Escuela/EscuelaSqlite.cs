namespace Escuela;
public class EscuelaSqlite
{
public static void Inicializar()
{
    using var context = new EscuelaContext();
    if (context.Database.EnsureCreated())
    {
        Console.WriteLine("Se creó base de datos");
      
    }
    else Console.WriteLine("La base de datos ya existe");
}
}