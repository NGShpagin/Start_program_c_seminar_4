// Мое решение
void Func()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(8);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Решение Марии (на уроке)

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] Eightmass()
{
    int size = 8;
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1,100);
        Console.Write($"{arr[i]}, ");
    }
    return arr;
}

Func();