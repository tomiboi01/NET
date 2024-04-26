
Console.WriteLine(pasarABinario(67));

string pasarABinario(int n){
    Stack<int> pila = new Stack<int>();
    string st = "";
    while(n!= 0){
        pila.Push(n%2);
        n /= 2;
    }
    while (pila.Count > 0)
        st += pila.Pop();
    return st;
}