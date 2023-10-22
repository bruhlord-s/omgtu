using System;
class LabRabota3 {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(Calculate(n));
  }
  
  static double Calculate(int n) {
    int result = 1;
    
    for (int i = 1; i <= n; i++) {
        result *= i;
    }
    
    return result;
  }
}