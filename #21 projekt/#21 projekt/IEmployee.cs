using static _21_projekt.EmployeeBase;

namespace _21_projekt
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        string Gender { get; }

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        void AddGrade(char grade);
    }
}
