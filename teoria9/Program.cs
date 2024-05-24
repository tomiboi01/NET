var regla1 = new ReglaValidacion<Persona>(p => p.Nombre != "", "Falta el nombre");
var regla2 = new ReglaValidacion<Persona>(p => p.Edad <= 35, "Edad excedida");
var regla3 = new ReglaValidacion<Persona>(p => p.Edad >= 18, "Menor de edad");
var validadorPersona = new Validador<Persona>()
.AgregarRegla(regla1)
.AgregarRegla(regla2)
.AgregarRegla(regla3);
var pedro = new Persona { Nombre = "Pedro", Edad = 17 };



var ana = new Persona { Nombre = "", Edad = 16 };
var maria = new Persona { Nombre = "María", Edad = 44 };
var jose = new Persona { Nombre = "José", Edad = 30 };
Validar(pedro, validadorPersona);
Validar(ana, validadorPersona);
Validar(maria, validadorPersona);
Validar(jose, validadorPersona);
void Validar(Persona p, Validador<Persona> validadorPersona)
{
    List<string> listaErrores;
    bool esValido = validadorPersona.Validar(p, out listaErrores);
    Console.WriteLine($"Validando a {p} ==> {esValido}");
    listaErrores.ForEach(st => System.Console.WriteLine(" * " + st));
}



// static T[] CrearArreglo<T> (params T[] elementos) => elementos.ToArray();

// static T GetNuevoObjetoDelMismoTipo<T> (T elem) where T : new() => new();

//  static void Set<T> (T[] v, T a, int pos ) => v[pos] = a;

//  static void Imprimir<T> (T[] v) {
//     foreach (T elem in  v)
//         Console.Write(elem + " ");
//     Console.WriteLine("");
//  }

internal class Persona
{
    public string Nombre { get; set; } = "";
    public int Edad { get; set; }

    public override string ToString(){
        return $"{Nombre} de {Edad} años";
    }
}