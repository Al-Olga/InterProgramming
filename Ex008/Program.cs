// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int numberA = new Random().Next(10,100);
Console.WriteLine(numberA);

int razr1; 
int razr2; 

razr1 = numberA/10;
razr2 = numberA%10; 

if (razr1>razr2)
{
    Console.WriteLine("Наибольшая цифра числа {0}: {1}", numberA, razr1);
}
else if (razr2>razr1)
{
    Console.WriteLine("Наибольшая цифра числа {0}: {1}", numberA, razr2);
}
else 
{
    Console.WriteLine("числа {0} и {1} равны ", razr1, razr2);
}