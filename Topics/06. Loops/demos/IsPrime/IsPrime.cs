using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");

        uint number = uint.Parse(Console.ReadLine());
        uint divisor = 2;
        uint maxDivisor = (uint)Math.Sqrt(number);
        bool isPrime = true;

        while (isPrime && (divisor <= maxDivisor))
        {
            if (number % divisor == 0)
            {
                isPrime = false;
            }

            divisor++;
        }

        Console.WriteLine("Prime? {0}", isPrime);
    }
}
