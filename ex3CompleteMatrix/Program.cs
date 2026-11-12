
using System.Security.Cryptography;

int ArraySize = 0;

Console.Write("Escolha a dimensão da matriz quadrada (digite apenas o número): ");
ArraySize = int.Parse(Console.ReadLine());

int[,] matrix = new int[ArraySize, ArraySize];

void GenerateMatrix()
{
    for (int i = 0; i < ArraySize; i++)
    {
        for (int j = 0; j < ArraySize; j++)
        {
            matrix[i, j] = RandomNumberGenerator.GetInt32(0, 10);
        }
    }
}

void ShowMatrix()
{
    for (int i = 0; i < ArraySize; i++)
    {
        for (int j = 0; j < ArraySize; j++)
        {
            Console.Write($"[{matrix[i, j]}]");
        }

        Console.WriteLine();
    }
}

void SumLines()
{
    for (int i = 0; i < ArraySize; i++)
    {
        int sum = 0;
        for (int j = 0; j < ArraySize; j++)
        {
            sum += matrix[i, j];
        }

        Console.WriteLine($"Soma referente à linha {i + 1}: {sum}");
    }
}


void SumColumns()
{
    for (int j = 0; j < ArraySize; j++)
    {
        int sum = 0;

        for (int i = 0; i < ArraySize; i++)
        {
            sum += matrix[i, j];
        }

        Console.WriteLine($"Soma referente à coluna {j + 1}: {sum}");
    }
}

void SumMainDiagonal()
{
    int sum = 0;

    for (int i = 0; i < ArraySize; i++)
    {
        sum += matrix[i, i];
    }

    Console.WriteLine($"Soma dos elementos da diagonal principal: {sum}");
}

void SumSecondaryDiagonal()
{
    int sum = 0;

    for (int i = 0; i < ArraySize; i++)
    {
        sum += matrix[i, ArraySize - 1 - i];
    }

    Console.WriteLine($"Soma dos elementos da diagonal secundária: {sum}");
}


GenerateMatrix();
Console.WriteLine("Matriz: ");
ShowMatrix();
Console.WriteLine("\nSoma dos elementos de cada linha: ");
SumLines();
Console.WriteLine("\nSoma dos elementos de cada coluna: ");
SumColumns();

Console.WriteLine();

SumMainDiagonal();
SumSecondaryDiagonal();

