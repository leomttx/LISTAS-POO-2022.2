using System;
using System.Linq;
public class lista_03{
  public static void Main(string[] args){
    double[] x = Console.ReadLine().Split().Select(double.Parse).ToArray();
    double[] y = Console.ReadLine().Split().Select(double.Parse).ToArray();
    double p1 = (y[0] - x[0]);
    double a = Math.Pow(p1, 2);
    double p2 = (x[1] - y[1]);
    double b = Math.Pow(p2, 2);
    double z = (a + b);
    double r = Math.Sqrt(z);
    Console.WriteLine($"{r:f4}");
  }
}