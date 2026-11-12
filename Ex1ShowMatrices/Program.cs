/*Exercício 1: Faça um programa que crie uma matriz de números inteiros na quantidade de linhas e colunas que o usuário informar. 
Essa matriz deve ser populada automaticamente e ser exibida do primeiro ao último e do último para o primeiro.*/

using System.Security.Cryptography;

int qntLines = 0 , qntColumns = 0;

Console.Write("Digite a quantidade de linhas que sua matriz deverá ter: ");
qntLines = int.Parse(Console.ReadLine());

Console.Write("Agora digite a quantidade de colunas que sua matriz deverá ter: ");
qntColumns = int.Parse(Console.ReadLine());

int[,] matrix = new int[qntLines, qntColumns];void PopulateMatrix()
{ 
    for (int i = 0; i < qntLines; i++)
    {
        for (int j = 0; j < qntColumns; j++)
        {
            matrix[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }
    }
}

void ShowNormalMatrix()
{
    Console.WriteLine("Valores retirados da matriz normal: ");
    for (int i = 0; i < qntLines; i++)
    {
        for (int j = 0; j < qntColumns; j++)
        {
            Console.Write($"[{matrix[i, j]}]");
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}

void ShowInvertedMatrix()
{
    Console.WriteLine("Matriz apresentada do último ao primeiro item (invertida): ");
    for (int i = qntLines-1; i >= 0; i--)
    {
        for (int j = qntColumns-1; j >= 0; j--)
        {
            
            Console.Write($"[{matrix[i, j]}]");
        }
        Console.Write("\n");
    }
    
    }

PopulateMatrix();
ShowNormalMatrix();
Console.Write("\n");
ShowInvertedMatrix();
