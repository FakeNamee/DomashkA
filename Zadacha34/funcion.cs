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

    public static void PrintArrayDuo(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
        

    }
    public static void PrintArrayDuo(double[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
        

    }

    public static void FillArrayDuo(int[,] array, int startNumber = 0, int finishNumber = 10)
    {
        finishNumber++;
        Random random = new Random();
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(startNumber, finishNumber);
            }
        }
    }
    public static void FillArrayDuo(double[,] array, int startNumber = 0, int finishNumber = 10)
    {
        finishNumber++;
        Random random = new Random();
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(startNumber, finishNumber) + random.NextDouble();
            }
        }
    }
}


