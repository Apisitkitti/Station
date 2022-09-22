using System;
public class first
{
    public static void Main(string[] args)
    {
        Console.Write("Please input a number: ");
        int station = int.Parse(Console.ReadLine());
        if(station == 1)
        {
            Console.WriteLine("Cost (THB): 16");
        }
        else if(station == 2)
        {
            Console.WriteLine("Cost (THB): 23");
        }
        else if(station == 3)
        {
            Console.WriteLine("Cost (THB): 26");
        }
        else if(station == 4)
        {
            Console.WriteLine("Cost (THB): 30");
        }
        else if(station == 5)
        {
            Console.WriteLine("Cost (THB): 33");
        }
        else if(station == 6)
        {
            Console.WriteLine("Cost (THB): 37");
        }
        else if(station ==7)
        {
            Console.WriteLine("Cost (THB): 40");
        }
        else if(station>=8 && station<=15)
        {
            Console.WriteLine("Cost (THB): 44");
        }
        else if(station >15)
        {
            Console.WriteLine("Cost (THB): 59");
        }
    }
}
