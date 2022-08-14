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
        Console.WriteLine($"Среднее арифметическое столбца {i+1}: {result}");
    }
}
//Zadacha52();
//Zadacha50();
//Zadacha47();