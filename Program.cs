
//  problem  1//
/*
using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x= 10;     
            int y= 20;     
            int sum= x + y;
            Console.WriteLine(sum);
        }
    }
}
*/


//  problem  2//

/*
 
using System;
namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse("10"); // Convert string to integer using int.Parse()
            int y = 20;
            Console.WriteLine(x + y);
        }
    }
}
*/

// problem 3 //
/*
 
 using System;

namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Farah Hazem";        
            int age = 20;                        
            decimal monthlySalary = 3000.50m;    
            bool isStudent = true;              
        }
    }
}
*/

//problem 4 //

/*
 
 using System;

public class Program
{
    public static void Main()
    {
    
        Person original = new Person { Name = "Farah", Age = 20 };
        Person referenceCopy = original;

        Console.WriteLine("Before Edit:");
        Console.WriteLine($"Original: {original.Name}, {original.Age}");
        Console.WriteLine($"Reference Copy: {referenceCopy.Name}, {referenceCopy.Age}");

        referenceCopy.Name = "faroha";
        referenceCopy.Age = 20;

        Console.WriteLine("\nAfter  Edit:");
        Console.WriteLine($"Original: {original.Name}, {original.Age}");
        Console.WriteLine($"Reference Copy: {referenceCopy.Name}, {referenceCopy.Age}");
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
*/

//problem 5 //

/*
 
 using System;

class Program
{
    static void Main()
    {
 
        int x = 15;
        int y = 4;
        int sum = x + y;
        int difference = x - y;
        int product = x * y;
        double divisionResult = (double)x / y; 
        int remainder = x % y;
        Console.WriteLine($"Basic Arithmetic Operations:");
        Console.WriteLine($"────────────────────────────");
        Console.WriteLine($"Initial Values: x = {x}, y = {y}");
        Console.WriteLine($"Sum:            {x} + {y} = {sum}");
        Console.WriteLine($"Difference:     {x} - {y} = {difference}");
        Console.WriteLine($"Product:        {x} × {y} = {product}");
        Console.WriteLine($"Division:       {x} ÷ {y} = {divisionResult:F2}");
        Console.WriteLine($"Remainder:      {x} % {y} = {remainder}");
    }
}
*/

//problem 6 //

/*using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isGreaterThan10 = number > 10;
        bool isEven = number % 2 == 0;
        bool meetsBothConditions = isGreaterThan10 && isEven;
        Console.WriteLine($"Greater than 10: {(isGreaterThan10 ? "Yes" : "No")}");
        Console.WriteLine($"Even number:     {(isEven ? "Yes" : "No")}");
        Console.WriteLine($"Meets both conditions: {(meetsBothConditions ? "VALID" : "INVALID")}");
    }
}*/

// problem 7 //

/*
 
 using System;

class Program
{
    static void Main()
    {
    
        Console.Write("Enter a decimal number: ");
        double originalValue = Convert.ToDouble(Console.ReadLine());

     
        int explicitCast = (int)originalValue;

    
        double implicitCast = explicitCast;

        
        Console.WriteLine("\nCasting Results:");
        Console.WriteLine($"Original value (double): {originalValue:F2}");
        Console.WriteLine($"Explicit cast to int:    {explicitCast}");
        Console.WriteLine($"Implicit cast back to double: {implicitCast:F2}");
    }
}*/

//problem 8//

/*
 
 using System;

class AgeValidator
{
    static void Main()
    {
        
        Console.Write("Please enter your age: ");
        string ageInput = Console.ReadLine();

    
        int age = int.Parse(ageInput);

        bool isValidAge = age > 0;
        Console.WriteLine($"Input received: {ageInput}");
        Console.WriteLine($"Parsed age: {age}");
        Console.WriteLine($"Valid age? {(isValidAge ? "Yes" : "No - must be greater than 0")}");
    }
}*/


// problem 9//

/*
 
 using System;

class Program
{
    static void Main()
    {
        int x = 5;
        Console.WriteLine($"Initial value of x: {x}");

        int postfixResult = x++;
        Console.WriteLine("\nPostfix Increment (x++):");
        Console.WriteLine($"postfixResult = {postfixResult}"); 
        Console.WriteLine($"x after increment = {x}");        


        x = 5;


        int prefixResult = ++x;
        Console.WriteLine("\nPrefix Increment (++x):");
        Console.WriteLine($"prefixResult = {prefixResult}");  
        Console.WriteLine($"x after increment = {x}");      
    }
}*/