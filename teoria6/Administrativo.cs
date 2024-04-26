namespace teoria6;
class Administrativo : Empleado
{
public Administrativo(string Nombre, int Dni, DateTime FechaDeIngreso, double SalarioBase, double Premio):base(Nombre,  Dni,  FechaDeIngreso,  SalarioBase){
    this.Premio = Premio;


}
    public double Premio{ get; set; }
    public override double Salario{ 
        get{
            return Premio + SalarioBase; 
        }
        }

    public override void AumentarSalario(){
        int años = DateTime.Today.Year - FechaDeIngreso.Year;
        if (DateTime.Today.Month < FechaDeIngreso.Month || (DateTime.Today.Month == FechaDeIngreso.Month && DateTime.Today.Day < FechaDeIngreso.Day))
            años--;
        SalarioBase += SalarioBase * años/100;
        
    }
}