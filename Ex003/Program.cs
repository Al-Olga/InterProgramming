// Найти максимальное из трех чисел
int a;
int b;
int c;
int max;

Console.Write("Введите первое число  А= ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число  В= ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число  C= ");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine("масимальное число = {0}", max);