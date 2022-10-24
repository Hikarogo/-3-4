////int a = 5, b = 13;
////for (int i = a; i <= b; i++)
////{
////    for (int j = 1; j <= i; j++)
////    {
////        Console.Write($" {i} ");

////    }
////    Console.WriteLine();
//}
Console.WriteLine("ваше число a");
String a =Console.ReadLine();
int f = int.Parse(a);
Console.WriteLine("ваше число b");
string b = Console.ReadLine();
int g = int.Parse(b);
Console.WriteLine();
if (f < g)
{
    for (int i = f; i <= g; i++)
    {
        Console.WriteLine(i);
     
    }
}
else
{
    for(int j = f; j >= g; j--)
        Console.WriteLine(j);  
}
