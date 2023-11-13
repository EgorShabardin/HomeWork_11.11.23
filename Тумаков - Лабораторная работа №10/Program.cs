using System;

namespace Тумаков___Лабораторная_работа__10
{
    class Program
    {
        static void Main()
        {
            bool tasksEnd = false;
            string taskNumber;

            do
            {
                Console.WriteLine("{0, 88}", "ТУМАКОВ - ЛАБОРАТОРНАЯ РАБОТА №10. МЕНЮ ЗАДАНИЙ\n");
                Console.WriteLine("Подсказка:\n" +
                                  "Упражнение 10.1. Программа кодирует и декодирует передаваемые сообщения                                     -   цифра 1\n" +
                                  "Домашнее задание 10.1. Программа создает геометрические фигуры и реализует с ними различные действия        -   цифра 2\n" +
                                  "Закончить выполнение заданий и выйти из программы                                                           -   цифра 0\n");

                Console.Write("Введите номер задания: ");
                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "1":
                        // Упражнение 10.1. Программа кодирует и декодирует передаваемые сообщения.
                        Console.Clear();
                        Console.WriteLine("{0, 100}", "УПРАЖНЕНИЕ 10.1. ПРОГРАММА КОДИРУЕТ И ДЕКОДИРУЕТ ПЕРЕДАВАЕМЫЕ СООБЩЕНИЯ\n");

                        Console.WriteLine("Первый способ шифрования");
                        Console.Write("Введите строку для шифорвания: ");

                        ACipher firstMessage = new ACipher(Console.ReadLine());
                        firstMessage.Encode();
                        Console.WriteLine($"Сообщение зашифровано: {firstMessage.Message}");

                        firstMessage.Decode();
                        Console.WriteLine($"Сообщение расшифровано: {firstMessage.Message}");

                        Console.WriteLine("\nВторой способ шифрования");
                        Console.Write("Введите строку для шифорвания: ");

                        BCipher secondMessage = new BCipher(Console.ReadLine());
                        secondMessage.Encode();
                        Console.WriteLine($"Сообщение зашифровано: {secondMessage.Message}");

                        secondMessage.Decode();
                        Console.WriteLine($"Сообщение расшифровано: {secondMessage.Message}");

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        // Домашнее задание 10.1. Программа создает геометрические фигуры и реализует с ними различные действия.
                        Console.Clear();
                        Console.WriteLine("{0, 112}", "ДОМАШНЕЕ ЗАДАНИЕ 10.1. ПРОГРАММА СОЗДАЕТ ГЕОМЕТРИЧЕСКИЕ ФИГУРЫ И РЕАЛИЗУЕТ С НИМИ РАЗЛИЧНЫЕ ДЕЙСТВИЯ\n");

                        Point point = new Point("red", true);
                        Circle circle = new Circle(10, "blue", false);
                        Rectangle rectangle = new Rectangle(5, 10.3, "yellow", true);

                        point.DisplayingFigureData();
                        circle.DisplayingFigureData();
                        rectangle.DisplayingFigureData();
                        Console.WriteLine();

                        point.ChangingColorOfFigure("yellow");
                        circle.ChangingColorOfFigure("black");
                        rectangle.ChangingColorOfFigure("white");

                        point.FigureStatusSurvey();
                        circle.FigureStatusSurvey();
                        rectangle.FigureStatusSurvey();
                        Console.WriteLine();

                        point.MovementHorizontally();
                        circle.MovementHorizontally();
                        circle.MovementHorizontally();
                        rectangle.MovementVertically();

                        circle.CalculationOfArea();
                        rectangle.CalculationOfArea();
                        Console.WriteLine();

                        point.DisplayingFigureData();
                        circle.DisplayingFigureData();
                        rectangle.DisplayingFigureData();
                        Console.WriteLine();

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("{0, 71}", "ВЫ ВЫШЛИ ИЗ ПРОГРАММЫ");
                        tasksEnd = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("{0, 103}", "ТАКОГО ЗАДАНИЯ НЕТ! ДОСТУПНЫЕ ЗАДАНИЯ УКАЗАНЫ В ПОДСКАЗКЕ. ПОВТОРИТЕ ПОПЫТКУ\n");
                        break;
                }
            } while (!tasksEnd);
        }
    }
}
