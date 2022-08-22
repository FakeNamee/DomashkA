using Metod;
void Zadacha47()
{
    double[,] array = new double[3, 4];
    void FillArrayDuo(double[,] array, int startNumber = 0, int finishNumber = 10)
    {
        finishNumber++;
        Random random = new Random();
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = Math.Round(random.Next(startNumber, finishNumber) + random.NextDouble(), 2);
            }
        }
    }
    FillArrayDuo(array);
    HellpFullFunctions.PrintArrayDuo(array);
}
void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    HellpFullFunctions.FillArrayDuo(array);
    HellpFullFunctions.PrintArrayDuo(array);
    Console.WriteLine();

    Console.WriteLine("Введите номер колонки");
    int numColums = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine("Введите номер строки");
    int numRows = Convert.ToInt32(Console.ReadLine()) - 1;
    if (numColums > array.Length && numRows > array.Length)
    {
        Console.WriteLine("Нет такой позиции");
    }
    else
    {
        Console.WriteLine("Значиние этого элемена " + array[numRows, numColums]);
    }
}
void Zadacha52()
{
    int[,] array = new int[4, 4];
    HellpFullFunctions.FillArrayDuo(array);
    HellpFullFunctions.PrintArrayDuo(array);
    Console.WriteLine();
    double[] sqrColum = new double[4] { 0, 0, 0, 0 };
    double result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int a = array[i, j];
            sqrColum[j] += a;
        }

    }
    for (int i = 0; i < sqrColum.Length; i++)
    {
        result = sqrColum[i] / sqrColum.Length;
        Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {result}");
    }
}

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    HellpFullFunctions.FillArrayDuo(array);
    HellpFullFunctions.PrintArrayDuo(array);

    Console.WriteLine();

    void SortToDimanshinalArray(int[,] array)
    {
        int buff = 0;
        for (int i = 0; i < array.GetLength(0); i++)



        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int u = 1; u < array.GetLength(1); u++)
                {
                    if (array[i, u] > array[i, u - 1])
                    {
                        buff = array[i, u];
                        array[i, u] = array[i, u - 1];
                        array[i, u - 1] = buff;
                    }
    ;
                }
            }
        }
    }
    SortToDimanshinalArray(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Zadacha56()
{
    int[,] array = new int[4, 6];
    HellpFullFunctions.FillArrayDuo(array);
    HellpFullFunctions.PrintArrayDuo(array);
    Console.WriteLine();
    int result = 0;
    int[] SumRows = new int[4] { 0, 0, 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRows[i] += array[i, j];
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов - " + (HellpFullFunctions.MinArrayValue(SumRows) + 1));

}
void Zadacha58()
{
    int[,] array = new int[4, 4];
    HellpFullFunctions.FillArrayDuo(array, -1, -1);
    HellpFullFunctions.PrintArrayDuo(array);
    HellpFullFunctions.SpyralArrayFill(array, 0, 0, 0, "right");
    HellpFullFunctions.PrintArrayDuo(array);
}
void Zadacha63()
{
    void Recursion(int number, int counter = 1)
    {
        if (counter > number) return;
        Console.WriteLine(counter);
        counter++;
        Recursion(number, counter);
    }
    Recursion(5);
}
void Zadacha65()
{
    void Recursion(int m, int n)
    {
        if (m > n) return;
        Console.Write(m + ", ");
        m++;
        Recursion(m, n);
    }

    Console.Write("Введите M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    Recursion(numM, numN);
    Console.WriteLine("\b\b.");

}
void Zadacha67()
{
    void Recurcion(int number, int sum = 0)
    {
        if (number == 0)
        {
            Console.WriteLine($"Сумма = {sum}");
            return;
        }
        sum = sum + number % 10;
        number = number / 10;
        Recurcion(number, sum);


    }

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Recurcion(number);

}
void Zadacha69a()
{
    int Zadacha69(int a, int b, int result = 1)
    {
        if (b == 0) return result;
        result *= a;
        b--;
        return Zadacha69(a, b, result);
    }
    Console.WriteLine(Zadacha69(2, 10));
}
void Zadacha64()
{
    Console.WriteLine("Введите число: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    HellpFullFunctions.PrintNormalNumbersInRange(numberM, numberN);

}
void Zadacha66()
{
    Console.WriteLine("Введите число: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(HellpFullFunctions.SumNormalNumbersInRange(numberM, numberN, 0));
}
void Zadacha68()
{
    Console.WriteLine("Введите число: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(HellpFullFunctions.AckermannFunc(numberM, numberN));
}
Zadacha68();
//Zadacha66();
//Zadacha64();
//Zadacha69a();
//Zadacha67();
//Zadacha65();
//Zadacha63();
//Zadacha58();
//Zadacha56();
//Zadacha54();
//Zadacha52();
//Zadacha50();
//Zadacha47();