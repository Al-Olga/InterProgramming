// По двум заданным числам проверять является ли первое квадратом второго
int a;
int b;
Console.Write("Введите первое число  А= ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число  В= ");
b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine("число А является квадратом числа В");
}
else 
{
    Console.WriteLine("число А не является квадратом числа В");
}