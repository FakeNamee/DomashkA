namespace Metod;

public static class HellpFullFunctions
{
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public static void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }


    public static void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
    {
        finishNumber++;
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNumber, finishNumber);
        }
    }

    public static void FillArray(double[] array, int startNumber = -10, int finishNumber = 10)
    {
        finishNumber++;
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNumber, finishNumber) + random.NextDouble();


        }
    }

    public static void SortArray(int[] array)
    {
        int max;
        for (int i = 0; i < array.Length; i++)
        {

            for (int j = 0; j < array.Length - 1; j++)
            {
                if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
                {
                    max = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = max;

                }
            }
        }
    }

    public static void PrintArrayDuo(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void FillArrayDuo(int[,] matr, int startNumber, int finishNumber)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(startNumber, finishNumber);
            }
        }
    }
}

