// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.WriteLine($"Введите колличество чисел М: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[n];

void Input(int n)
{
    for(int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        massive[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Compar(int[] massive)
{
    int count = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i] > 0) count += 1;;
    }
    return count;
}

Input(n);
Console.WriteLine($"Введено чисел > 0: {Compar(massive)} ");