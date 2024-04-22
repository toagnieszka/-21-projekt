namespace _21_projekt
{
    public class Supervisor : IEmployee
    {

        private List<float> grades = new List<float>();
        public string Name => "Jan";

        public string Surname => "Kowalski";

        public string Gender => "M";

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public void AddGrade(int grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public void AddGrade(double grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case '6':
                case '5':
                case '4':
                case '3':
                case '2':
                case '1':
                    string GradeInString = grade.ToString();
                    AddGrade(GradeInString);
                    break;
                default:
                    throw new Exception("Wrong grade Value");
            }

        }

        public void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                this.AddGrade((char)grade[0]);
            }
            else
            {
                switch (grade)
                {
                    case "6":
                        this.AddGrade(100);
                        break;
                    case "-6":
                    case "6-":
                        this.AddGrade(95);
                        break;
                    case "5":
                        this.AddGrade(80);
                        break;
                    case "5+":
                    case "+5":
                        this.AddGrade(85);
                        break;
                    case "-5":
                    case "5-":
                        this.AddGrade(75);
                        break;
                    case "4":
                        this.AddGrade(60);
                        break;
                    case "4+":
                    case "+4":
                        this.AddGrade(65);
                        break;
                    case "-4":
                    case "4-":
                        this.AddGrade(55);
                        break;
                    case "3":
                        this.AddGrade(40);
                        break;
                    case "3+":
                    case "+3":
                        this.AddGrade(45);
                        break;
                    case "-3":
                    case "3-":
                        this.AddGrade(35);
                        break;
                    case "2":
                        this.AddGrade(20);
                        break;
                    case "2+":
                    case "+2":
                        this.AddGrade(25);
                        break;
                    case "-2":
                    case "2-":
                        this.AddGrade(15);
                        break;
                    case "1":
                        this.AddGrade(0);
                        break;
                    case "1+":
                    case "+1":
                        this.AddGrade(5);
                        break;
                    default:
                        throw new Exception("Wrong Number");
                }
            }
        }

        public Statistics GetStatistics()
        {
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
}
