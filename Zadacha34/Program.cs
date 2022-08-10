//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве
using Metod;

void Zadacha34()
{
    int evencount = 0;
    int size = 9;
    int[] array = new int[size];
    HellpFullFunctions.FillArray(array, 100, 300);
    HellpFullFunctions.PrintArray(array);
    foreach (int num in array)
    {
        if (num % 2 == 0)
        {
            evencount++;
        }
    }
    Console.WriteLine("Количество чётных числе " + evencount);
}

void Zadacha36()
{
    int size = 9;
    int[] array = new int[size];
    int Sum = 0;
    HellpFullFunctions.FillArray(array, 10, 20);
    HellpFullFunctions.PrintArray(array);

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Sum = Sum + array[i];
            i++;
        }

    }
    Console.WriteLine("Сумма равна = " + Sum);
}
void Zadacha38()
{
    int size = 9;
    double[] array = new double[size];
    HellpFullFunctions.FillArray(array, 10, 20);
    HellpFullFunctions.PrintArray(array);
    Console.WriteLine();
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)

        {
            min = array[i];
        }

    }
    Console.WriteLine("Минимальное число = " + min);
    Console.WriteLine("Максимальное число = " + max);
    result = max - min;
    Console.WriteLine("Разница между минимальным и максимальны = " + result);

}

void Zadacha41()
{
    int[] array = new int[5];
    Console.WriteLine("Введите 5 чисел ");
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            result++;
        }


    }
    Console.WriteLine("Количество чисел больше нуля = " + result);
}

void Zadacha43()

{
    Console.WriteLine("Введите B1");
    double numberB1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите K1");
    double numberK1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите B2");
    double numberB2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите K2");
    double numberK2 = Convert.ToDouble(Console.ReadLine());
    double numberX0 = 0;
    double numberY0 = 0;
    if (numberK1 - numberK2 == 0)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        numberX0 = (numberB2 - numberB1) / (numberK1 - numberK2);
        numberY0 = (numberK2 * numberX0) + numberB2;
    }
    Console.WriteLine("Пересекаются в координатах " + numberX0 + " " + numberY0 );
}

//Zadacha38();
//Zadacha36();
//Zadacha34();
//Zadacha41();
Zadacha43();