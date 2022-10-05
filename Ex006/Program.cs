// Показать последнюю цифру трёхзначного числа

int numberA = new Random().Next(100,1000);
Console.WriteLine(numberA);
Console.WriteLine("Третья (с начала) цифра : {0}", numberA.ToString().ToCharArray()[2]);