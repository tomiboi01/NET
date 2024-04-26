public class Hora{
    int horas;
    int minutos;
    double segundos;

    public Hora(int horas, int minutos, double segundos){
        this.horas = horas;
        this.minutos = minutos;
        this.segundos = segundos;
    }

    public Hora(double horas){
        this.horas = (int) horas;
        var d = horas - this.horas;
        minutos = (int) (d * 60);
        segundos = ((d*60) - minutos)*60;
    }

    public string Imprimir(){
        return $"horas {horas}, minutos {minutos} y {segundos:0.000} segundos";
    }
}