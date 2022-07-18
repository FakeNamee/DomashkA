Console.WriteLine("Введите число 1");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
double numberB = Convert.ToInt32(Console.ReadLine());
double result = 0;
for (double i = 0; i <= numberB; i++)
{
    result = Math.Pow(numberA, numberB);
}
Console.WriteLine("Ответ = " + result);