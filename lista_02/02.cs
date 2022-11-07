using System;

public class exe_005 {
  public static void Main(string [] args){
    Console.WriteLine("Qual é seu nome completo?");
    string nome = Console.ReadLine();
    Console.WriteLine($"Bem vindo ao C# {nome}");
  }
}