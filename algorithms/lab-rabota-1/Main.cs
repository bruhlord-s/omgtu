using System;
class LabRabota1 {
  static void Main() {
    int x1 = -1;
    int x2 = 1;
    
    Console.WriteLine(Calculate(x1));
    Console.WriteLine(Calculate(x2));
  }
  
  static double Calculate(int x) {
    double a = 0.5;
    int b = 2;
    
    double y = b * Math.Pow(x, 2) * Math.Pow(Math.E, a * Math.Pow(x, 2)) + a * Math.Sqrt(x + 1.5);
    return y;
  }
}