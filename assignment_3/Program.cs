// See https://aka.ms/new-console-template for more information
// Q:1
// Console.WriteLine("Enter your name :");
// string name = Console.ReadLine();


// Console.WriteLine($"Your name is {name}");

// Q:2
void findGreatest()
{
    Console.WriteLine("Enter 3 numbers ");

    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());


    if (num1 >= num2 && num1 >= num3)
    {
        Console.WriteLine($" {num1} is greater ");
    }
    else if (num2 > num3)
    {
        Console.WriteLine($" {num2} is greater ");
    }
    else
    {
        Console.WriteLine($" {num3} is greater ");
    }
}
// findGreatest();

// Q:3
void sayHi(string name){
    Console.WriteLine($"Hello {name}");
}
// sayHi("Jack");

// Q:4

/*
5. Write a C# program which asks the user for two numbers and an operator to perform on them (+,-,x,/) and displays the result of that operation, as in this example:
Enter first number: 5
Enter operator: +
Enter second number: 7
Output: 5+7=12
a. Use if-else
b. Use switch
*/


// Taking user input

void calculator()
{


    Console.WriteLine("Enter First Number :");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter The Operator");
    string op = Console.ReadLine();

    Console.WriteLine("Enter Second Number :");
    int num2 = Convert.ToInt32(Console.ReadLine());

    // using if else 

    if (op == "+")
    {
        Console.WriteLine($" num1 + num2 : {num1 + num2}");
    }
    else if (op == "-")
    {
        Console.WriteLine($" num1 - num2 : {num1 - num2}");
    }
    else if (op == "*")
    {
        Console.WriteLine($" num1 * num2 : {num1 * num2}");
    }
    else if (op == "/")
    {
        Console.WriteLine($" num1 / num2 : {num1 / num2}");
    }

}

calculator();