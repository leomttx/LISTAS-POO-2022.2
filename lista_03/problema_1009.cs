using System;

public class lista_03{
  
  public static void Main(string[] args){
    string texto = Console.ReadLine();
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double total = (15.0/100.0 * y);
    double t = total + x;
    Console.WriteLine($"TOTAL = R$ {t:f2}");
  }
}