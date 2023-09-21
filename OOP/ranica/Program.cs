namespace ZadachiZaPregovor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student st1 = new student() { name = "Gancho", FamilyName = "Petrov", Age = 15 };
            BackPack bp1 = new BackPack() { Volume = 15.6, Color = "Camoflage", Price = 69.75m };
            st1.BackPack = bp1;
            st1.Grades = new List<int>();
            st1.Grades.Add(5);
            st1.Grades.Add(4);
            st1.Grades.Add(6);
            Console.WriteLine("sreden uspeh e: " + st1.GetAverageGrade());

        }

    }
    public class BackPack
    {
        public double Volume { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

    }
    public class student
    {
        public string name { get; set; }
        private string familyName;
        public string FamilyName;
        public int Age { get; set; }
        public BackPack BackPack { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public void PresentYourSelf()
        {
            Console.WriteLine();

        }
        public double GetAverageGrade()
        {
            double result = Grades.Average();
            return result;
        }
        private void IncreaseAge()
        {
            Age++;
        }
    }
}