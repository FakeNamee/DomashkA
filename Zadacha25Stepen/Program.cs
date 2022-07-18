Console.WriteLine("Введите натуральное число 1");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число 2");
double numberB = Convert.ToInt32(Console.ReadLine());
double result = 0;
for (double i = 0; i <= numberB; i++)
{
    result = Math.Pow(numberA, numberB);
}
if (result <= 0)
{
    Console.WriteLine("Введено ненатуральное число");
}
else
{
    Console.WriteLine("Ответ = " + result);
}
