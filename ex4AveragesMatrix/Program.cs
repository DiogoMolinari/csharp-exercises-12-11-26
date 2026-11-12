/*Exercício 4: Faça um programa que gere o boletim escolar de um aluno. 
Critérios: as linhas são as matérias, as colunas são as notas de cada bimestre mais a 
média e a situação do aluno em cada matéria.
Aprovado se a média for maior ou igual a 7; 
Recuperação se a média for entre 5.1 e 6.9; 
Reprovado se a média for menor ou igual a 5.*/

string[] subjects = { "Matéria 1", "Matéria 2", "Matéria 3", "Matéria 4", "Matéria 5" };
double[,] grades = new double[5, 4];
double[,] gradesAndAverages = new double[5, 5];
double[] average = new double[5];
string[] status = new string[5];

void GenerateGrades()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"Digite a nota da {subjects[i]} no {j + 1} bimestre: ");
            grades[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    }
}

void CalculateAverage()
{
    for (int i = 0; i < 5; i++)
    {
        double sum = 0;

        for (int j = 0; j < 4; j++)
        {
            sum += grades[i, j];
        }

        average[i] = sum / 4;

        if (average[i] >= 7)
        {
            status[i] = "Aprovado";
        }
        else if (average[i] >= 5.1)
        {
            status[i] = "Recuperação";
        }
        else
        {
            status[i] = "Reprovado";
        }
    }
}
void GenerateReportCard()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            gradesAndAverages[i, j] = grades[i, j];
        }

        gradesAndAverages[i, 4] = average[i];
    }
}

void ShowReportCard()
{
    Console.WriteLine();
    Console.WriteLine("Materia | 1B | 2B | 3B | 4B | Média | Status");

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{subjects[i]} | ");

        for (int j = 0; j < 5; j++)
        {
            Console.Write($"{gradesAndAverages[i, j]} | ");
        }

        Console.WriteLine(status[i]);
    }

}

GenerateGrades();
CalculateAverage();
GenerateReportCard();
ShowReportCard();

