void InputArray(int[] array)
{
    for (int i =0; i<array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

Console.Clear();
int[] array = new int[4];
int num = 0;
InputArray(array);
Console.WriteLine(string.Join(" ", array));
for (int k = 0; k<array.Length; k++)
    {
        if (array[k]%2==0)
            num ++;
    }
Console.WriteLine(num);
