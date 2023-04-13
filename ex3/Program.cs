// Выполнить с помощью рекурсии.
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();
System.Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
CheckNum(m,n);


//-----Аккерман
int Accerman(int m, int n){
    if(m == 0) return n+1;
    else if(n == 0) return Accerman(m-1,1);
    else return Accerman(m-1, Accerman(m, n-1));
    return Accerman(m,n);
}

//---Положительное число
void CheckNum(int m, int n){
    if( m > 0 && n > 0) System.Console.WriteLine($"Функция Аккермана: {Accerman(m,n)}");
    else System.Console.WriteLine("Введены отрицательные числа. Повторите ввод заново.");
}