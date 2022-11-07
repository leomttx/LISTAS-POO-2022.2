using System;
using System.Linq;

public class lista_03{
  public static void Main(string[] args){
    int[] x = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int y = (x[0] + x[1] + Math.Abs(x[0] - x[1]))/ 2;
    int z = (y + x[2] + Math.Abs(y - x[2]))/2;
    Console.WriteLine($"{z} eh o maior");
  }
}