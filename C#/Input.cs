

using System;

    class Program
{
    static void Main()
    {
       Console.WriteLine("Enter your name"); //String input
       string name = Console.ReadLine();

       Console.WriteLine("Enter Your Age"); // Int Input
       int age = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Enter your Height");    // float Input
       float height = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Enter your Grade"); //Char Input
       char grade = Convert.ToChar(Console.ReadLine());

       Console.WriteLine("Enter your Price"); // Double Input
       double price = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine("Enter your result"); // bool Input
       bool passed = Convert.ToBoolean(Console.ReadLine());

       Console.WriteLine("hello " + name);
       Console.WriteLine("You are " + age + " years old.");
       Console.WriteLine("your height is " + height + " feet");  
       Console.WriteLine("your grade is " + grade);
       Console.WriteLine( "your price is " + price );
       Console.WriteLine("your result is " + passed);

       
    }
}