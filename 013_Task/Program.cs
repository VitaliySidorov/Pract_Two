// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int Digits(int num) // Определение количества разрядов числа
{
    if (num == 0) return 1;
    var dig = 0;
    while (num > 0)
    {
        num = num / 10;
        dig++;
    }

    return dig;
}

while (true)
{
    Console.Write("Введите любое целое число (от -2147483648 до 2147483647): ");
    string textNum = Console.ReadLine();
    if (int.TryParse(textNum, out int number)) // Проверка, что введенная строка есть число
    {
        int count = Digits(Math.Abs(number));  // Вызов метода Определения количества разрядов числа и исключаем знак (-)
        if (count < 3)
            Console.WriteLine("В вашем числе нет трех цифр.");
        else
        {
            int thirdPlace = count - 3;        // Вычисляем сколько разрядов нужно сдвинуть
            for (int i = 1; i <= thirdPlace; i++)
            {
                number = number / 10;
            }
            int thirdNum = Math.Abs(number % 10);
            Console.WriteLine($"Третья цифра числа {textNum} это {thirdNum}");
        }
        break;
    }
    Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
}