using System;

public class exe_008{
  public static void Main( string [] args){
    string a = Console.ReadLine();
    string[] b = a.Split(':');
    int h = int.Parse(b[0]);
    int m = int.Parse(b[1]);
    int s = int.Parse(b[2]);
    long distancia = (((h * 3600) + (m * 60) + s) * (long) 300000);
    //long distancia = tempo * 300000;
    Console.WriteLine($"{distancia}");
  }
}