using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два числа:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int choice = 0;
        while (choice != 9)
        {
            Console.WriteLine("Выберите операцию (1-9):");
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Сложить два числа
                    int sum = firstNumber + secondNumber;
                    Console.WriteLine($"Результат: {sum}");
                    break;
                case 2: // Вычесть первое из второго
                    int diff = secondNumber - firstNumber;
                    Console.WriteLine($"Результат: {diff}");
                    break;
                case 3: // Перемножить два числа
                    int product = firstNumber * secondNumber;
                    Console.WriteLine($"Результат: {product}");
                    break;
                case 4: // Разделить первое на второе
                    if (secondNumber != 0)
                    {
                        double division = (double)firstNumber / secondNumber;
                        Console.WriteLine($"Результат: {division}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    break;
                case 5: // Возвести в степень N первое число
                    Console.WriteLine("Введите степень:");
                    int exponent = int.Parse(Console.ReadLine());
                    double power = Math.Pow(firstNumber, exponent);
                    Console.WriteLine($"Результат: {power}");
                    break;
                case 6: // Найти квадратный корень из числа
                    double squareRoot = Math.Sqrt(firstNumber);
                    Console.WriteLine($"Результат: {squareRoot}");
                    break;
                case 7: // Найти 1 процент от числа
                    double percent = firstNumber * 0.01;
                    Console.WriteLine($"Результат: {percent}");
                    break;
                case 8: // Найти факториал числа
                    int factorial = 1;
                    for (int i = 1; i <= firstNumber; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Результат: {factorial}");
                    break;
                case 9: // Выйти из программы
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный выбор операции.");
                    break;
            }
        }
    }
}