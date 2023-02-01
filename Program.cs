// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("введите числа:");
string? num=Console.ReadLine();
int[] mass=Array.ConvertAll(num.Split(),int.Parse);
int positive=0;
for(int i=0;i<mass.Length;i++)
{
    if(mass[i]>0)
    {
positive++;
    }
}
Console.WriteLine($"->{positive}");