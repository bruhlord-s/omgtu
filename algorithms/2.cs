using System;
class HelloWorld {
  static void Main() {
    /*
        Для н-вводимых элементов:
        
        1. Определить кол-во элементов, значения которых
        меньше своих соседей (справа и слева)
        
        2. Определить кол-во смен знаков последовательности
        
        3. Опредедлить максимальную длину подпоследовательности,
        состоящей из одинаковых элементов
        
        4. Опредедлить минимальную длину подпоследовательности,
        состоящей из отрицательных элементов
    */
    
    int iterationsCount = 5;
    
    First(iterationsCount);
    // Second(iterationsCount);
    // Third(iterationsCount);
    // Fourth(iterationsCount);
  }
  
  static void First(int n) {
      int prePrevEl = 0;
      int prevEl = 0;
      int counter = 0;
      
      for (int i = 0; i < n; i++) {
          int input = Convert.ToInt32(Console.ReadLine());
          
          if (i == 0) {
              prePrevEl = input;
          }
          
          if (i == 1) {
              prevEl = input;
          }
          
          if (i > 1) {
              if (prevEl < prePrevEl && prevEl < input) {
                  counter++;
              }
              
              prePrevEl = prevEl;
              prevEl = input;
          }
      }
      
      Console.WriteLine(counter);
  }
  
  static void Second(int n) {
      int counter = 0;
      int prevSign = 0;
      
      for (int i = 0; i < n; i++) {
          int input = Convert.ToInt32(Console.ReadLine());
          int inputSign = input < 0 ? -1 : 1;
        
          if (i == 0) {
              prevSign = inputSign;
              continue;
          }
          
          if (prevSign != inputSign) {
              counter++;
          }
          
          prevSign = inputSign;
      }
      
      Console.WriteLine(counter);
  }
  
  static void Fourth(int n) {
      int counter = 0;
      int minCounter = 0;
      
      for (int i = 0; i < n; i++) {
        int input = Convert.ToInt32(Console.ReadLine());
        
        if (input < 0) {
            counter++;
        } else {
            if (minCounter == 0) {
                minCounter = counter;
            } else {
                minCounter = Math.Min(counter, minCounter);
            }
            counter = 0;
        }
      }
      
      if (minCounter == 0) {
          minCounter = counter;
      } else {
          minCounter = Math.Min(counter, minCounter);
      }
      
      Console.WriteLine(minCounter);
  }
  
  static void Third(int n) {
    int currentEl = 0;
    int counter = 0;
    int maxCounter = 0;
      
    for (int i = 0; i < n; i++) {
        int input = Convert.ToInt32(Console.ReadLine());
        
        if (i == 0) {
            currentEl = input;
            counter++;
            continue;
        }
        
        if (currentEl == input) {
            counter++;
        } else {
            currentEl = input;
            maxCounter = Math.Max(maxCounter, counter);
            counter = 1;
        }
    }
    
    maxCounter = Math.Max(maxCounter, counter);
    
    Console.WriteLine(maxCounter);
  }
}