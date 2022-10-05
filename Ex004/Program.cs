// Выяснить является ли число чётным
int a;
Console.Write("Введите число = ");
a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("число четное");
}
else 
{
    Console.WriteLine("число нечетное");
}