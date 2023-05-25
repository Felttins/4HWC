// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 - 11
// 82 -> 10
// 9012 -> 12

int Number = Prompt("Введите число - ");
int Summ = 0;

int Prompt(string message)
{
    Console.Write(message);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}

Math(Number, Summ);

void Math(int Number, int Summ)
{
        while (Number%10>0 || Number/10>0)
        {
            Summ = Summ + Number%10;
            Number = Number/10;
        }
        Console.WriteLine($"Сумма цифр равна {Summ} ");
}