double[,] matriz = new double[,]{ {1,2,3},
                                  {2,3,5}
                                        };
double[][] vec = GetArregloDeArreglo(matriz);

double[][] GetArregloDeArreglo(double [,] matriz){
    double[][] vec = new double [matriz.GetLength(0)][];
    for (int i=0; i<matriz.GetLength(0); i++)
        vec[i] = new double[matriz.GetLength(1)];
    for (int j=0; j<matriz.Length; j++){
        vec[j/matriz.GetLength(1)][j%matriz.GetLength(1)] = matriz[j/matriz.GetLength(1),j%matriz.GetLength(1)];
    }   
    return vec;


}