using System;
public class lista_03{
  public static void Main(string[] args){
    string[] x = Console.ReadLine().Split(' ');
    int comprimento_estrada = int.Parse(x[0]);
    int distancia_pedagios = int.Parse(x[1]);
    string[] y = Console.ReadLine().Split(' ');
    int custo_km = int.Parse(y[0]);
    int valor_pedagio = int.Parse(y[1]);
    int div = comprimento_estrada / distancia_pedagios;
    int mul = custo_km * comprimento_estrada;
    int mult = valor_pedagio * div;
    int total = mul + mult;
    Console.WriteLine(total);
  }
}