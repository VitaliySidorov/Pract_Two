// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
while (true)
{
    Console.Write("Введите трехзначное число: ");
    string textNum = Console.ReadLine();
    if (int.TryParse(textNum, out int number) && (number > 99) && (number < 1000))
    {
        int dig = (number / 10) % 10;
        Console.WriteLine($"Вы ввели число {number}, вторая цифра этого числа {dig}.");
        break;
    }
    Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
}
   