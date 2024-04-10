using _21_projekt;

Employee employee1 = new Employee("Alicja", "Nowak", 36);
Employee employee2 = new Employee("Kasia", "Kowalska", 25);
Employee employee3 = new Employee("Kamil", "Wiśniewski", 57);

employee1.AddRate(3);
employee1.AddRate(6);
employee1.AddRate(2);
employee1.AddRate(3);
employee1.AddRate(9);

employee2.AddRate(7);
employee2.AddRate(3);
employee2.AddRate(4);
employee2.AddRate(1);
employee2.AddRate(3);

employee3.AddRate(1);
employee3.AddRate(10);
employee3.AddRate(2);
employee3.AddRate(5);
employee3.AddRate(3);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine($"Osoba z najwyższą liczbą ocen to: {employee1.Name} {employee1.Surname}, lat {employee1.Age}. Jej wynik to: {result1} punktów.");
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine($"Osoba z najwyższą liczbą ocen to: {employee2.Name} {employee2.Surname}, lat {employee2.Age}. Jej wynik to: {result2} punktów.");
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine($"Osoba z najwyższą liczbą ocen to: {employee3.Name} {employee3.Surname}, lat {employee3.Age}. Jej wynik to: {result3} punktów.");
}