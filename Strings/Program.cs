using System;

string city = "Ankara";

Console.WriteLine(city[0]);

foreach(var item in city)
{
    Console.WriteLine(item);
}

string city2 = "İstanbul;";

string result = city+city2;
Console.WriteLine(result);

Console.WriteLine(String.Format("{0} {1}",city,city2));

String sentence = "My name is Gül Karakoç";
var result2 = sentence.Length;
var result3 = sentence.Clone();
sentence = "My name is Ali Karakoç";

bool result4= sentence.EndsWith("ç");
bool result5 = sentence.StartsWith("M");
var result6 = sentence.IndexOf("name");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0,"Hello!");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ","-");
var result13 = sentence.Remove(2,5);


Console.WriteLine(result);
Console.WriteLine(result2); 
Console.WriteLine(result3); 
Console.WriteLine(result4);
Console.WriteLine(result5);
Console.WriteLine(result6);
Console.WriteLine(result7);
Console.WriteLine(result8);
Console.WriteLine(result9);
Console.WriteLine(result10);
Console.WriteLine(result11);
Console.WriteLine(result12);
Console.WriteLine(result13);

Console.ReadLine();


