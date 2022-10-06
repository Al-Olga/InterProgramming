// По заданному номеру дня недели вывести его название
int NumberDay;

Console.Write("Введите номер дня недели: ");
NumberDay = Convert.ToInt32(Console.ReadLine());

if (NumberDay == 1) Console.WriteLine("Понедельник");
if (NumberDay == 2) Console.WriteLine("Вторник");
if (NumberDay == 3) Console.WriteLine("Среда");
if (NumberDay == 4) Console.WriteLine("Четверг");
if (NumberDay == 5) Console.WriteLine("Пятница");
if (NumberDay == 6) Console.WriteLine("Суббота");
if (NumberDay == 7) Console.WriteLine("Воскресенье");
if ((NumberDay < 1) | (NumberDay > 7)) Console.WriteLine("День недели по введенному номеру не существует");