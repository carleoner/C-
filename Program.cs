// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace HelloWorld
{
  class Program
  {
    static void MyMethod() 
    {
      Console.WriteLine("I just got executed!");
    }
    static void Main(string[] args)
    {

      MyMethod();

      Console.WriteLine("Hello Worldsss!");    
      Console.WriteLine(3 + 3);
      Console.Write("without /n ");

      string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);

      float f1 = 35e3F;
      double d1 = 12E4D;
      Console.WriteLine(f1);
      Console.WriteLine(d1);
      int maxi = Math.Max(5, 10);

      Console.WriteLine(maxi);

      string myString = "Hello";
      Console.WriteLine(myString.IndexOf("l")); 

    }
  }
}