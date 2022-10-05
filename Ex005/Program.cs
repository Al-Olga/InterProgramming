// Показать четные числа от 1 до N
int n;
Console.Write("Введите количество чисел = ");
n = Convert.ToInt32(Console.ReadLine());

int i=1;
int CountNumber=0;
string StrNumbers;
StrNumbers = " ";

while (i<=n)
{
    if (i%2==0)
    {
        StrNumbers= StrNumbers+i+",";
        CountNumber=CountNumber+1;
    } 
    i=i+1;
}
if (CountNumber==0)
{
    Console.WriteLine("Четные числа не найдены");
}
else
{
    Console.WriteLine("Четные числа: "+StrNumbers);
}