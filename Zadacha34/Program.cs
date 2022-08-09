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
Zadacha38();
//Zadacha36();
//Zadacha34();