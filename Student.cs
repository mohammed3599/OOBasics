using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBasics
{
    internal class Student
    {
        public string name;
        public string grade;
        public long id;
        public string registerationNumber;

        public Student(string name, string grade, long id, string registerationNumber)
        {
            this.name = name;
            this.grade = grade;
            this.id = id;
            this.registerationNumber = registerationNumber;
            printStudentDetails();
        }

        public void status()
        {
            Console.WriteLine("Student " + name + " is studying");
        }

        void printStudentDetails ()
        {
            Console.WriteLine("Name: " + this.name + "Registeration No: " + this.registerationNumber);
            Console.WriteLine();
        }
    }
}
