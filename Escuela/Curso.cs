namespace Escuela;
public class Curso
{
    public int Id { get; set; }
    public string Titulo { get; set; } = "";
    public List<Examen>? Examenes { get; set;}
}
