using System;

class Factorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("n! = ");
		
        decimal factorial = 1;

        while (true)
        {
            Console.Write(n); 
            if (n == 1) 
            {
                break;
            }

            Console.Write(" * ");
            factorial *= n;
            n--;
        }

        Console.WriteLine(" = {0}", factorial);
    }
}

