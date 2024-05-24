static class VectorDeEnterosExtension
{
    public static void Print(this int[] vector, string leyenda)
    {
    Console.WriteLine(leyenda + string.Join(", ", vector));
    }
    public static int[] Seleccionar(this int[] v, FuncionEntera f ) 
    {
        int[] aux = new int[v.Length];
        for(int i=0; i<v.Length; i++){
            aux[i] = f(v[i]);
        }
        return aux;
    }

    public static int[] Donde(this int[] v, Predicado p)
    {
        List<int> nums = [];
        for(int i=0; i<v.Length; i++)
            if (p(v[i]))
                nums.Add(v[i]);
        return [.. nums];
    }
}