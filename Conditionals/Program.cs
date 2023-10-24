var number = 10;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}

else if (number == 20)
{
    Console.WriteLine("Number is not 20");
}

else
{
    Console.WriteLine("Number is not 10 or 20");
}

var number1 = 11;
Console.WriteLine(number1 == 10 ? "Number is 10" : "Number is not 10");

var number2 = 20;
switch (number2)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}
var number3 = 125;
if (number3 >= 0 && number3 <= 100) { Console.WriteLine("Number is between 0-100"); }
else if (number3 > 100 && number <= 200) { Console.WriteLine("Number is between 101-200"); }
else if (number3>200 || number3<0) { Console.WriteLine("Number is less than 0 or greater than 200"); }

// Nested
var number5 = 95;
if (number5 < 100)
{
    if (number5>=90) { Console.WriteLine(number5); }
}
Console.ReadLine();