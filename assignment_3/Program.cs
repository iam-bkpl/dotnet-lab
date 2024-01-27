/*
1. Write C# code to declare a variable to store the age of a person. Then the output of the program is as an example shown below:
You are 20 years old.
*/

using System.Runtime.ExceptionServices;

void sayAge()
{
    int age = 20;
    Console.WriteLine($"You are {age} years old.");
}

// sayAge();

/*
2. Write a C# program that asks the user to input three integer values and find the greatest value of the three values.
a. Use if-else
*/

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

/*
3. Write C# code to prompt a user to input his/her first-name and then the output will be shown as an example below:
Hello first-name!
E.g. If ‘Ram’ is input, display ‘Hello Ram!’
*/

void sayHi(string name)
{
    Console.WriteLine($"Hello {name}");
}
// sayHi("Jack");

/*
4. Write a C# program that asks the user to input n integer values and find the greatest value of the n values.
a. Use for
b. Use if-else
*/

void findGreatestOfNValues()
{
    Console.WriteLine("Enter the value of n :");
    int n = Convert.ToInt32(Console.ReadLine());
    int greatest = -11111;

    for (int i = 0; i < n; i++)
    {

        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > greatest)
        {
            greatest = num;
        }
    }
    Console.WriteLine($"Greatest number is {greatest}");

}

// findGreatestOfNValues();

/*
5. Write a C# program which asks the user for two numbers and an operator to perform on them (+,-,x,/) and displays the result of that operation, as in this example:
Enter first number: 5
Enter operator: +
Enter second number: 7
Output: 5+7=12
a. Use if-else
b. Use switch
*/

void calcWithIfElse()
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

// calcWithIfElse();

void calcWithSwitch()
{
    Console.WriteLine("Enter First Number :");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter The Operator");
    string op = Console.ReadLine();

    Console.WriteLine("Enter Second Number :");
    int num2 = Convert.ToInt32(Console.ReadLine());

    // using if else 
    switch (op)
    {
        case "+":
            Console.WriteLine($" num1 + num2 : {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($" num1 - num2 : {num1 - num2}");
            break;

        case "*":
            Console.WriteLine($" num1 * num2 : {num1 * num2}");
            break;

        case "/":
            Console.WriteLine($" num1 / num2 : {num1 / num2}");
            break;

    }

}

// calcWithSwitch();

/*
6.Write C# code to print the following pattern:
1******
12*****
123****
1234***
12345**
123456*
1234567
*/

void printPattern()
{
    for (int i = 1; i <= 7; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j}");
        }
        for (int k = i; k < 7; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
// printPattern();

/*
7. Write a C# program that determines a student’s grade according to new SLC grading system. The program will read three types of scores(first-term score, mid-term score, and final score) and determine the grade based on the following rules:
Grade A: if the average score >=90%
Grade B: if the average score >= 70% and <90%
Grade C: if the average score >= 50% and <70%
Grade E: if the average score >= 35% and < 50%
Grade F: if the average score < 35%
*/

void findGrade()
{
    Console.WriteLine("Enter your first-term score in % :");
    int first_term = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your mid-term score in %   :");
    int mid_term = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your final-term score in % :");
    int final_term = Convert.ToInt32(Console.ReadLine());


    double average = (first_term + mid_term + final_term) / 3.0;

    if (average >= 90)
    {
        Console.WriteLine("Grade A");
    }
    else if (average >= 70)
    {
        Console.WriteLine("Grade B");
    }
    else if (average >= 50)
    {
        Console.WriteLine("Grade C");
    }
    else if (average >= 35)
    {
        Console.WriteLine("Grade E");
    }
    else
    {
        Console.WriteLine("Grade F");
    }
}

// findGrade();

/*
8. Write C# code to declare one integer variable, one float variable, and one string variable and assign 10, 12.5, and "50" to them respectively. 
a. Display their values on the screen. 
b. Add their values in floating point value and display the sum on the screen.
c. Concatenate their values and display the output on the screen. 
*/

void printValues()
{
    int my_int;
    double my_float;
    string my_string;

    my_int = 10;
    my_float = 12.5;
    my_string = "50";

    Console.WriteLine($"my_int : {my_int} | my_float : {my_float} | my_string : {my_string}");

    double my_sum = my_int + my_float + Convert.ToDouble(my_string);

    Console.WriteLine($"The sum of 3 is {my_sum}");

    Console.WriteLine($"{my_int}{my_float}{my_string}");

}
// printValues();

/*
9. Write a C# program to allow a user to guess a number( from 1 to 6)
that will be randomly generated by computer.
If guess is correct, display “You won”. Otherwise display “You lose”.
*/

void guessGame()
{
    try
    {
        Console.WriteLine("Q9");
        // Ask user to guess number
        Console.WriteLine("Guess a number between 1 and 6");
        string guess = Console.ReadLine();

        // Convert user's input from string to int
        int guessNumber = Convert.ToInt32(guess);

        // Validate the range
        if (guessNumber < 1 || guessNumber > 6)
        {
            // throw exception if invalid input is given
            throw new Exception("Number must be between 1 and 6");
        }

        // Generate a random number
        Random r = new Random();
        int randomNumber = r.Next(1, 7);

        if (guessNumber == randomNumber)
        {
            Console.WriteLine("You won");
        }
        else
        {
            Console.WriteLine($"You lose. Random number was {randomNumber}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}

guessGame();

/*
10. Write a program to sort the given array in descending order and display the result.
List<string> daysList = new List<string>
{"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
*/
void sortList()
{

    try
    {
        Console.WriteLine("Q10");

        // Define the list of string
        List<string> monthsList = new List<string> {
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"
        };

        // Sort the list of string in descending order using lambda expression
        List<string> sortedMonthsList = monthsList
        .OrderByDescending(x => x) // order by descending
        .ToList(); // convert output to list

        // Display the result
        Console.WriteLine("The sorted values in descending order is:");

        // Loop through each values of sorted list
        foreach (var month in sortedMonthsList)
        {
            // Display the month
            Console.WriteLine(month);
        }
    }
    catch (Exception ex)
    {
        // If error occurs, display the exception message
        Console.WriteLine(ex.Message);
    }
}

// sortList();