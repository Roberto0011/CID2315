namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(111,"Alice");
        Student Bob = new Student(222,"Bob");
        Student Cathy = new Student(333,"Cathy");
        Student David = new Student(444,"David");


        Dictionary<string, double> GradeBook = new Dictionary<string, double> {
            {"Alice",4.0},
            {"Bob",3.6},
            {"Cathy",2.5},
            {"David",1.8}
        };

        

        string addTom = "Tom";
        if(!GradeBook.ContainsKey(addTom)){// ChatGPT used to fix Condition.

            GradeBook.Add(addTom,3.3);

        }

        double totalGPA = 0.0;
        foreach(var GPA in GradeBook.Values){
            totalGPA += GPA;

        }

        double averageGPA = totalGPA / GradeBook.Count;
        Console.WriteLine($"Avarage GPA:{averageGPA}");
        

        foreach (var student in Student.student_List){//ChatGPT Used to fix foreach statement.
            if (GradeBook.ContainsKey(student.GetStudentName()) && GradeBook[student.GetStudentName()] > averageGPA){
                student.PrintInfo();
            }
        }

        
        //Console.WriteLine($"{student.GetStudentName(addTom)}"); 

        //Wondering why Tom isnt shown in output.




    }


    class Student{

        private int studentID;

        private string studentName;

        public void PrintInfo(){
            Console.WriteLine($"Student ID: {studentID} Student GPA: {studentName}");
        }

        public static List<Student> student_List = new List<Student>();

        public string GetStudentName(){
            return studentName;

        }

        public Student(int input_ID, string input_Name){
            studentID = input_ID;
            studentName = input_Name;
            student_List.Add(this);
        }

        

    }
}
