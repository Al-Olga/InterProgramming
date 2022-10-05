// Показать вторую цифру трёхзначного числа
// без преобразований в строку/символ

int numberA = new Random().Next(100,1000);
Console.WriteLine(numberA);

int rep = numberA/10;

while (rep>10)
{
    rep=rep-10;
}
if (rep==10)
{
    Console.WriteLine("Вторая (с начала) цифра : " + 0);
}
else
{
    Console.WriteLine("Вторая (с начала) цифра : " + rep);
}