using Microsoft.EntityFrameworkCore;
using Escuela;
EscuelaSqlite.Inicializar();
using var db = new EscuelaContext();

Curso curso = new()
{
    Titulo = "Matemáticas",
};

Alumno tomas = new()
{
    Nombre = "Ricardo",
};

db.Add(tomas);
db.SaveChanges();
Examen examen = new()
{
    Alumnoid = tomas.Id,
    Nota = 7.5,
    CursoId = curso.Id,
};
db.Add (examen);
db.SaveChanges();

