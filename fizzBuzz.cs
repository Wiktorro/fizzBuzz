using System;

using System.Linq; // for Enumerable itaration
using System.Diagnostics; // time measurement

class HelloWorld {
  static void Main() {
    //Console.WriteLine("Hello World");
        // var  // works as auto type
        Stopwatch 
        stopwatch = Stopwatch.StartNew();
    Enumerable.Range(1, 16).ToList().ForEach(x =>
       {
         const int rem3 = x % 3;
         const int rem5 = x % 5;
    Console.WriteLine($"{(rem3 == 0 ? "Fizz" : "")}{(rem5 == 0 ? "Buzz" : "")}{(rem3 != 0 && rem5 != 0 ? x.ToString() : "")}");
    } );
        stopwatch.Stop();
        // Display elapsed time in different formats
        Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}"); // Full TimeSpan
        Console.WriteLine($"Elapsed Milliseconds: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Elapsed Ticks: {stopwatch.ElapsedTicks} ticks");
  }
}
