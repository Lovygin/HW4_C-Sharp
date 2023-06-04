//Enter two values x/y.To raise a number x to a power of a number y. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Rasing - возведение, a power of a number - степень числа?
Console.Clear();
Console.WriteLine("Please, enter the value 'x' you want to raise to a power");
bool success1 = double.TryParse(Console.ReadLine(), out double x);
if(success1)
{
    Console.WriteLine("Please, enter the value 'y' you want to raise the number to 'x'");
    bool success2 = double.TryParse(Console.ReadLine(), out double y);
    if(success2)
    {
        double result = Math.Pow(x, y);
        Console.WriteLine(result);
        return;

    }
    Console.WriteLine("Please, enter the integer or fractional value");
    return;

}
Console.WriteLine("Please, enter the integer or fractional value");
return;