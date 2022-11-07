using System;
public class lista_03{
  public static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    int n_100 = (n / 100);
    int n_50 = (n % 100)/50;
    int n_20 = ((n % 100)%50)/20;
    int n_10 =(((n % 100)%50)%20)/10;
    int n_5 = ((((n % 100)%50)%20)%10)/5;
    int n_2 = (((((n % 100)%50)%20)%10)%5)/2;
    int n_1 = (((((n %100)%50)%20)%10)%5)%2;
    Console.WriteLine($"{n}");
    Console.WriteLine($"{n_100} nota(s) de R$ 100,00");
    Console.WriteLine($"{n_50} nota(s) de R$ 50,00");
    Console.WriteLine($"{n_20} nota(s) de R$ 20,00");
    Console.WriteLine($"{n_10} nota(s) de R$ 10,00");
    Console.WriteLine($"{n_5} nota(s) de R$ 5,00");
    Console.WriteLine($"{n_2} nota(s) de R$ 2,00");
    Console.WriteLine($"{n_1} nota(s) de R$ 1,00");
  }
}