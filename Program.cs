// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;

namespace HelloWorld
{

  class Car
  {
    private string name; // field
    public string model = "";

    public string Name   // property
    {
      get { return name; }   // get method
      set { name = value; }  // set method
    }

    public Car()
    {
      model = "constructed";
      name = "";
    }

    public Car(string ModelName)
    {
      model = ModelName;
      name = "";
    }
  }

  // class Person
  // {
  //   public string Name  // property
  //   { get; set; }
  // }

  class Program
  {
    static void MyMethod(string arg = "default") 
    {
      Console.WriteLine($"I just got executed! with: {arg}");
    }

    static int MyRetMethod()
    {
      return 2;
    }

    static void Main(string[] args)
    {

      MyMethod("halko");
      MyMethod();
      MyMethod($"{MyRetMethod()}");

      Car myObj = new Car();
      myObj.Name = "Gustaw";
      Car myObj1 = new Car("Astra");
      //myObj.model = "custom";
      Console.WriteLine("Model: " + myObj.model + " Name: " + myObj.Name + "\nModel 1: " + myObj1.model);


      // Person myObjPer = new Person();
      // myObjPer.Name = "Liam";
      // Console.WriteLine(myObjPer.Name);


      //files

      string writeText = "Hello World!";  // Create a text string
      File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

      string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
      Console.WriteLine(readText);  // Output the content





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