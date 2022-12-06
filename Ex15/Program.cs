Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0 & num<8)
{
    if (num<6)
    {
        Console.Write("Рабочий день");
    }
    else
    {
        Console.Write("Выходной");
    }
}
else
    Console.Write("Нет таких дней недели");
