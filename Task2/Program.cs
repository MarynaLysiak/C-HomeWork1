// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите число N1");
int N1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N2");
int N2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N3");
int N3 = Convert.ToInt32(Console.ReadLine());

if (N1 > N2 && N1 > N3)
{
    System.Console.WriteLine(N1);
}

else if (N2 > N3 && N2 > N1)
{
    System.Console.WriteLine(N2);
}
else 
{
    System.Console.WriteLine(N3);
}