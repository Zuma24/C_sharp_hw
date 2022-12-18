void InputArray(double[] array)
{
    for (int i =0; i<array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}
Console.Clear();
int n = new Random().Next(1,11);
double[] array = new double[n];
int num = 0;
InputArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(array.Max()- array.Min());
