// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите числа A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степерь, в которую надо возвести число A: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Ответ: ");
int result = CalculatingDegree(a, b);


int CalculatingDegree(int a, int b)
{
    int x = 1;
    for(int i = 0; i< b; i++)
    { 
        x = x * a;
    }
Console.WriteLine(x);
return a;
}
