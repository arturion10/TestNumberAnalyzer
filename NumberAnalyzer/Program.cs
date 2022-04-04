
// Первое задание
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Введите число: ");
bool isValidNumber = int.TryParse(Console.ReadLine(), out var number);
while (!isValidNumber)
{
    
    Console.Write("Ошибка ввода. Введите число: ");
    isValidNumber = int.TryParse(Console.ReadLine(), out number);
}

if(number % 2 == 0)
{
    Console.WriteLine($"Число {number}: Четное");
}
else
{
    Console.WriteLine($"Число {number}: нечетное");
}

var stringNumber = number.ToString();
if ("7" == stringNumber.Substring(stringNumber.Length - 1))
{
    Console.WriteLine($"Последняя цифра числа {number} = 7");
}
else
{
    Console.WriteLine($"Последняя цифра числа {number} != 7");
}

// Второе задание
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Введите двузначное число: ");
bool isValidTwoNumber = int.TryParse(Console.ReadLine(), out var twoNumber);
while (!isValidTwoNumber || twoNumber.ToString().Length != 2)
{
    if (!isValidTwoNumber)
    {
        Console.Write("Ошибка ввода. Введите двузначное число: ");
        isValidTwoNumber = int.TryParse(Console.ReadLine(), out twoNumber);
    }
    else
    {
        Console.Write("Ошибка ввода. Введите двузначное число: ");
        isValidTwoNumber = int.TryParse(Console.ReadLine(), out twoNumber);
    }
}

if(-1 != twoNumber.ToString().IndexOf('2') && -1 != twoNumber.ToString().IndexOf('7'))
{
    Console.WriteLine($"В числе {twoNumber} есть числа 2 и 7");
}
else if(-1 != twoNumber.ToString().IndexOf('2'))
{
    Console.WriteLine($"В числе {twoNumber} есть число 2");
}
else if (-1 != twoNumber.ToString().IndexOf('7'))
{
    Console.WriteLine($"В числе {twoNumber} есть число 7");
}
else
{
    Console.WriteLine($"В числе {twoNumber} нет чисел 2 и 7");
}
var firstNumber = twoNumber / 10;
var secondNumber = twoNumber % 10;
var sumTwoNumber = firstNumber + secondNumber;
Console.WriteLine($"Сумма двух чисел {twoNumber} = {sumTwoNumber}");
if(sumTwoNumber.ToString().Length == 2)
{
    Console.WriteLine($"Число {sumTwoNumber}: двузначное");
}
else
{
    Console.WriteLine($"Число {sumTwoNumber}: не является двузначным");
}
Console.WriteLine("Введите число для сравнения с сумой чисел: ");
bool isValidNumber2 = int.TryParse(Console.ReadLine(), out var number2);
while (!isValidNumber2)
{
    Console.Write("Ошибка ввода. Введите число: ");
    isValidNumber2 = int.TryParse(Console.ReadLine(), out number2);
}
if(number2 < sumTwoNumber)
{
    Console.WriteLine("Сумма двух числе больше нового введенного числа");
}
else
{
    Console.WriteLine("Сумма двух числе меньше или равно новому введенному числу");
}
//3ее задание
Console.ForegroundColor = ConsoleColor.Blue;
var listNumbers = new List<int>();
Console.Write("Введите 3 числа через Enter: ");
bool isValidNumber3;
int number3;
for (int i = 0; i < 3; i++)
{
    isValidNumber3 = int.TryParse(Console.ReadLine(), out number3);
    while (!isValidNumber3)
    {
        if (!isValidNumber3)
        {
            Console.Write("Ошибка ввода. Введите число повторно: ");
            isValidNumber3 = int.TryParse(Console.ReadLine(), out number3);
        }
        else
        {
            Console.Write("Ошибка ввода. Введите двузначное число: ");
            isValidNumber3 = int.TryParse(Console.ReadLine(), out number3);
        }
    }
    listNumbers.Add(number3);
}
var sortedListNumbers =  listNumbers.OrderBy(number => number);
Console.WriteLine($"Произведение двух наименьших из трех чисел = " +
                  $"{sortedListNumbers.ElementAt(0) * sortedListNumbers.ElementAt(1)}");

// 4ое задание
Console.ForegroundColor = ConsoleColor.White;
var dayWeek = ((int)new DateTime().DayOfWeek);
PrintMessage(dayWeek, PrintMessageDayWeekOption.Now);
Console.Write("Введите порядковый номер недели 1-7: ");
bool isValidNumber4 = int.TryParse(Console.ReadLine(), out var number4);
while (!isValidNumber4 && 1 <= number4 && number4 <= 7)
{

    Console.Write("Ошибка ввода. Введите число от 1 до 7 включительно: ");
    isValidNumber4 = int.TryParse(Console.ReadLine(), out number4);
}
PrintMessage(number4, PrintMessageDayWeekOption.MyChose);


void PrintMessage(int dayTime, PrintMessageDayWeekOption Chose)
{
    if(Chose == 0)
    {
        switch (dayTime)
        {
            case (int)DayWeek.Monday:
                Console.WriteLine("Сегодня понедельник!");
                break;
            case (int)DayWeek.Tuesday:
                Console.WriteLine("Сегодня вторник!");
                break;
            case (int)DayWeek.Wednesday:
                Console.WriteLine("Сегодня среда!");
                break;
            case (int)DayWeek.Thursday:
                Console.WriteLine("Сегодня четверг!");
                break;
            case (int)DayWeek.Friday:
                Console.WriteLine("Сегодня пятница!");
                break;
            case (int)DayWeek.Saturday:
                Console.WriteLine("Сегодня суббота!");
                break;
            case (int)DayWeek.Sunday:
                Console.WriteLine("Сегодня воскресенье!");
                break;
        }
    }
    else
    {
        switch (dayTime-1)
        {
            case (int)DayWeek.Monday:
                Console.WriteLine("Ваш выбор понедельник!");
                break;
            case (int)DayWeek.Tuesday:
                Console.WriteLine("Ваш выбор вторник!");
                break;
            case (int)DayWeek.Wednesday:
                Console.WriteLine("Ваш выбор среда!");
                break;
            case (int)DayWeek.Thursday:
                Console.WriteLine("Ваш выбор четверг!");
                break;
            case (int)DayWeek.Friday:
                Console.WriteLine("Ваш выбор пятница!");
                break;
            case (int)DayWeek.Saturday:
                Console.WriteLine("Ваш выбор суббота!");
                break;
            case (int)DayWeek.Sunday:
                Console.WriteLine("Ваш выбор воскресенье!");
                break;
        }
    }

}

enum DayWeek : int
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}

enum PrintMessageDayWeekOption
{
    Now,
    MyChose
}