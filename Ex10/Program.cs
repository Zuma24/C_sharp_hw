Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num>999 | num<100)
{
    Console.WriteLine($"Число не входит в диапазон");
    Console.Write("Введите трёхзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"2-ая цифра числа {num} - {num%100/10}");