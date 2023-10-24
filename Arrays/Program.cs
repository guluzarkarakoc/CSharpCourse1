string student1="Ali";
string student2 = "Ahmet";
string student3 = "Ayşe";

string[] students = new string[3];
students[0] = "Ali";
students[1] = "Ahmet";
students[2] = "Ayşe";

string[] students2 = new[] { "Ali", "Ahmet", "Ayşe"};

foreach (var student in students) { Console.WriteLine(student); }

string[,] regions = new string[7, 3];
regions[0, 0] = "İstanbul";

string[,] regions2 = new string[7, 3] 
{   {"İstanbul","Tekirdağ","Bursa" },
    {"Adana","Mersin","Antalya" },
    {"Trabzon","Amasya","Giresun" },
    {"Ankara","Konya","Eskişehir" },
    {"Gaziantep","Şanlıurfa","Diyarbakır" },
    {"İzmir","Aydın","Manisa" },
    {"Ardahan","Iğdır","Hakkari" }
};
for (int i = 0; i< regions2.GetUpperBound(0); i++) 
{  for (int j = 0; j < regions2.GetUpperBound(1); j++)
    { Console.WriteLine(regions2[i, j]); }
    Console.WriteLine("----------");
} 
Console.WriteLine();
Console.ReadLine();