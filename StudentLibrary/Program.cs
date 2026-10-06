using StudentLibrary;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student("Jack", 19);
        student1.Display();
        student2.Display();
        student1.GetOlder();
        student2.GetOlder();
        student1.Display();
        student2.Display();
    }
}
