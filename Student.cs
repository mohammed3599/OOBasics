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
        public string lastGrade;
        public long id;
        public string registerationNumber;

        public Student(string name, string grade, long id, string registerationNumber)
        {
            this.name = name;
            this.lastGrade = grade;
            this.id = id;
            this.registerationNumber = registerationNumber;
            printStudentDetails();
        }

        //public Student(string name, long id, string registerationNumber)
        //{
        //    this.name = name;
        //    this.lastGrade = null;
        //    this.id = id;
        //    this.registerationNumber = registerationNumber;
        //    printStudentDetails();
        //}

        public Student(string name, long id, string registerationNumber) : this(name, null, id, registerationNumber)
        {
            status();
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
