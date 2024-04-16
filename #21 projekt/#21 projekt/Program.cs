using _21_projekt;

Employee employee1 = new Employee("Alicja", "Nowak");
Employee employee2 = new Employee("Kasia", "Kowalska");
Employee employee3 = new Employee("Kamil", "Wiśniewski");

employee1.AddGrade(3);
employee1.AddGrade(6);

employee2.AddGrade(7);
employee2.AddGrade(3);

employee3.AddGrade(1);
employee3.AddGrade(10);

var statistics1 = employee1.GetStatisticsWithFor();
var statistics2 = employee2.GetStatisticsWithDoWhile();
var statistics3 = employee3.GetStatisticsWithWhile();
var statistics4 = employee1.GetStatisticsWithForEach();

Console.WriteLine($"Min: {statistics1.Min:N2}");
Console.WriteLine($"Max: {statistics1.Max:N2}");
Console.WriteLine($"Average: {statistics1.Average:N2}");