int Func(int num)
{
    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

Console.WriteLine(Func(1241));

int NumCount(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(NumCount(1241325));