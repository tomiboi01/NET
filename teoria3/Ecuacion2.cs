using System.Runtime.CompilerServices;

public class Ecuacion2{
    double a;
    double b;
    double c;

    public Ecuacion2(double a, double b, double c){
        this.a = a;
        this.b = b;
        this.c = c;
    }
 public double getDiscriminante(){
    return b*b - 4*a*c;
 }

 public int getRaices(){
    double disc = getDiscriminante();
    if (disc < 0)
        return 0;
    if (disc == 0)
        return 1;
    return 2;
    
 }

 public void imprimirRaices(){
    if (getRaices()>0)
    {
        double r1 = (-b + Math.Sqrt(getDiscriminante())) / 2.0*a;
        Console.WriteLine ($"La raíz 1 es {r1:0.00}");
        if (getRaices()>1){
            double r2 =  (-b - Math.Sqrt(getDiscriminante())) / 2.0*a;
            Console.WriteLine ($"La raíz 2 es {r2:0.00}");
        }
    }
 }
}