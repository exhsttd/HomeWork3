using System;
class Program
{
    public enum Cards // Задание 2
    {
        Шестёрка = 6,
        Семёрка = 7,
        Восьмёрка = 8,
        Девятка = 9,
        Десятка = 10,
        Валет = 11,
        Дама = 12,
        Король = 13,
        Туз = 14
    }
    public enum Week // Задание 4
    {
        понедельник = 1,
        вторник,
        среда,
        четверг,
        пятница,
        суббота,
        воскресенье
    }

    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }

    static void Task1()
    {
        // Задание 1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность
        // упорядоченной по возрастанию. В случае отрицательного ответа определить
        // порядковый номер первого числа, которое нарушает данную последовательность.
        // Использовать break.
        Console.WriteLine("Задание 1");
        int[] numbers = new int[10];
        Console.WriteLine("Введите 10 чисел:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        bool vseOk = true;
        int neOkIndex = -1;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                vseOk = false;
                neOkIndex = i + 1;
                break;
            }
        }

        if (vseOk)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine(
                $"Последовательность неупорядочена. Первый нарушитель находится на позиции: {neOkIndex + 1}.");
        }
    }
    
    static void Task2()
    {
        // Задание 2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
        // их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
        // Порядковые номера остальных карт соответствуют их названиям («шестерка»,
        // «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
        // соответствующей карты.
        Console.WriteLine("Задание 2");
        try
        {
            Console.WriteLine("Введите номер карты: число от 6 до 14");

            int cardvalue = int.Parse(Console.ReadLine());
            while (6 > cardvalue || 14 < cardvalue)
            {
                Console.WriteLine("Введите целое число от 6 до 14!");
                cardvalue = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Ваша карта - {(Cards)cardvalue}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Введите целое число от 6 до 14!");
        }
        finally
        {
            Console.WriteLine("Благодарим за участие!");
        }
    }

    static void Task3()
    {
        // Задание 3. Напишите программу, которая принимает на входе строку и производит выходные
        // данные в соответствии с таблицей
        Console.WriteLine("Задание 3");
        Console.WriteLine("Введите профессию: ");
        string profession = Console.ReadLine();
        {
            switch (profession.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Неизвестная профессия. Попробуйте пиво.");
                    break;
            }
        }
    }

    static void Task4()
    {
        // Задание 4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
        // ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
        // Использовать enum.
        Console.WriteLine("Задание 4");
        Console.WriteLine("Введите порядковый номер дня недели от 1 до 7");
        string day;
        while (true)
        {
            day = Console.ReadLine();
            if (!byte.TryParse(day, out byte dayNumber))
            {
                Console.WriteLine("Введите порядковый номер дня недели от 1 до 7");
            }
            else if (1 > dayNumber || 7 < dayNumber)
            {
                Console.WriteLine("Введите порядковый номер дня недели от 1 до 7");
            }
            else
            {
                Console.WriteLine($"{dayNumber} день недели - {(Week)dayNumber}");
                break;
            }
        }
    }
    static void Task5()
    {
        // Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
        // "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
        // результату. Вывести на экран сколько кукол в “сумке”.
        Console.WriteLine("Задание 5");
        Console.WriteLine("Сколько игрушек вы хотите положить в сумку?");
        int count = int.Parse(Console.ReadLine()); 
        string[] toys = new string[count]; 
        
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите название игрушки {i + 1}: ");
            Console.WriteLine($"Например: Barbie doll или Hello Kitty");
            toys[i] = Console.ReadLine().ToLower();
        }
        
        int bag = 0;
        foreach (var toy in toys)
        {
            if (toy == "hello Kitty" || toy == "barbie doll")
            {
                bag++;
            }
        }
        Console.WriteLine($"Количество кукол в сумке: {bag}");
    }
}
   

      
  
        
    