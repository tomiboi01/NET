using System.Runtime;

public class Matriz2{

    double[,] matriz;
    public double[] DiagonalPrincipal{
        get
        {
            if (matriz.GetLength(0) != matriz.GetLength(1))
                throw new Exception("La matriz no es cuadrada");
            double[] v = new double[matriz.GetLength(0)];
            for(int i= 0; i<matriz.GetLength(0); i++)
                v[i] = matriz[i,i];
            return v;
        }

    }

    public double[] DiagonalSecundaria{
        get
        {
             if (matriz.GetLength(0) != matriz.GetLength(1))
            throw new Exception("La matriz no es cuadrada");
            double[] v = new double[matriz.GetLength(0)];
            for(int i= 0; i<matriz.GetLength(0); i++)
                for (int j=matriz.GetLength(1)-1; j<=0; j--)
                    v[i] = matriz[i,j];
            return v;
        }
    }

    public Matriz2(int filas, int columnas){
        double[,] matriz = new double[filas,columnas]; 
    }
    public Matriz2(double[,] matriz){
        this.matriz = matriz;
    }
    public void SetElemento(int fila, int columna, double elemento){
        matriz[fila,columna] = elemento;
    }

    public double GetElemento(int fila, int columna){
        return matriz[fila,columna];
    }
    public void imprimir(){
        for(int i= 0; i<matriz.GetLength(0); i++){
            Console.Write("| ");
            for(int j=0; j<matriz.GetLength(1);j++)
                Console.Write(matriz[i,j] + ", ");
            Console.Write("|\r\n");
        }
    }
    public void imprimir(string formatString){
        for(int i= 0; i<matriz.GetLength(0); i++){
            Console.Write("| ");
            for(int j=0; j<matriz.GetLength(1);j++)
                Console.WriteLine($"{matriz[i,j]}{formatString}");
            Console.Write("|\r\n");
        }
    }
    public double[] GetFila(int fila){
        double[] v = new double[matriz.GetLength(1)];
        for(int i= 0; i<matriz.GetLength(1); i++)
            v[i] = matriz[fila,i];
        return v;
    }
    public double[] GetColumna(int columna){
        double[] v = new double[matriz.GetLength(0)];
        for(int i= 0; i<matriz.GetLength(1); i++)
            v[i] = matriz[i,columna];
        return v;
    }

    public double[][] getArregloDeArreglo(){
        double[][] v = new double[matriz.GetLength(0)][];
        for(int i=0; i<v.Length; i++){
            v[i] = new double[matriz.GetLength(1)];
            for(int j=0; j<matriz.GetLength(1); j++)
                v[i][j] = matriz[i,j];
        }
        return v;
    }

    public void sumarle(Matriz2 m){
        if ((m.GetFila(0).Length != matriz.GetLength(0)) ||  (m.GetFila(1).Length != matriz.GetLength(1)))
            throw new Exception("La matriz no es cuadrada");
        double[][] v = m.getArregloDeArreglo();
        for(int i = 0; i<matriz.GetLength(0); i++){
            for(int j=0; i<matriz.GetLength(1); j++)
                matriz[i,j] += v[i][j];
        }

    }
    public void restarle(Matriz2 m){
        if ((m.GetFila(0).Length != matriz.GetLength(0)) ||  (m.GetFila(1).Length != matriz.GetLength(1)))
            throw new Exception("La matriz no es cuadrada");
        for(int i = 0; i<matriz.GetLength(0); i++){
            double[] v = m.GetFila(i);
            for(int j=0; i<matriz.GetLength(1); j++)
                matriz[i,j] -= v[j];
        }
    }
    public void multiplicarPor(Matriz2 m){
        double[][] v  = m.getArregloDeArreglo();
        if (v.Length != matriz.GetLength(1))
            throw new Exception("La cantidad de columnas de la matriz debe ser igual a la cantidad de filas de la matriz mandada");
        double[,] m2 = new double[matriz.GetLength(0),v[0].Length];
        for (int n = 0; n<matriz.GetLength(0); n++)
            for (int i = 0; i<matriz.GetLength(0); i++){
                for (int j = 0; j<v[0].GetLength(0); j++){
                    m2[i,j] += matriz[i,n] * v[n][j];  

                }
        }
        matriz = new double[v.Length, v[0].Length];
        matriz = m2;

    }

    public double this [int i, int j] {
        set {
            if ((i >= 0 && i < matriz.GetLength(0)) && (j >= 0 && j < matriz.GetLength (1)))
                matriz[i,j] = value;
        }
        get {
            return matriz[i,j];
        }

    }


    
}