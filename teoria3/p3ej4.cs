double[,] a = new double[,]{{31,3},
                            {1,2}};

double[] vec = getDiagonalSecundaria(a);
foreach(double d in vec){
    Console.WriteLine(d);
}


double[] GetDiagonalPrincipal(double[,] matriz){
    if (matriz.GetLength(1) != matriz.GetLength(0)){
        throw new ArgumentException();
    }
    double[] vec = new double[matriz.GetLength(0)];
    int j = 0;
    for (int i=0; i<matriz.GetLength(0); i++){
        vec[i] = matriz[i,j];
        j++;
    }
    return vec;

}


double[] getDiagonalSecundaria(double[,] matriz){
    if (matriz.GetLength(1) != matriz.GetLength(0)){
        throw new ArgumentException();
    }
    double[] vec = new double[matriz.GetLength(0)];
    int j = 0;
    for (int i=matriz.GetLength(0)-1; i>=0; i--){
        vec[i] = matriz[i,j];
        j++;
    }
    return vec;

}