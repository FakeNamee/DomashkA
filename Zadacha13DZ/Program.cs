    Console.WriteLine("Введите число:");
    Console.Write("a = ");
    int a = Convert.ToInt32(Console.ReadLine());
    int result = Math.Abs(a);
    int temporary = (result / 100);

    while (result > 1000)
    {
        result /= 10;
    }

    if (temporary == 0)
    {
        Console.WriteLine("третья цифра отсутствует");
    }
    else
    {
        Console.WriteLine($"{a} -> {result % 10}");
    }
