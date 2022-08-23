// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coeff = new double[2, 2];
double[] cross = new double[2];

void Input()
{
    for( int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэфециенты {i + 1}-го уравнения (y = k * x + b): ");
        Console.WriteLine();
        for( int j = 0; j < coeff.GetLength(1); j++)
        {
            if(j == 0) Console.Write("Введите коэфециент k: ");
            else Console.Write("Введите коэфециент b: ");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coeff)
{
    cross[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    cross[1] = cross[0] * coeff[0, 0] + coeff[0, 1];
    return cross;
}

void Output(double[,] coeff)
{
    if(coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"Прямые совпдают.");
    }
    else if(coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.Write($"Прямые паралельны.");
    }
    else
    {
        Decision(coeff);
        Console.Write($"Точка пересечения прямых: ({cross[0]} X {cross[1]})");
    }
}

Input();
Output(coeff);