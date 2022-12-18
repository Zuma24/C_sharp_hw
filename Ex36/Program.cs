void InputArray(int[] array)
{
    for (int i =0; i<array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}
Console.Clear();
int n = new Random().Next(1,11);
int[] array = new int[n];
int num = 0;
InputArray(array);
Console.WriteLine(string.Join(" ", array));
for (int k = 0; k<array.Length; k++)
{
    if (k%2==1)
        num += array[k];
}
Console.WriteLine(num);