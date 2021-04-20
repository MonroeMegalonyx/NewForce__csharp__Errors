using System;

namespace csharp_errors
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculator calculator = new Calculator();
      int answer = calculator.Divide(42, 0);
      Console.WriteLine($"The answer is {answer}");
    }
  }
}
