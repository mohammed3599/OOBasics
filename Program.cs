namespace OOBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std01 = new Student("Mohammed", "A", 1111, "12SD");

            //std01.name = "Mohammed";
            //std01.grade = "B";
            //std01.id = 123456;

            Console.WriteLine("Student 01 Data...");
            Console.WriteLine("Name: " +  std01.name);
            Console.WriteLine("ID: " + std01.id);
            Console.WriteLine("Grade: " + std01.grade);
            Console.WriteLine("Registeration No: " + std01.registerationNumber);
            std01.status();
            Console.WriteLine();

            Student std02 = new Student("Abdullah", "B", 2222, "45RT");

            //std02.name = "Abdullah";
            //std02.grade = "C";
            //std02.id = 111222;

            Console.WriteLine("Student 02 Data...");
            Console.WriteLine("Name: " + std02.name);
            Console.WriteLine("ID: " + std02.id);
            Console.WriteLine("Grade: " + std02.grade);
            Console.WriteLine("Registeration No: " + std02.registerationNumber);
            std02.status();
            Console.WriteLine();
        }
    }
}