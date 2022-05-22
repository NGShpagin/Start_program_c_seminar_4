void Func(int[] array)
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(2);
        Console.WriteLine(array[i]);
    }
}