using System;

using System.Linq; // for Enumerable itaration

class HelloWorld {
  static void FizzBuzzWide(int x) {
        //  const 
        bool rem3 = (0 == (x % 3));
        bool rem5 = (0 == (x % 5));
        if (rem3)
            {           
            if (rem5)
                Console.WriteLine("FizzBuzz");
            else
                Console.WriteLine("Fizz");
            }
        else if (rem5)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(x);
  }
  static void Main() {
    //Console.WriteLine("Hello World");
    Enumerable.Range(1, 16).ToList().ForEach(x =>
       {
         const int rem3 = x % 3;
         const int rem5 = x % 5;
    Console.WriteLine($"{(rem3 == 0 ? "Fizz" : "")}{(rem5 == 0 ? "Buzz" : "")}{(rem3 != 0 && rem5 != 0 ? x.ToString() : "")}");
    } );
  }
}
