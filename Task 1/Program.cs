// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumberA = Prompt("Введите первое число - ");
int NumberB = Prompt("Введите второе число - ");
int NumberC = 1;

int Prompt(string message)
{
    Console.Write(message);
    int N = int.Parse(Console.ReadLine()!);
    return N;
}

Math(NumberA, NumberB, NumberC);

void Math(int NumberA, int NumberB, int NumberC)
{
    for (int i = 0; i < NumberB; i++)
    {
         NumberC = NumberC*NumberA;
    }
    Console.Write($"Если возвести число {NumberA} в степень {NumberB} получится {NumberC}");
}