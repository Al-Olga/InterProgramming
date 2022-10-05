// Найти третью цифру числа или сообщить, что её нет
int numberA;

Console.Write("Задайте число : ");
numberA = Convert.ToInt32(Console.ReadLine());
int Third_num;

if (numberA<0)
{
    numberA=numberA*(-1);
}
if (numberA<100)
{
    Console.WriteLine("В введенном числе нет третьей цифры");
}
if (numberA>999)
{
    while (numberA>999)
    {
        numberA=numberA/10;
    }
}
if ((numberA>99) & (numberA<1000))
{
    Third_num=numberA%10;
    Console.WriteLine("Третья цифра в числе = {0}", Third_num);
}