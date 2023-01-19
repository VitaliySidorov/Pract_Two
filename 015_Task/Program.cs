// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
while (true)
{
    Console.Write("Введите номер дня недели (1-7) : ");
    string textNum = Console.ReadLine();
    if (int.TryParse(textNum, out int number) && (number > 0) && (number < 8)) // Проверка, что введенная строка есть число и оно соответствует условию
    {
        if (number == 6 || number == 7)
            Console.WriteLine($"{number}-й день - выходной.");
        else Console.WriteLine($"{number}-й день - рабочий.");
        break;
    }
    Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
}