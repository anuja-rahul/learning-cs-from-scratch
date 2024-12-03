int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit");

foreach (string name in studentNames)
{
    int[] studentScores = null;

    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Emma")
        studentScores = emmaScores;
    else if (name == "Logan")
        studentScores = loganScores;

    if (studentScores == null)
        continue;

    int sumExamScores = 0;
    int sumExtraCredit = 0;
    int gradedAssignments = 0;
    int extraCreditCounter = 0;

    // Inner foreach loop to calculate exam and extra credit sums
    foreach (int score in studentScores)
    {
        gradedAssignments++;
        if (gradedAssignments <= examAssignments)
        {
            sumExamScores += score;
        }
        else
        {
            extraCreditCounter++;
            sumExtraCredit += score;
        }
    }

    decimal overallGrade = (decimal)sumExamScores / examAssignments;

    decimal finalNumericScore = (sumExamScores + (sumExtraCredit * 0.1m)) / examAssignments;

    decimal extraCreditPoints = (sumExtraCredit * 0.1m) / extraCreditCounter;

    string letterGrade = finalNumericScore switch
    {
        >= 97 => "A+",
        >= 93 => "A",
        >= 90 => "A-",
        >= 87 => "B+",
        >= 83 => "B",
        >= 80 => "B-",
        >= 77 => "C+",
        >= 73 => "C",
        >= 70 => "C-",
        >= 67 => "D+",
        >= 63 => "D",
        >= 60 => "D-",
        _ => "F"
    };

    Console.WriteLine($"{name,-15}{overallGrade:F1}\t\t{finalNumericScore:F2}\t{letterGrade,-5}\t{sumExtraCredit} ({extraCreditPoints:F2} pts/{extraCreditCounter} scores)");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();