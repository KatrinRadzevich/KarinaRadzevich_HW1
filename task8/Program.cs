// Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("При вводе числа программа покажет,все чётные числа от 1 до N");
Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());
int count = 2;
Console.WriteLine("Ответ: ");
Console.Write(N);
Console.Write(" -> ");
while (count <= N)
{

    Console.Write(count);
    count = count + 2;
    if (count <= N)
    {
        Console.Write(", ");
    }

}
