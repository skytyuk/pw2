
menu:

Console.WriteLine("Выберите программу, которую хотите запустить");
Console.WriteLine("1. Игра \"Угадай число\" ");
Console.WriteLine("2. Таблица умножения");
Console.WriteLine("3. Вывод делителей числа");
Console.WriteLine("4. ВЫЙТИ");

byte k = 0;
k = Convert.ToByte(Console.ReadLine());


switch (k)
{
    case 1:
        {
            Random randmaizer = new Random();

            int rnumber = randmaizer.Next(1, 100);
            int i = 1;

            Console.WriteLine("Угадай число от 1 до 100");
            Console.WriteLine("Введите число: ");


            while (i != rnumber)
            {
                i = Convert.ToInt32(Console.ReadLine());

                if (i < 1 || i > 100)
                {
                    Console.WriteLine("Ошибка: Число не входит в заданный предел от 1 до 100");
                }
                else
                {
                    if (i == rnumber)
                    {
                        Console.WriteLine("Прямо в цель! Ты угадал, поздравляю");
                    }
                    else if (i < rnumber)
                    {
                        Console.WriteLine("Мало");
                    }
                    else
                    {
                        Console.WriteLine("Много");
                    }
                }
            }
            goto menu;
            break;
        }
    case 2:
        {
            var mas = new int[10, 10];
            
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    mas[i, j] = i * j;
                }
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0, 5}", mas[i, j]);
                }
                Console.WriteLine();
            }
            goto menu;
            break;
        }
    case 3:
        {
            int w = 1;
            while (w == 1)
            {
                Int32 number;

                Console.WriteLine("Введите число или же напишите \"выйти\" для выхода:");

                string e = Console.ReadLine();

                if (e == "выйти")
                    goto menu;
                else
                    number = Convert.ToInt32(e);
                
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                        Console.Write("{0,0} ", i);
                }
                Console.WriteLine();
            }
                break;
        }
    case 4:
        {
            Console.WriteLine();

            break;
        }

    default:
        {
            Console.WriteLine("Ошибка: Вы ввели неподходящий номер операции, введите число от 1 до 4");

            goto menu;
            break;
        }
}
