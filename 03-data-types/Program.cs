namespace _03_data_types;

class Program
{
    static void Main(string[] args)
    {
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        float pi = 3.1415f;          // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String
        Console.WriteLine($"My integer number is {myNum}, my floating-point number is {myDoubleNum}, the value of pi is approximately {pi}, the letter I represent is {myLetter}, and my text is {myText}. My boolean is {myBool}.");

        // default value assigned = 0
        // int age;
        // Console.WriteLine(age); // Use of unassigned local variable 'age'

        int age = 25;
        Console.WriteLine(age);

        string name;
        name = "Jonas";
        Console.WriteLine(name);
    }
}
