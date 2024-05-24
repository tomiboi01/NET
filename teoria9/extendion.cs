public static class ExtensionMetodos
    {
    public static IEnumerable<T> Intercalar<T>(this IEnumerable<T> scuencia1, IEnumerable<T> scuencia2)
    {
        IEnumerator<T> enum1 = scuencia1.GetEnumerator();

        IEnumerator<T> enum2 = scuencia2.GetEnumerator();

        bool continuar = true;
        while (continuar)
        {
            continuar = false;
            if (enum1.MoveNext())
            {
                yield return enum1.Current;
            continuar = true;
            }
            if (enum2.MoveNext())
            {
                yield return enum2.Current;
                continuar = true;
            }
        }
    }


    public static void ForEach<T>(this IEnumerable<T> secuencia, Action<T> accion){
        foreach (T elem in secuencia)
            accion(elem);

    }
}