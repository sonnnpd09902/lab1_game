using Lap1_Bai3;
using System;
public class Program
{
    public static int Main(string[] args)
    {
        Calculator calculator = new Calculator(3, 7);
        int resultCong = calculator.Cong();
        Console.WriteLine("Cong: " + resultCong);
        return 0;
    }
}