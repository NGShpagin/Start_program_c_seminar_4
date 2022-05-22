int SumNumber(int number)
{
    int sum = 0;
    Console.Write($"{number} -> ");
    while (number > 0)
    {
        int num = number % 10;
        sum += num;
        number /= 10;
    }
    return sum;
}

Console.WriteLine(SumNumber(452));
Console.WriteLine(SumNumber(82));
Console.WriteLine(SumNumber(9012));