using System;

using System.Linq; // for Enumerable itaration

class HelloWorld {
  static void Main() {
    //Console.WriteLine("Hello World");
    Enumerable.Range(1, 16).ToList().ForEach(x =>
       {
         const int rem3 = x % 3;
    Console.WriteLine($"{(x % 3 == 0 ? "Fizz" : "")}{(x % 5 == 0 ? "Buzz" : "")}{(x % 3 != 0 && x % 5 != 0 ? x.ToString() : "")}");
    } );
  }
}
