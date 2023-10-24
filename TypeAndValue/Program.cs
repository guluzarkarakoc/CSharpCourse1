int number1 = 10;
int number2 = -2147483648;
long number3 = -9223372036854775808;
short number4 = 32767;
byte number5 = 255;
bool conditions = true;
char character = 'G';
String city = "İstanbul";
Double number6 = 10.4D;
Decimal number7 = 10.256M;

var number8 = 10;
number8 = 'A';



Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Number8 is {0}", number8);
Console.WriteLine("character is : {0}", (int)character);
Console.WriteLine(conditions);
Console.WriteLine(city);

Console.WriteLine((int)Days.Friday);

Console.ReadLine();

enum Days
{ Monday, Tuesday, Wednesday, Thursday, Friday }

