// Показать последнюю цифру трёхзначного числа

int numberA = new Random().Next(100,1000);
Console.WriteLine(numberA);

int rep;
rep = numberA%10;

if (rep==0) Console.WriteLine("Последняя цифра : 0");
else Console.WriteLine("Последняя цифра : {0}", rep);