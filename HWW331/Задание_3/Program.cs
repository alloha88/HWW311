//  Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int numberA = 7;
int numberB = 9;
int [] getCubeOfNumber (int n)
{
    int[] arr = new int [n];

    for (int i = 1; i !=n+1; i++)
    {
        arr[i-1] = i * i * i;
    }
    return arr;
}

Console.WriteLine("{0} -> {1}",numberA, string.Join(",", getCubeOfNumber(numberA)));
Console.WriteLine("{0} -> {1}",numberB, string.Join(",", getCubeOfNumber(numberB)));