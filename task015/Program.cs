// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend (int num)
{
    if (num > 0 & num < 6)
    {
        Console.WriteLine("Это рабочий день.");
    }
    else if (num == 6 || num == 7)
    {
        Console.WriteLine("Это ВЫХОДНОЙ день!");
    }
    else
    {
        Console.WriteLine("Такого дня в неделе нет.");
    }
}
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
Weekend (num);