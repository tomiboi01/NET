namespace teoria8;
using System.Collections;

public class Sa

{
    
    public static IEnumerable Rango(int j, int k, int p)
{
    for ( int i = j; i <= k; i+=p)
        yield return i;

}
    public static IEnumerable Potencias(int b, int k)
    {
        for (int i = 1; i <= k; i++)
            yield return (int) Math.Pow(b, i);
    }
    public static IEnumerable DivisiblesPor(IEnumerable e, int i)
    {
        foreach (int j in e){
            if (j % i == 0)
                yield return j;
        }

    }


}