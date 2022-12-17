//Вводит пользователь
Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
	array[i] = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"[{string.Join(", ", array)}]");

//Ввод случайных чисел


Console.Write("Введите размер массива: ");
int nu = Convert.ToInt32(Console.ReadLine());
int[] num = new int[nu];
for (int i = 0; i < num.Length; i++)
	num[i] = new Random().Next(0,1000); 

Console.WriteLine($"[{string.Join(", ", num)}]");
