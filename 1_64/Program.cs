// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string NaturalNum (int M, int N)
{
    if(M<=N) return $"{M}"+ NaturalNum(M+1,N);
    else return string.Empty;
}
Console.WriteLine(NaturalNum(M,N));