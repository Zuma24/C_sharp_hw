Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
	array[i] = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"[{string.Join(", ", array)}]");

//string[] num = Console.ReadLine().Split(",");

