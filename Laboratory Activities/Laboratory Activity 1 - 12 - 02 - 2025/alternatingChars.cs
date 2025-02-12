using System;

class AlternatingChars
{
    static void Main()
    {
        Console.Write("First character: ");
        char f_Char = Console.ReadLine()[0];

        Console.Write("Second character: ");
        char s_Char = Console.ReadLine()[0];

        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            
            Console.Write(new string('-', i));
        
            char cur_Char = (i % 2 == 0) ? f_Char : s_Char;

            Console.WriteLine(cur_Char); 
        }
    }
}