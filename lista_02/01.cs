// Ler o primeiro nome de uma pessoa e mostrar após a frase.
using System;

public class exe_004{
  public static void Main(string [] args){
    Console.WriteLine("Qual é o seu nome?");
    string nome = Console.ReadLine();
    Console.WriteLine($"Bem vindo ao C# {nome}");
  }
}