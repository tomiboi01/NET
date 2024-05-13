using System.Collections;

class Rango(int j, int k, int p) : IEnumerable
{

   public IEnumerator GetEnumerator()
{
    for ( int i = j; i <= k; i+=p)
        yield return i;
}

}