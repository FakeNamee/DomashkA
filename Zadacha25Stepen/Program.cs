Console.Write("Введите натуральное число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 1; i <= b; i++)
{
    result = result * a;
}
if (result <= 0)
{
    Console.WriteLine("Введено ненатуральное число");
}
else
{
    Console.WriteLine("Ответ = " + result);
}
