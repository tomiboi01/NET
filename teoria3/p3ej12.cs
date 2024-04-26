Console.WriteLine(estaBalanceado("((sdf)))"));

bool estaBalanceado(string f){
    Stack<char> aux = new Stack<char>();
    foreach(char i in f){
        if (i == '(')
            aux.Push(i);
        else 
        {
            if (i == ')')
            {
                if (aux.Count == 0)
                    return false;
                aux.Pop();
             }
        }
    }   
    return aux.Count == 0;

}