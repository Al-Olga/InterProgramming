// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int number_zadano;
int number_kratnoe;
int ost;

Console.Write("Задайте число кратность к которому будем проверять ");
number_zadano = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, проверяемое на кратность ");
number_kratnoe = Convert.ToInt32(Console.ReadLine());

ost=number_kratnoe%number_zadano;

if (ost==0)
{
    Console.WriteLine("Число {0} кратно числу {1}", number_kratnoe, number_zadano);
}
else 
{
    Console.WriteLine("Число {0} НЕкратно числу {1}. Остаток от деления = {2}", number_kratnoe, number_zadano, ost);
}
