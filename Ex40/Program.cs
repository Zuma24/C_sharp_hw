Console.Write("Введите стороны треугольника :");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

if ((n1 + n2 > n3) && (n1 + n3 > n2) && (n2 + n3 > n1))
    Console.WriteLine("Может");
else 
    Console.WriteLine("Не Может");

//второе решение
Console.Write("Введите стороны треугольника: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

if (array[0] < array[1] + array[2]
    && array[1] < array[0] + array[2]
    && array[2] < array[0] + array[1])
    Console.Write("Да");
else
    Console.Write("Нет");


