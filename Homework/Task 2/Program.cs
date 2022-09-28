//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

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

int SumOfElements(int firstNum, int secondNum)
{
    
    int sum = 0;
    if (firstNum == secondNum)
    {
        return firstNum;
        //return;
    }
    if (firstNum > secondNum)
    {
        sum+= firstNum + SumOfElements(firstNum-1,secondNum);
    }
    if (firstNum < secondNum)
    {
        sum += firstNum + SumOfElements(firstNum+1,secondNum);
    }
    return sum;

}
int firstNumber = Prompt("Введите первое число: ");
int secondNumber = Prompt("Введите второе число: ");

System.Console.WriteLine($"Сумма чисел в интервале от {firstNumber} до {secondNumber} равна {SumOfElements(firstNumber,secondNumber)}");