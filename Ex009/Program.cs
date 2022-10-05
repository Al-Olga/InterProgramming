// Удалить вторую цифру трёхзначного числа

int numberA = new Random().Next(100,1000);
Console.WriteLine(numberA);

int numberB = (numberA/100)*10+(numberA%10); 
Console.WriteLine(numberB);