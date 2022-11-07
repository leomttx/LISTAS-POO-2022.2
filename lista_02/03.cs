/*  Calcular a média parcial de uma disciplina semestral, dadas as notas dos 1o e 2o bimestres (pesos 2 e 3).
Considerar as notas com valores inteiros entre zero e cem.*/

using System;

public class exe_006 {
  public static void Main(string [] args){
    Console.WriteLine("Calculando Média:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = ((a * 2) + (b * 3)) / 5;
    Console.WriteLine(c);
  }
}