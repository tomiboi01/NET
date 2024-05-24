class Nodo<T>(T valor)
{
    public T Valor { get; private set; } = valor;
    public Nodo<T>? Proximo { get; set; } = null;
}