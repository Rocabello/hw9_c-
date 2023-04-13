// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
// int N = UserData("Введите число M: ");
// int M = UserData("Введите число N: ");
System.Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(Numbers(M-1, N));

//----------Метод
int Numbers(int M, int N)
{
    int sum = M;
    if (M == N) return 0;
    if (M <= N)
    {
        M++;
        sum = M + Numbers(M, N);
    }
    return sum;
}

// //---------Метод опроса пользователя
// int UserData(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }