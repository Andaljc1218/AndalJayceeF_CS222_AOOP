using System;

public class FinalTotal
{
    public static void Main()
    {
        int total = 10;

        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
                total += num * num;
            }
            else
            {
                Console.WriteLine("The number is odd.");
                total += num * num * num;
            }
        }
        
        else if (num < 0)
        {
            Console.Write("Enter another integer: ");
            int exponent = int.Parse(Console.ReadLine());

            total += (int)Math.Pow(num, exponent);
        }
        
        else
        {
            Console.WriteLine("Nothing happened.");
            return;
        }

        Console.WriteLine($"{total}");
    }
}
