public class Persona{
    private string nombre;
    private int documento;
    private int edad;
    
    public Persona(string nombre, int edad, int documento){
        this.nombre = nombre;
        this.edad = edad;
        this.documento = documento;
    } 
    public bool EsMayorQue(Persona p){
        if (this.edad > p.edad)
            return true;
        return false;
    }

    public string toString(){
        return documento + "     " + nombre + "     " + edad;
    }

}