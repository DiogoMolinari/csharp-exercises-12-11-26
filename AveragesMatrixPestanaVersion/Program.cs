const int COLUMNS = 7;

int subject = 0, accountant = 0;

Console.WriteLine("Informe a quantidade de matérias: ");
subject = int.Parse(Console.ReadLine());
string[,] matrix = new string[subject, COLUMNS];

void RegisterSubjects()
{
    do
    {
        Console.WriteLine("Informe a matéria desejada: ");
        matrix[accountant, 0] = Console.ReadLine();
        accountant++;

    } while (accountant < subject);
}

float GenerateGrades()
{
    /*double d = Randon.Shared.NextDouble() *10;
     d = Math.Ruund(d,2);
    float f = float.Parse (d);
    return f*/

    return (float)Math.Round((Random.Shared.NextDouble()) * 10 , 2);
}

void PopulateReportCard()
{
    for (int line = 0; line < subject; line++)
    {
        for (int column = 1; column < 5; column++)
        {
            GenerateGrades().ToString();
            matrix[line, column] = GenerateGrades().ToString();
        }
    }
}

void GenerateAverages(string[,] matrix)
{
    for (int line = 0; line < subject; line++)
    {
        int column = 0;
        float sum = 0;

        for (column = 1; column < 5; column++)
        {
            sum = sum + (float.Parse(matrix[line, column]));
        }
        matrix[line, column] = Math.Round((sum / 4),2).ToString();
    }
}

void VerifyStatus(string[,] matrix)
{
    for(int line = 0; line < subject; line++)
    {
        float average = float.Parse(matrix[line, 5]);
        if(average >= 7)
        {
            matrix[line, 6] = "Aprovado!";
        }
        else if (average >= 5)
        {
            matrix[line, 6] = "Recuperação!";
        }
        else
        {
            matrix[line, 6] = "Reprovado!";
        }
    }
}

void ShowReportCard(string[,] matrix)
{
    Console.WriteLine("Matéria".PadRight(15) 
        + "1º Bi".PadRight(15) 
        + "2º Bi".PadRight(15) 
        + "3º Bi".PadRight(15) 
        + "4º Bi".PadRight(15) 
        + "Média".PadRight(15) 
        + "Situação".PadRight(15)

);
    for (int line = 0; line < subject; line++)
    {
        for (int column = 0; column < COLUMNS; column++)
        {
            Console.Write($"{matrix[line,column]}".PadRight(15));
        }
        Console.WriteLine();
    }
}


RegisterSubjects();
PopulateReportCard();
GenerateAverages(matrix);
VerifyStatus(matrix);
ShowReportCard(matrix);


