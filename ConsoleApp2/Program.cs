namespace ConsoleApp1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            {
                while (true)
                {
                    Console.WriteLine("Выберите программу:");
                    Console.WriteLine("1. Найти среднее значение четырех чисел");
                    Console.WriteLine("2. Калькулятор");
                    Console.WriteLine("3. Конвертация температуры");
                    Console.WriteLine("4. Определить имя файла по пути");
                    Console.WriteLine("5. Найти самое длинное слово в предложении");
                    Console.WriteLine("6. Перемножить два массива значений");
                    Console.WriteLine("7. Найти максимальное и минимальное число из пяти введенных");
                    Console.WriteLine("8. Вывести 'пирамиду' из чисел");
                    Console.WriteLine("9. Вывести таблицу умножения");
                    Console.WriteLine("10. Конвертация температуры2");
                    Console.WriteLine("11. Выход");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            FindAverage(); break;
                        case "2":
                            Calculator();
                            break;
                        case "3":
                            TemperatureConverter();
                            break;
                        case "4":
                            GetFileName();
                            break;
                        case "5":
                            FindLongestWord(); break;
                        case "6":
                            MultiplyArrays();
                            break;
                        case "7":
                            FindMaxMin();
                            break;
                        case "8":
                            PrintPyramid();
                            break;
                        case "9":
                            Table();
                            break;
                        case "10":
                            TemperatureConverter2();
                            break;
                        case "11":
                            Console.WriteLine("Выход из программы."); return;
                        default:
                            Console.WriteLine("Неверный выбор, попробуйте снова.");
                            break;
                    }
                }
            }
            static void FindAverage()
            {
                Console.WriteLine("Введите четыре числа:");
                double[] numbers = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    numbers[i] = Convert.ToDouble(Console.ReadLine());
                }
                double average = numbers.Average();
                Console.WriteLine($"Среднее значение: {average}");
                Console.ReadLine();
                Console.Clear();
            }
            static void Calculator()
            {
                while (true)
                {
                    Console.WriteLine("Калькулятор");
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Сложение (+)");
                    Console.WriteLine("2. Вычитание (-)");
                    Console.WriteLine("3. Умножение (*)");
                    Console.WriteLine("4. Деление (/)");
                    Console.WriteLine("5. Нахождение остатка (%)");
                    Console.WriteLine("6. Выход");
                    string choice = Console.ReadLine();
                    if (choice == "6")
                    {
                        break;
                    }
                    Console.WriteLine("Введите первое число:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($"Результат: {num1} + {num2} = {num1 + num2}");
                            break;
                        case "2":
                            Console.WriteLine($"Результат: {num1} - {num2} = {num1 - num2}");
                            break;
                        case "3":
                            Console.WriteLine($"Результат: {num1} * {num2} = {num1 * num2}");
                            break;
                        case "4":
                            if (num2 != 0)
                            {
                                Console.WriteLine($"Результат: {num1} / {num2} = {num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                            }
                            break;
                        case "5":
                            Console.WriteLine($"Результат: {num1} % {num2} = {num1 % num2}");
                            break;
                        default:
                            Console.WriteLine("Неверный выбор, попробуйте снова."); break;
                            Console.ReadLine();
                            Console.Clear();
                    }
                }
            }
            static void TemperatureConverter()
            {
                Console.WriteLine("Выберите конвертацию:");
                Console.WriteLine("1. Цельсий в Фаренгейт");
                Console.WriteLine("2. Фаренгейт в Цельсий");
                Console.WriteLine("3. Цельсий в Кельвин");
                Console.WriteLine("4. Кельвин в Цельсий");
                string choice = Console.ReadLine(); double temperature;
                Console.WriteLine("Введите температуру:");
                temperature = Convert.ToDouble(Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        double fahrenheit = (temperature * 9 / 5) + 32;
                        Console.WriteLine($"{temperature}°C = {fahrenheit}°F"); break;
                    case "2":
                        double celsius = (temperature - 32) * 5 / 9;
                        Console.WriteLine($"{temperature}°F = {celsius}°C"); break;
                    case "3":
                        double kelvin = temperature + 273.15;
                        Console.WriteLine($"{temperature}°C = {kelvin}K"); break;
                    case "4":
                        double celsiusFromKelvin = temperature - 273.15;
                        Console.WriteLine($"{temperature}K = {celsiusFromKelvin}°C"); break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                        Console.ReadLine();
                        Console.Clear();
                }
            }
            static void GetFileName()
            {
                Console.WriteLine("Введите путь к файлу:");
                string path = Console.ReadLine();
                string fileName = System.IO.Path.GetFileName(path);
                Console.WriteLine($"Имя файла: {fileName}");
                Console.ReadLine();
                Console.Clear();
            }
            static void FindLongestWord()
            {
                Console.WriteLine("Введите предложение:");
                string sentence = Console.ReadLine();
                string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries); string longestWord = string.Empty;
                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
                Console.WriteLine($"Самое длинное слово: {longestWord}");
                Console.ReadLine();
                Console.Clear();
            }
            static void MultiplyArrays()
            {
                Console.WriteLine("Введите размер массивов:");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array1 = new int[size];
                int[] array2 = new int[size];
                int[] resultArray = new int[size];
                Console.WriteLine("Введите элементы первого массива:");
                for (int i = 0; i < size; i++)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите элементы второго массива:");
                for (int i = 0; i < size; i++)
                {
                    array2[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = array1[i] * array2[i];
                }
                Console.WriteLine("Результат перемножения массивов:");
                Console.WriteLine(string.Join(", ", resultArray));
                Console.ReadLine();
                Console.Clear();
            }
            static void FindMaxMin()
            {
                Console.WriteLine("Введите пять чисел:");
                int[] numbers = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = numbers[0];
                int min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                }
                Console.WriteLine($"Максимальное число: {max}"); Console.WriteLine($"Минимальное число: {min}");
                Console.ReadLine();
                Console.Clear();
            }
            static void PrintPyramid()
            {
                Console.WriteLine("Введите количество уровней пирамиды:");
                int levels = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= levels; i++)
                {
                    Console.WriteLine(new string(' ', levels - i) + string.Join(" ", new int[i].Select(x => i)));
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            static void Table()
            {
                Console.Write("Напечатать полную таблицу умножения.");
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write("{0}x{1}={2} ", new object[] { i, j, i * j });
                        }
                        Console.Write('\n');
                    }
                    Console.Read();
                }


            }
            static void TemperatureConverter2()
            {
                Console.WriteLine("Выберите тип:");
                Console.WriteLine("1. Цельсии в Кельвин");
                Console.WriteLine("2. Цельсии в Фаренгейт");
                Console.WriteLine("3. Кельвин в Цельсии");
                Console.WriteLine("4. Кельвин в Фаренгейт");
                Console.WriteLine("5. Фаренгейт в Цельсии");
                Console.WriteLine("6. Фаренгейт в Кельвин");

                Console.Write("Введите пожалуйста выбранный вами номер!)");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 6)
                {
                    Console.Write("Введите температуру:");
                    double temp = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"{temp} °C = {CelsiusToKelvin(temp)} °K");
                            break;
                        case 2:
                            Console.WriteLine($"{temp} °C = {CelsiusToFahrenheit(temp)} °F");
                            break;
                        case 3:
                            Console.WriteLine($"{temp} °C = {KelvinToFahrenheit(temp)} °F");
                            break;
                        case 4:
                            Console.WriteLine($"{temp} °C = {KelvinToCelsius(temp)} °C ");
                            break;
                        case 5:
                            Console.WriteLine($"{temp} °C = {FahrenheitToCelsius(temp)} °C ");
                            break;
                        case 6:
                            Console.WriteLine($"{temp} °C = {FahrenheitToKelvin(temp)} °K");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверно выбрано!");
                }

            }
            static double CelsiusToKelvin(double celsius)
            {
                return celsius + 273.15;
            }

            static double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            static double KelvinToCelsius(double kelvin)
            {
                return kelvin - 273.15;
            }

            static double KelvinToFahrenheit(double kelvin)
            {
                return CelsiusToFahrenheit(KelvinToCelsius(kelvin));
            }

            static double FahrenheitToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }

            static double FahrenheitToKelvin(double fahrenheit)
            {
                return CelsiusToKelvin(FahrenheitToCelsius(fahrenheit));
            }
        }

    }
}


