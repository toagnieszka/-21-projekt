using Microsoft.VisualBasic;

namespace _21_projekt
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        string Gender { get; }

        Statistics GetStatistics();

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        void AddGrade(char grade);
    }
}
