// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите число  N1: ");
int N1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число  N2: ");
int N2 = Convert.ToInt32(Console.ReadLine());

if ( N1 > N2)
{
    Console.Write("N1 больше N2 ");
}
else if (N1 == N2)
{
    System.Console.Write("Числа равны ");
}
else
{
    Console.Write("N2 ,больше N1");
}