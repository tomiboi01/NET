using System.Numerics;

foreach ( int i in Enumerable.Range(100,101).Where(n => n % 5 == 0))
{
    Console.WriteLine(i);
}

// foreach ( int i in Enumerable.Range(1,100).Where(x => x.IsPrime()))
// {
//     Console.WriteLine(i);
// }

IEnumerable<int> potencias = Enumerable.Range(0,11).Select(x=>(int)BigInteger.Pow(2,x));
foreach ( int i in potencias)
{
    Console.WriteLine(i);
}
Console.WriteLine(potencias.Sum() + " es la suma de los elementos de la secuencia potencias de 2 y el promedio es " + potencias.Average());

foreach( int i in Enumerable.Range(1,20).Select(x => x * x).Where(x=> x % 10  == 6))
{
    Console.WriteLine(i);
}
int[] vector = [1, 3, 4, 5, 9, 4, 3, 4, 5, 1, 1, 4, 9, 4, 3, 1];
vector.GroupBy(n => n).ToList()
.ForEach(obj => Console.WriteLine(obj.Key + " aparece " + obj.Count() + " veces"));