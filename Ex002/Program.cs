// По заданному номеру дня недели вывести его название
int NumberDay;
string [] DayOfWeek = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

int i = 0;
Console.Write("Введите номер дня недели: ");
NumberDay = Convert.ToInt32(Console.ReadLine());


while (i < DayOfWeek.Length)
{
   if (NumberDay == i+1)
   {
        Console.WriteLine("Введенный номер дня недели соответствует дню недели: " + DayOfWeek[i]);
        i = DayOfWeek.Length+1;
   }
   else 
   {
        i = i+1;
   }
}

if (i == DayOfWeek.Length)
{
    Console.WriteLine("Дня недели с введенным номером не существует");
}