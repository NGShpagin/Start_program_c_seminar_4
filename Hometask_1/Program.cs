void Func(int a, int b)
{
    double result = Math.Pow(a, b);
    int all_result = (int)result;
    Console.WriteLine($"num1 = {a}, num2 = {b} -- > {all_result} ({a}**{b})");
}

Func(3, 5);
Func(2, 4);

// Решение Марии (на уроке)

//int PowNum(int a, int b)
//{
//    int n_pow = a;
//    for (int i = 1; i <= b; i++)
//    {
//        n_pow *= a;
//    }
//    return n_pow;
//}
//
//Console.WriteLine(PowNum(3,5));
//Console.WriteLine(PowNum(2,4));