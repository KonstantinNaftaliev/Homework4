// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int result = SumAmountInNumber(a);

int SumAmountInNumber(int a)
{
    int sum = 0;
    int result = 0;
    int counter = Convert.ToString(a).Length;
    for (int i = 1; i <= counter; i++)
        {
            result = a % 10;
            sum = sum + result;
            a = a / 10;
        }
Console.Write(sum);
return a;
}