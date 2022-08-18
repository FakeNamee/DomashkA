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
    public static int MinArrayValue(int[] array)
    {
        int MinValue = array[0];
        int MinIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < MinValue)
            {
                MinValue = array[i];
                MinIndex = i;
            }
        }
        return MinIndex;
    }

    public static int[,] SpyralArrayFill(int[,] array, int FillNumber, int i, int j, string direction)
    {
        array[i, j] = FillNumber++;
        if (FillNumber == (array.GetLength(0) * array.GetLength(1)))
        {
            return array;
        }
        else
        {
            if (direction == "right") // Если следующий элемент массива заполнен или выходит за пределы массива при движении вправо
            {
                if (j + 1 < array.GetLength(1) && array[i, j + 1] == -1)
                {
                    SpyralArrayFill(array, FillNumber, i, ++j, "right");
                    return array;
                }

                else
                {
                    SpyralArrayFill(array, FillNumber, ++i, j, "down");
                    return array;
                }
            }

            if (direction == "down") // Если следующий элемент массива заполнен или выходит за пределы массива при движении вниз
            {
                if (i + 1 < array.GetLength(0) && array[i + 1, j] == -1)
                {
                    SpyralArrayFill(array, FillNumber, ++i, j, "down");
                    return array;
                }

                else
                {
                    SpyralArrayFill(array, FillNumber, i, --j, "left");
                    return array;
                }
            }

            if (direction == "left") // Если следующий элемент массива заполнен или выходит за пределы массива при движении влево
            {
                if (j - 1 >= 0 && array[i, j - 1] == -1)
                {
                    SpyralArrayFill(array, FillNumber, i, --j, "left");
                    return array;
                }

                else
                {
                    SpyralArrayFill(array, FillNumber, --i, j, "up");
                    return array;
                }
            }

            if (direction == "up") // Если следующий элемент массива заполнен или выходит за пределы массива при движении вниз
            {
                if (array[i - 1, j] == -1)
                {
                    SpyralArrayFill(array, FillNumber, --i, j, "up");
                    return array;
                }

                else
                {
                    SpyralArrayFill(array, FillNumber, i, ++j, "right");
                    return array;
                }
            }
            return array;
        }
    }
}



