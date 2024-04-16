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
                Console.WriteLine("Niepoprawna wartość oceny");
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
                Console.WriteLine("Nie jest możliwe przekonwertowanie wartości do float'a");
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
                Console.WriteLine("Nie jest możliwe przekonwertowanie wartości do float'a");
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
                Console.WriteLine("Nie jest możliwe przekonwertowanie wartości do float'a");
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
                Console.WriteLine("Nie jest możliwe przekonwertowanie wartości do float'a");
            }
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics1 = new Statistics();
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;
            statistics1.Average = 0;

            foreach (var grade in grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average += grade;
            }

            statistics1.Average /= this.grades.Count;

            return statistics1;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            statistics2.Average = 0;

            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index]);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[index]);
                statistics2.Average += this.grades[index];
            }

            statistics2.Average /= this.grades.Count;

            return statistics2;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            statistics3.Average = 0;

            var index = 0;

            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Average += this.grades[index];
                index++;

            } while (index < this.grades.Count);

            statistics3.Average /= this.grades.Count;

            return statistics3;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;
            statistics4.Average = 0;

            var index = 0;

            while (index < grades.Count)
            {
                statistics4.Max = Math.Max(statistics4.Max, this.grades[index]);
                statistics4.Min = Math.Min(statistics4.Min, this.grades[index]);
                statistics4.Average += this.grades[index];
                index++;
            }

            statistics4.Average /= this.grades.Count;

            return statistics4;
        }
    }
}
