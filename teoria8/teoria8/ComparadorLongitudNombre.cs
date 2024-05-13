using System.Collections;

class ComparadorLongitudNombre: IComparer
{
    public int Compare(object? obj1, object? obj2)
    {
        int result = 1;
        if (obj1 is INombrable nomb1 && obj2 is INombrable nomb2)
        {
            result = nomb1.Nombre.Length - nomb2.Nombre.Length;
        }
        return result;

    }
}