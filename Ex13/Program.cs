Console.Clear();
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num/100 == 0)
    Console.Write($"3-ей цифры нет в числе {num}");
else 
     Console.Write($"Третья цифра числа {num} - {num%1000/100}");
