namespace _21_projekt
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase (string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set;}

        public virtual void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.AddGrade(grade);
            }
            else
            {
                throw new Exception("Wrong grade value");
            }
        }

        public virtual void AddGrade(int grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public virtual void AddGrade(double grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public virtual void AddGrade(string grade)
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

        public virtual void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public abstract Statistics GetStatistics();
    }
}
