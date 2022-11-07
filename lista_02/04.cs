using System;

public class exe_007{

  public static void Main( string[] args) {
    Console.WriteLine("Calculando a área, perimetro e diagonal de um retangulo:");
    Console.WriteLine("Digite a Base:");
    int base_ret = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Altura:");
    int altura_ret = int.Parse(Console.ReadLine());
    Console.WriteLine("Essa é a Área:");
    double area = (base_ret * altura_ret);
    Console.WriteLine($"{area:0.00}");
    Console.WriteLine("Esse é o Perimetro:");
    double perimetro = base_ret + altura_ret + base_ret + altura_ret;
    Console.WriteLine($"{perimetro:0.00}");
    Console.WriteLine("Essa é a Diagonal:");
    double diagonal = Math.Pow(base_ret, 2) + Math.Pow(altura_ret, 2);
    double resultado = Math.Sqrt(diagonal);
    Console.WriteLine($"{resultado:0.00}");
  }
}