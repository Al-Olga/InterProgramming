// Найти максимальное из трех чисел
int [] values;
values = new int[3];
int max;
int i;

i = 0;
int numb=1;
while (i<values.Length)
{
    Console.WriteLine("Введите число " + numb);
    values[i] = Convert.ToInt32(Console.ReadLine());
    i = i+1;
    numb=numb+1;
}

i = 0;
max = values[i];

while (i<values.Length)
{
    if (max<values[i])
    {
        max = values[i];
    }
    i = i+1;
}

Console.WriteLine("масимальное число = "+ max);