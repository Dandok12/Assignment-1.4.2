//Create a class student


using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Student
{

    public int studentID { get; set; }
    public string studentFirstname { get; set; }
    public string studentLastname { get; set; }
    public char studentGrade { get; set; }

    class Program
    {
        static void Main()
        {
            Student student = new Student();

            student.studentID = 111;
            student.studentFirstname = "Dan";
            student.studentLastname = "Chung";
            student.studentGrade = 'A';

            Console.WriteLine("Student Info: ");
            Console.WriteLine("ID" + student.studentID);
            Console.WriteLine("First name" + student.studentFirstname);
            Console.WriteLine("Last name" + student.studentLastname);
            Console.WriteLine("Grade" + student.studentGrade);
        }
    }

}
            

        
