//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Please, enter integer values");
string x = Console.ReadLine();
string[] numbersStringArr = x.Split(' ');
int[] digits = new int[numbersStringArr.Length];
for(int i = 0; i < numbersStringArr.Length; i++)
{
    digits[i] = int.Parse(numbersStringArr[i]);
}
System.Console.WriteLine("Array: ");
foreach (int number in digits)//перебираем массив и выводим отдельно каждый элемент
{
    Console.Write(number);
}














//for(int i = 0; i < numbersString.Length; i++ )
//{
//    bool success = int.TryParse(numbersString[i], out digits[i]);
//    if(success)
//    {
//
//    }
//}