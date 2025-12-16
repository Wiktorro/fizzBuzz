using System;

using System.Linq; // for Enumerable itaration

class HelloWorld {
  static void FizzBuzzOneline(int x) {
    int rem3 = x % 3;
    int rem5 = x % 5;
    Console.WriteLine($"{(rem3 == 0 ? "Fizz" : "")}{(rem5 == 0 ? "Buzz" : "")}{(rem3 != 0 && rem5 != 0 ? x.ToString() : "")}");
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
