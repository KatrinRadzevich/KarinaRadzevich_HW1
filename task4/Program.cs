// Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите 3 разных целых числа и программа выдаст максимальное из них");//эта строка была добавлена для бОльшей коммуниккации между терминалом и пользователем
Console.WriteLine("Введите первое целое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine("Ответ: ");
Console.Write(numberA);
Console.Write(", ");
Console.Write(numberB);
Console.Write(", ");
Console.Write(numberC);
Console.Write(" -> ");
Console.Write(max);