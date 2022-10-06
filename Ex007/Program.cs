// Показать вторую цифру трёхзначного числа

int numberA = new Random().Next(100,1000);
Console.WriteLine(numberA);

int rep;

rep = numberA%100;
rep = rep/10;

if (rep == 0) Console.WriteLine("Вторая (с начала) цифра : 0");
else Console.WriteLine("Вторая (с начала) цифра : {0}", rep);