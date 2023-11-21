using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assign = new Assignment("Ogunleye Johnson ", "C# Project");
        Console.WriteLine(assign.GetSummary());


        MathAssignment mathAssign = new MathAssignment("Gbenga Lanre", "Phyton", "6", "Classes");

        Console.WriteLine(mathAssign.GetSummary());

        Console.WriteLine(mathAssign.GetHomeworkList());

        WritingAssignment writtingAssign = new WritingAssignment("Gbemi  Daniel", "Research Project", "Mobile application");

        Console.WriteLine(writtingAssign.GetSummary());

        Console.WriteLine(writtingAssign.GetWritingInformation());
    }
}