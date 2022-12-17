int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
foreach (int element in size)//нужно использовать
    Console.WriteLine(element * 2);

//foreach (var element in size)