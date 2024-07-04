using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using Escuela;

List <Curso> cursos;
List<Alumno> alumnos;
List<Examen> examenes;

examenes =  [
            new(){ Alumnoid = 2, Nota = 7.5, CursoId = 1 }, 
            new(){ Alumnoid = 4, Nota = 8.5, CursoId = 5 },
            new(){ Alumnoid = 4, Nota = 6.5, CursoId = 3},
            new(){ Alumnoid = 3, Nota = 9.5, CursoId = 4},
            new(){ Alumnoid = 7, Nota = 5.5, CursoId = 3},
            new(){ Alumnoid = 2, Nota = 7.5, CursoId = 4 },
            new(){ Alumnoid = 6, Nota = 4.5, CursoId = 5},
            new(){ Alumnoid = 9, Nota = 6.5, CursoId = 1},
            new(){ Alumnoid = 6, Nota = 3.5, CursoId = 4},
            new(){ Alumnoid = 9, Nota = 5.5, CursoId = 4},
            new(){ Alumnoid = 7, Nota = 2.5, CursoId = 5},
            ];

cursos =    [
            new(){ Id = 1, Titulo = "Inglés" },
            new(){ Id = 2, Titulo = "Matematicas" },
            new(){ Id = 3, Titulo = "Historia" },
            new(){ Id = 4, Titulo = "Geografía" },
            new(){ Id = 5, Titulo = "Literatura" },
            new(){ Id = 6, Titulo = "Contabilidad" }
            ];

alumnos = [
            new(){ Id = 1, Nombre = "Juan" },
            new(){ Id = 2, Nombre = "Ana" },
            new(){ Id = 3, Nombre = "Andrés" },
            new(){ Id = 4, Nombre = "Paula" },
            new(){ Id = 5, Nombre = "Sebastián" },
            new(){ Id = 6, Nombre = "María" },
            new(){ Id = 7, Nombre = "Camila" },
            new(){ Id = 8, Nombre = "Iván" },
            new(){ Id = 9, Nombre = "Raúl" },
            ];
Console.WriteLine("Inciso a) ");
foreach(var reg in alumnos.Join(examenes, a => a.Id, e => e.Alumnoid, (a,e) => new{NombreAlumno = a.Nombre}).Distinct().OrderBy(r => r.NombreAlumno))
        Console.WriteLine(reg.NombreAlumno);

Console.WriteLine("Inciso b) ");
foreach(var reg in cursos.GroupJoin(examenes,  c => c.Id, e => e.CursoId, (c,examenes) => new{Titulo = c.Titulo, Cantidad = examenes.Count()}).Where(c=> c.Cantidad != 0))
        Console.WriteLine(reg);

Console.WriteLine("Inciso c) ");
foreach(var reg in examenes.Join(alumnos, e => e.Alumnoid, a => a.Id, (e,a) => new{Alumno = a.Nombre, Materia = e.CursoId, Nota = e.Nota}).Join(cursos, e => e.Materia, c => c.Id, (e,c) => new{Alumno = e.Alumno, Materia = c.Titulo, Nota = e.Nota}).Where(r => r.Nota >= 6).OrderBy(r => r.Alumno))
        Console.WriteLine(reg);