using Microsoft.EntityFrameworkCore;
using Escuela;
EscuelaSqlite.Inicializar();
using var db = new EscuelaContext();

Alumno nuevo = new Alumno()
{
Nombre = "Ana",
Examenes =
[
    new () {Nota = 5, CursoId = 1},
    new () {Nota = 8, CursoId = 4}
]
}
;
db.Add(nuevo);
db.SaveChanges();

