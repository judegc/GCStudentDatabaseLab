static string StudentListNumber(int num)
{
    int[] studentNumber = new int[9];
    studentNumber[0] = 1;
    studentNumber[1] = 2;
    studentNumber[2] = 3;
    studentNumber[3] = 4;
    studentNumber[4] = 5;
    studentNumber[5] = 6;
    studentNumber[6] = 7;
    studentNumber[7] = 8;
    studentNumber[8] = 9;
    string[] studentName = new string[9]; 
    studentName[0] = "Jacob"; 
    studentName[1] = "Nathaniel";
    studentName[2] = "Jacqueline";
    studentName[3] = "Nancy";
    studentName[4] = "Alex";
    studentName[5] = "Samuel";
    studentName[6] = "Alice";
    studentName[7] = "Samantha";
    studentName[8] = "Felix";
    string numAndName = $"{studentNumber[num - 1]} {studentName[num -1]}";
    for (int i = 0; i < studentNumber.Length; i++)
    {
        Console.WriteLine(numAndName);
    }
    return numAndName;
}

static string StudentListName(string name)
{
    int[] studentNumber = new int[9];
    studentNumber[0] = 1;
    studentNumber[1] = 2;
    studentNumber[2] = 3;
    studentNumber[3] = 4;
    studentNumber[4] = 5;
    studentNumber[5] = 6;
    studentNumber[6] = 7;
    studentNumber[7] = 8;
    studentNumber[8] = 9;
    string[] studentName = new string[9];
    studentName[0] = "Jacob";
    studentName[1] = "Nathaniel";
    studentName[2] = "Jacqueline";
    studentName[3] = "Nancy";
    studentName[4] = "Alex";
    studentName[5] = "Samuel";
    studentName[6] = "Alice";
    studentName[7] = "Samantha";
    studentName[8] = "Felix";
    string numAndName;
    string returnValue = null;
    if (name == studentName[0])
    {
        numAndName = $"{studentName[0]} {studentName[0]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[1])
    {
        numAndName = $"{studentName[1]} {studentName[1]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[2])
    {
        numAndName = $"{studentName[2]} {studentName[2]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[3])
    {
        numAndName = $"{studentName[3]} {studentName[3]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[4])
    {
        numAndName = $"{studentName[4]} {studentName[4]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[5])
    {
        numAndName = $"{studentName[5]} {studentName[5]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[6])
    {
        numAndName = $"{studentName[6]} {studentName[6]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[7])
    {
        numAndName = $"{studentName[7]} {studentName[7]}";
        Console.WriteLine(numAndName);
    }
    if (name == studentName[8])
    {
        numAndName = $"{studentName[8]} {studentName[8]}";
        Console.WriteLine(numAndName);
    }
    else 
    {
        Console.WriteLine("Invalid");
  }
    return returnValue;
}