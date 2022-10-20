using System;

namespace jumper;

public class Visual
{
    
    private int errors;
    public void parachute(int errors)
    {
        this.errors = errors;

        Console.WriteLine();

        if (errors == 0)
        {
            Console.WriteLine(" ___ ");
            Console.WriteLine("/___\\");
            Console.WriteLine("\\   /");
            Console.WriteLine(" \\ /");
            Console.WriteLine("  0");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
        }

        else if (errors == 1)
        {
            Console.WriteLine("/___\\");
            Console.WriteLine("\\   /");
            Console.WriteLine(" \\ /");
            Console.WriteLine("  0");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
        }

        else if (errors == 2)
        {
            Console.WriteLine("\\   /");
            Console.WriteLine(" \\ /");
            Console.WriteLine("  0");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
        }

        else if (errors == 3)
        {
            Console.WriteLine(" \\ /");
            Console.WriteLine("  0");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
        }

        else if (errors == 4)
        {
            Console.WriteLine("  x");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
        }

        Console.WriteLine();
        
    }
}