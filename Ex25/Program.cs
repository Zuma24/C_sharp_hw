Console.Clear();
Console.Write("Введите 1-ое число: ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
double num2 = Convert.ToInt32(Console.ReadLine()), i = 1, num = num1;
while (i<num2)
{
	num *=num1;
    i++;
}
Console.WriteLine(num);