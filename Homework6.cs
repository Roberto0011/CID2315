namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
       Professor p1 = new Professor();
       p1.profName = "Alice";
       p1.classTeach = "Java";
       p1.salary = 9000;
       p1.ProfessorInfo();

       Professor p2 = new Professor();
       p2.profName = "Bob";
       p2.classTeach = "Math";
       p2.salary = 8000;
       p2.ProfessorInfo();

       Student s1 = new Student();
       s1.studentName = "Lisa";
       s1.classEnroll = "Java";
       s1.studentGrade = 90;
       s1.studentInfo();

       Student s2 = new Student();
       s2.studentName = "Tom";
       s2.classEnroll = "Math";
       s2.studentGrade = 80;
       s2.studentInfo();

       Console.WriteLine($"The salary diffrence between Alice and Bob is: {p1.salary - p2.salary}");
       Console.WriteLine($"The total grade of Lisa and Tom is: {s1.studentGrade + s2.studentGrade}");
       


    }

    class Professor{
        public string profName;
        public string classTeach;
        public double salary {get;set;}

        

        public void ProfessorInfo(){
            Console.WriteLine($"Professor {profName} teaches {classTeach}, and salary is: {salary}");
        }
    }

    class Student{
        public string studentName;
        public string classEnroll;
        public double studentGrade {get;set;}

        

        public void studentInfo(){
            Console.WriteLine($"student {studentName} enrolls {classEnroll}, and grade is: {studentGrade}");
        }
    }




    
}
