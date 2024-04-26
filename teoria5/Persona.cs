class Persona{

    public string Nombre { get; set; }

    public char Sexo { get; set; }

    public int Dni { get; set; }

    public DateTime FechaNacimiento{ get; set; }

    public int Edad {
        get{
            int años;
            años = DateTime.Today.Year - FechaNacimiento.Year;
            if (DateTime.Today.Month > FechaNacimiento.Month || DateTime.Today.Month == FechaNacimiento.Month && DateTime.Today.Day >= FechaNacimiento.Day)
                return años;
            return años-1;
        }
    
    
    }   

    public object this[int index]{

        get
        {
            switch (index) 
            {
                case 0: return Nombre;
                case 1: return Sexo;
                case 2: return Dni;
                case 3: return FechaNacimiento;
                case 4: return Edad;
            }
            throw new ArgumentOutOfRangeException();
        }
        set{
            switch (index) 
            {
                case 0:  Nombre = (string) value;
                break;
                case 1: Sexo = (char) value;
                break;
                case 2: Dni = (int) value;
                break;
                case 3: FechaNacimiento = (DateTime) value;
                break;
            }
            throw new ArgumentOutOfRangeException();
        }
    }
       
}