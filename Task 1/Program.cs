//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.

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

void ShowNumbers(int number)
{
    if (number == 0){return;}
    System.Console.Write($"{number} ");
    ShowNumbers(number - 1);
    System.Console.Write($"{number} ");

}
int digit = 10;//Prompt("Введите число: ");
ShowNumbers(digit);
