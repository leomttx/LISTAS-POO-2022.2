using System;
using System.Linq;

public class lista_04{
  public static void Main(string[] args){
    double[] abc = Console.ReadLine().Split().Select(double.Parse).ToArray();
    double area_triangulo = (abc[0] * abc[2])/2;
    double area_circulo =  3.14159 * (Math.Pow(abc[2], 2));
    double area_trapezio = ((abc[0] + abc[1])*abc[2])/2;
    double area_quadrado = Math.Pow(abc[1], 2);
    double area_retangulo = abc[0] * abc[1];
    Console.WriteLine($"TRIANGULO: {area_triangulo:f3}");
    Console.WriteLine($"CIRCULO: {area_circulo:f3}");
    Console.WriteLine($"TRAPEZIO: {area_trapezio:f3}");
    Console.WriteLine($"QUADRADO: {area_quadrado:f3}");
    Console.WriteLine($"RETANGULO: {area_retangulo:f3}");
  }
}