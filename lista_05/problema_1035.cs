using System;
using System.Linq;
public class lista_05{
  public static void Main(string[] args){
    int[] abcd = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int soma_cd = abcd[2] + abcd[3];
    int soma_ab = abcd[0] + abcd[1];
    int a_par = abcd[0] % 2;
    if ((abcd[1] > abcd[2]) && (abcd[3] > abcd[0]) && (soma_cd > soma_ab) && (abcd[2] > 0 && abcd[3] > 0) && (a_par == 0)){
      Console.WriteLine("Valores aceitos");
    }
    else{
      Console.WriteLine("Valores nao aceitos");
    }
  }
}