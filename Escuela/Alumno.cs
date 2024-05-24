namespace Escuela;
public class Alumno
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public List<Examen>? Examenes { get; set; }
}