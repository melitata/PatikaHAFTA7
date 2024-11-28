using GroupJoin;
using System.Threading.Channels;

public class Program 
{
  public static void Main(string[] args)
  {
    List<Student> student =new List<Student>()
    {
        new Student() { StudentID = 1, StudentName = "Ali", ClassID = 1 },
        new Student() { StudentID = 2, StudentName = "Ayşe", ClassID = 2 },
        new Student() { StudentID = 3, StudentName = "Mehmet", ClassID = 1 },
        new Student() { StudentID = 4, StudentName = "Fatma", ClassID = 3 },
        new Student() { StudentID = 5, StudentName = "Ahmet", ClassID = 2 }
    };
    List<Classes> classes = new List<Classes>()
    {
        new Classes() { ClassID = 1, ClassName = "Matematik" },
        new Classes() { ClassID = 2, ClassName = "Türkçe" },
        new Classes() { ClassID = 3, ClassName = "Kimya" }
    };

     var comolokko= student.GroupJoin
     (                               classes,
                                     s => s.ClassID,
                                     c => c.ClassID,
                                     (student, classes) => new
                                     {
                                       StudentNam = student.StudentName,
                                       ClassNam = classes.Select(x => x.ClassName).FirstOrDefault()
                                     }
     );
        foreach (var item in comolokko)
        {
            Console.WriteLine($"Öğrenci Adı: " + item.StudentNam + "\t*Ders Adı: " + item.ClassNam);
        }
        
    }

}