using System;

class ArithmeticOperators
{
    static void Main()
    {
                int bigNum = int.MinValue;
        int bigSum =bigNum - 1; // Integer overflow!
        Console.WriteLine(bigSum); // -294967296

        bigNum = Int32.MaxValue;
        bigNum = bigNum + 1;
        Console.WriteLine(bigNum); // -2147483648

        checked
        {
            // This will cause OverflowException
            bigSum = bigNum * 2;
        }
    }
}
