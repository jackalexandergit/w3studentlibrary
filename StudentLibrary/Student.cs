using System.Security.Cryptography.X509Certificates;

namespace StudentLibrary
{
    public class Student
    {

        // private fields
        private int studentId;
        private string name;
        private int age;
        private static int studentCount = 0;

        // public properties

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
            private set { studentCount = value; }
        }

        // default constructor

        public Student()
        {
            this.studentId = studentCount++;
            this.name = "John Doe";
            this.age = 20;
        }

        // custom constructor

            public Student(string name, int age)
        {
            this.studentId = studentCount++;
            this.name = name;
            this.age = age;
        }

        // methods

        public void Display()
        {
            Console.WriteLine($"Student ID: {studentId}, Name: {name}, Age: {age}\n");
        }

        public int GetOlder()
        {
            age++;
            return age;
        }
    }
}
