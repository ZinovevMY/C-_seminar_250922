//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else 
        if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else 
        if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return n + 1;
}

int mNumber = Prompt("Введите число m: ");
int nNumber = Prompt("Введите число n: ");

System.Console.WriteLine($"Результат вычисления функции Аккермана равен {Akkerman(mNumber,nNumber)}");
