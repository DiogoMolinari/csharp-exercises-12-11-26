/*Exercício 2: Faça um programa que gere uma matriz 3x5 populada automaticamente e baseado nela, gere uma nova matriz inversa (5x3).*/

using System.Security.Cryptography;

int[,] NormalMatrix = new int[3, 5];
int[,] InvertedMatrix = new int[3, 5];
int[,] TransposedMatrix = new int[5, 3];


void GenerateMatrix()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            NormalMatrix[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }
    }
}

void TransposeMatrix()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            TransposedMatrix[j, i] = NormalMatrix[i, j];
        }
    }
}

void InvertMatrix()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            InvertedMatrix[i, j] =
                NormalMatrix[2 - i, 4 - j];
        }
    }
}


void ShowMatrices()
{
    Console.WriteLine("Matriz original (3x5):");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"[{NormalMatrix[i,j]}]");
        }
        Console.Write("\n");
    }

    Console.Write("\n");

    Console.WriteLine("Matriz transposta (5x3):");
    for (int i = 0; i < 5; i++)
    { 
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"[{TransposedMatrix[i,j]}]");
        }
        Console.Write("\n");
    }

    Console.Write("\n");

    Console.WriteLine("Matriz invertida (ao contrário): ");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"[{InvertedMatrix[i, j]}]");
        }
        Console.Write("\n");
    }

    Console.Write("\n");
}

GenerateMatrix();
TransposeMatrix();
InvertMatrix();
ShowMatrices();

