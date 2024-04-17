using System.ComponentModel.DataAnnotations;

namespace _21_projekt
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Niepoprawna wartość oceny");
            }
        }

        public void AddGrade(double grade)
        {
            var gradeInString = grade.ToString();

            if (float.TryParse(gradeInString, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Nie jest możliwe przekonwertowanie wartości do float'a");
            }
        }

        public void AddGrade(int grade)
        {
            var gradeInInt = grade.ToString();

            if (float.TryParse(gradeInInt, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Nie jest możliwe przekonwertowanie wartości do float'a");
            }
        }

        public void AddGrade(short grade)
        {
            var gradeInShort = grade.ToString();

            if (float.TryParse(gradeInShort, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Nie jest możliwe przekonwertowanie wartości do float'a");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Nie jest możliwe przekonwertowanie wartości do float'a");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
