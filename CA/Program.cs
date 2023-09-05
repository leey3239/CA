using System;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        picture();
        Console.WriteLine(FtoC(100));
        Console.WriteLine(CtoF(32));
        Console.WriteLine("Cost: £" + CarpetCost(7, 6, 17));
        Console.WriteLine(Balls(0.075, 1, 0.5));
    }
    public static void picture()
    {
        Console.WriteLine("*******\n*     *\n*  0  *\n* /|" + @"\" + " *\n* / " + @"\" + " *\n*******");
    }
    public static double FtoC(double Fahr)
    {
        return (Fahr - 32) / 1.8;
    }
    public static double CtoF(double Celc)  
    {
        return Celc * 1.8 + 32;
    }
    public static double CarpetCost(double w, double l, double p)
    {
        return ((p + 3) * w * l + (w * 2 + l * 2) + 50);
    }
    public static double Balls(double radBalls, double radPit, double h)
    {
        double volBalls = Math.PI * (4d / 3d) * radBalls * radBalls;
        double volPit = Math.PI * radPit * radPit * h;

        return Math.Ceiling(volPit / volBalls);
    }
}