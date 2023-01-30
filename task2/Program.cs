//  Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3->max = -3
Console.WriteLine("Вам нужно ввести 2 разных целых числа и программа выдаст максимальное и минимальное из них");//эта строка была добавлена для бОльшей коммуниккации между терминалом и пользователем
Console.WriteLine("Введите первое целое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numberB = int.Parse(Console.ReadLine());
int max = numberA;
if (numberA > numberB)
{
    Console.WriteLine("Ответ: ");
    Console.Write("a = ");
    Console.Write(numberA);
    Console.Write("; ");
    Console.Write("b = ");
    Console.Write(numberB);
    Console.Write(" -> ");
    Console.Write(" max = ");
    Console.Write(numberA);
    Console.Write(" , min = ");
    Console.Write(numberB);
}
if (numberA < numberB)
{
    Console.WriteLine("Ответ: ");
    Console.Write("a = ");
    Console.Write(numberA);
    Console.Write("; ");
    Console.Write("b = ");
    Console.Write(numberB);
    Console.Write(" -> ");
    Console.Write(" max = ");
    Console.Write(numberB);
    Console.Write(" , min = ");
    Console.Write(numberA);
}