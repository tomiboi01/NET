public static class IntExtensions
{

    public static bool IsPrime(this int n){
        if (n <= 1)
            return false;
        if (n % 2 == 0)
            return n == 2;
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) 
                return false;
        }
        return true;

    }
}