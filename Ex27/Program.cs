Console.Clear();
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int num2=0, num1;
for (int i = 0; i < n.Length; i++)
{
    num1 = int.Parse(n[i].ToString());
	num2 += num1; 
}
Console.WriteLine(num2);
