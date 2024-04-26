Console.WriteLine(Decodificar(Codificar("HOLA MUNDO", new int[] {5,3,9,7}), new int[] {5,3,9,7})) ;

string Codificar(string s, int[]clave){

    char[] letras = new char[28];
    char l = 'A';
    for (int i=0; i < 15; i++){
        letras[i] = l;
        l++;  
    }
    letras[14] = 'Ñ';
    l = 'O';
    for (int i=15; i < 27; i++){
        letras[i] = l;
        l++;  
    }
    letras[27] = ' ';

    Queue<int> cola = new Queue<int>();

    foreach(int i in clave)
        cola.Enqueue(i);

    string returnValue = "";
    foreach(char c in s){
        int aux;
        if (c == ' ')
            aux = 28;
        else 
        if (c == 'Ñ')
            aux = 15;
        else     
            aux=  c % 64;
        if (c > 'N')
            aux++;

        int digito = cola.Dequeue();
        aux += digito;
        cola.Enqueue(digito);

        if (aux > 28)
            aux-= 28;

        returnValue += letras[aux-1];

    }
    return returnValue;

}

string Decodificar (string s, int[]clave){
    string returnValue = "";

    char[] letras = new char[28];
    char l = 'A';
    for (int i=0; i < 15; i++){
        letras[i] = l;
        l++;  
    }

    letras[14] = 'Ñ';

    l = 'O';
    for (int i=15; i < 27; i++){
        letras[i] = l;
        l++;  
    }
    letras[27] = ' ';

    Queue<int> cola = new Queue<int>();

    foreach(int i in clave)
        cola.Enqueue(i);

    foreach (char c in s){
        int index; int n;
        for (index = 1; index < 29; index++)
            if (letras[index-1] == c)
                break;


        n = cola.Dequeue();

        index -= n;

        if (index <= 0)
            index += 28;

        cola.Enqueue(n);

        returnValue += letras[index-1];

    }
    return returnValue;
}

