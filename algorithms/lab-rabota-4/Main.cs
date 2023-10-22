using System;
class LabRabota4 {
  static void Main() {
    for (double a = 1; a <= 1.5; a += 0.5) {
        for (double x = 0; x <= 4; x += a/2) {
            Console.WriteLine("При x=" + x + " и a=" + a + " Z=" + Calculate(a, x));
        }
    }
  }
  
  static double Calculate(double a, double x) {
    double z;
      
    if (x <= 3) {
        z = -a * Math.Pow(Math.E, x - 3 * a);
    } else {
        z = -a * (1 + Math.Log(x - 3 * a));
    }
    
    return z;
  }
}