using System;
public class lista_04{
  public static void Main(string[] args){
    int tempo_gasto = int.Parse(Console.ReadLine());
    int velocidade_media = int.Parse(Console.ReadLine());
    int distancia = tempo_gasto * velocidade_media;
    double litros_gastos = distancia / 12;
    Console.WriteLine($"{litros_gastos:f3}");
  }
}