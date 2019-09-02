using System;

class Primes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            bool isPrime = true;
            int maxDivisor = (int)Math.Sqrt(i);

            for (int j = 2; j <= maxDivisor; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("{0} is prime", i);
            }
        }
    }
}
