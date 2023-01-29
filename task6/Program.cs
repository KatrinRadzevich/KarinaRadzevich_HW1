//  Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("При вводе числа программа покажет,является ли целое число четным");
Console.WriteLine("Введите целое число");
int numberA = int.Parse(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine("Ответ: ");
    Console.Write(numberA);
    Console.Write(" -> ");
    Console.Write("да");
}
if (numberA % 2 == 1)
{
    Console.WriteLine("Ответ: ");
    Console.Write(numberA);
    Console.Write(" -> ");
    Console.Write("нет");
}