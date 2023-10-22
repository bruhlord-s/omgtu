using System;
class LabRabota2 {
  static void Main() {
    int x = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(Calculate(x));
  }
  
  static double Calculate(int x) {
    double a = 1.5;
    double y;
    
    if (x < 1.3) {
        y = Math.PI * Math.Pow(x, 2) - 7 / Math.Pow(x, 2);
    } else if (x >= 1.3 && x < 3) {
        y = a * Math.Pow(x, 3) + 7 * Math.Sqrt(x);
    } else {
        y = Math.Log10(x + 7 * Math.Sqrt(x));
    }
    
    return y;
  }
}