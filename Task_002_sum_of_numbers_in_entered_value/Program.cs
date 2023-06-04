//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11
// Console.Clear();
// Console.WriteLine("Please, enter the integer value");
// string x = Console.ReadLine();
// string[] numbersString = x.Split(' ');
// int sumOfNumbers = 0;
// int [] digits = new int[numbersString.Length];
// for(int i = 0; i < digits.Length; i++ )
// {
//     bool success = int.TryParse(numbersString[i], out digits[i]);
//     if(success)
//     {
//         sumOfNumbers = sumOfNumbers + digits[i];
//     }
//     else
//     {
//     Console.WriteLine("Please, enter the integer value");
//     break;
//     }
// }
// Console.WriteLine(sumOfNumbers);


/*Console.Clear();
Console.WriteLine("Please, enter integer values");
string x = Console.ReadLine();
string[] numbersString = x.Split(' ');
int sumOfNumbers = 0;
int[] digits = new int[numbersString.Length];
for(int i = 0; i < numbersString.Length; i++ )
{
    bool success = int.TryParse(numbersString[i], out digits[i]);
    if(success)
    {
        sumOfNumbers += digits[i];
    }
    else
    {
        Console.WriteLine("Please, enter only integer values.");
        break;
    }
}
Console.WriteLine(sumOfNumbers);*///Вовод здесь - сумма знаков, как строка а не сумма значенй значений в едином числе, не понимаю, что нет так я сделал!
//Если дочитаете до сюда, расскажите, пожалуйста))

Console.Clear();
Console.Write("Please, enter integer value: ");
bool success = int.TryParse(Console.ReadLine(), out int number);
int sum = 0;
if(success)
{
    while(number > 0)
    {
        int digit = number % 10;//переменной digit присваиваем последнюю цифру в значении number
        sum += digit;
        number /= 10;//Убираем последнюю цифру в введеном значении.
        //при появлении нецелого числа (0,7 например)ToInt32, переменная number = 0
    }
    Console.WriteLine("Sum of numbers = " + sum);
}
else
{
    Console.WriteLine("Please, enter only integer values.");
    return;
}





