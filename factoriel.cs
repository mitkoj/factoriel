using System;

class CalculateNK
{
    static void Main()
    {
            Console.Write("Positive int < 100: ");
            byte n = byte.Parse(Console.ReadLine());
            Console.Write("Positive int < N: ");
            byte k = byte.Parse(Console.ReadLine());
            k++;

            double answer = 1;
            for (byte i = k; i <= n; i++)
            {
                answer *= i;
            }
            Console.WriteLine("The answer is: " + answer);
    }
}
