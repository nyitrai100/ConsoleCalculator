

double number1 = 0;
double number2 = 0;
double result = 0;

Console.WriteLine("-----------");
Console.WriteLine("C# Calculator");
Console.WriteLine("-----------");

Console.WriteLine("Enter your first number");
number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your second number");
number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an option");
Console.WriteLine("/t+: ADD ");
Console.WriteLine("/t-: SUBTRACT");
Console.WriteLine("/t*: MULTIPLY");
Console.WriteLine("/t/: DIVIDE");

switch (Console.ReadLine())
{ 
    case "+":
    result = number1 + number2;
    Console.WriteLine($"{number1} + {number2} = {result}");
    break;
    
}