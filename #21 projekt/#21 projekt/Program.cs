using _21_projekt;

/*Console.WriteLine(" Witaj w aplikacji XYZ do oceny pracownika");
Console.WriteLine("===========================================");
Console.WriteLine();*/

EmployeeInFile employee = new EmployeeInFile("Alicja", "Nowak", "kobieta");

employee.AddGrade(10);
employee.AddGrade(0.5f);





/*while (true)
{
    Console.WriteLine(" Podaj nową ocenę dla pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
       employee1.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statistics1 = employee1.GetStatistics();

Console.WriteLine();
Console.WriteLine(" Oto statystki dla Twojego pracownika:");
Console.WriteLine("======================================");
Console.WriteLine($"Wartość minimalna: {statistics1.Min:N2}");
Console.WriteLine($"Wartość maksymalna: {statistics1.Max:N2}");
Console.WriteLine($"Wartość średnia: {statistics1.Average:N2}");
Console.WriteLine($"Wartość średnia literowa: {statistics1.AverageLetter:N2}");*/