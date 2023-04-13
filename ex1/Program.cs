// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




Console.Clear();
UserData("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Numbers(N,1));

//----------Метод
string Numbers(int N, int end){
    if (N==1) return N.ToString();
    return (N + " " + Numbers(N-1, end));
}

//---------Метод опроса пользователя
void UserData(string message){
    System.Console.WriteLine($"{message}");
}