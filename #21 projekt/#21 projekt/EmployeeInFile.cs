namespace _21_projekt
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname, string gender)
            : base(name, surname, gender)
        {
        }

        private const string fileName = "grades.txt";

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Wrong grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        if (float.TryParse(line, out float grade))
                        {
                            statistics.AddGrade(grade);
                            line = reader.ReadLine();
                        }
                        else
                        {
                            throw new Exception("Line is not float");
                        }
                    }
                }
            }
            else
            {
                throw new Exception("File not exist");
            }

            return statistics;

        }
    }
}
