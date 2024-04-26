
namespace teoria6;
abstract class Empleado
{
    public string Nombre{get;}
    public int Dni{get;}
    public double SalarioBase{get;protected set;}
    public abstract double Salario{get; }

    public DateTime FechaDeIngreso{get;}
    

    public abstract void AumentarSalario();

    public Empleado(string Nombre, int Dni, DateTime FechaDeIngreso ,double SalarioBase) {
        this.Nombre=Nombre;
        this.Dni=Dni;
        this.SalarioBase=SalarioBase;
        this.FechaDeIngreso=FechaDeIngreso;
    }

    public override string ToString(){
        int años = DateTime.Today.Year - FechaDeIngreso.Year;
        if (DateTime.Today.Month < FechaDeIngreso.Month || (DateTime.Today.Month == FechaDeIngreso.Month && DateTime.Today.Day < FechaDeIngreso.Day))
            años--;
        return $"{GetType().ToString().Substring(GetType().ToString().IndexOf("teoria6.")+8)} Nombre: {Nombre}, DNI: {Dni} Antigüedad: {años}\nSalario base: {SalarioBase}, Salario: {Salario}\n---------------";  

    }
}