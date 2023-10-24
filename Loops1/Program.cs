

for (int i =0; i<100; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished!");
for (int j = 100; j >= 0; j=j-2)
{
    Console.WriteLine(j);
}

int number = 100;
while (number >= 0)
{
    Console.WriteLine(number);
    number--;
}
Console.WriteLine("Now number is {0}", number);


int number2 = 10;
do
{

    Console.WriteLine(number2);
    number2--;
} while (number2 >= 0);

string[] students = new string[3] { "Ali", "Ahmet", "Ayşe" };
foreach (var student in students)
{
    Console.WriteLine(student);
}
if (IsPrimeNumber(6))
    { Console.WriteLine("This is a prime number."); }
else { Console.WriteLine("This is not a prime number."); }

Console.ReadLine();


private static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
            break;
        }
    }
    return result;
}
