Console.Clear();
Console.Write("Введите числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int max1 = num1;
int max2 = num1;
while (num1<100 & num1!=0)
{
    Console.Write("Введите число: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 > max1)
    {
        max2 = max1;
        max1 = num1;
    }
    else if (num1>max2)
    {
        max2=num1;
    }
}
Console.WriteLine($"Первый максимум: {max1} \nВторой максимум: {max2} ");