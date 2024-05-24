using System.Collections;
class ListaEnlazada<T> : IEnumerable{

    public Nodo<T>? Nodo{get; private set;}
    public Nodo<T>? Ultimo {get; private set;}

    public ListaEnlazada()  => Ultimo = Nodo = null;
    

    public void AgregarAdelante (T valor ){
        Nodo<T> nue = new(valor)
        {
            Proximo = Nodo
        };
        Ultimo ??= nue;
        Nodo = nue; 
    }

    public void AgregarAtras(T valor ){
        Nodo<T> nue = new(valor);
        if (Ultimo == null)
                Nodo = nue;
        else 
            Ultimo.Proximo = nue;
        
        Ultimo = nue;
    }

    public IEnumerator GetEnumerator() {
        Nodo<T>? aux = Nodo;
        if (aux == null) yield break;
        while (aux != null)
        {   yield return aux.Valor;
            aux = aux?.Proximo;
        }
        
    }
}