Console.Clear();
Console.Write("Введите числа меньше 100: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int max1 = num1;
int max2 = 0;
while (num1<100 & num1!=0)
{
    Console.Write("Введите число: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    if (num1>max1)
    {
        max2 = max1;
        max1=num1;
        
    }
    else if (num1 > max2)
    {

        max2 = num1;
    }
}

if (num1>100)
{
    Console.Write($"Число {num1} больше 100");
}

else 
    Console.WriteLine($"Первый максимум: {max1} \nВторой максимум: {max2} ");