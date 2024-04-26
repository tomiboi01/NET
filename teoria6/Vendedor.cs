namespace teoria6;
class Vendedor:Empleado{
    public Vendedor(string Nombre, int Dni, DateTime FechaDeIngreso, double SalarioBase, double Comision) : base(Nombre, Dni, FechaDeIngreso, SalarioBase)
    {
        this.Comision = Comision;
    }

    public double Comision{get;set;}
    public override double Salario{ 
        get{
            return Comision + SalarioBase; 
        }
        }

    public override void AumentarSalario(){
        int años = DateTime.Today.Year - FechaDeIngreso.Year;
        if (DateTime.Today.Month < FechaDeIngreso.Month || (DateTime.Today.Month == FechaDeIngreso.Month && DateTime.Today.Day < FechaDeIngreso.Day))
            años--;
        if (años < 10)
            SalarioBase += SalarioBase * 0.05;
        else 
            SalarioBase += SalarioBase * 0.1;
        
    }
}