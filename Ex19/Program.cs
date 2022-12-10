Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<99999 && num>10000)
{
    if (num/10000==num%10 && num/1000%10==num%100/10)
    {
        Console.Write($"{num} - палиндром");
    }
    else 
    {
        Console.Write($"Число {num} не палиндром");
    }
}
else 
    Console.Write($"{num} не пятизначное число");