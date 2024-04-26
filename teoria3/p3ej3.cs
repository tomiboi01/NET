// ej3

double[,] m = new double[,] {{Math.PI,1.55,1.6},
                            {2.5, 2.5, 2.5},
};
            
// ImprimirMatriz(m);
ImprimirMatriz(m,"0.00");


void ImprimirMatriz(double[,] matriz, string formatString){
    for(int i=0; i< 2; i++){
        for(int j=0; j< 3; j++){
            Console.Write ($"{matriz[i,j]}:{formatString}");
        }
        Console.WriteLine("");
    }

}