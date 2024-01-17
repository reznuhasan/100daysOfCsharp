
namespace IndexersPractice2
{
    public class Program
    {
        int TeacherId;
        string TeacherName;
        string TeacherType;
        double TeacherSalary;
        public Program(int teacherId, string teacherName, string teacherType, double teacherSalary)
        {
            TeacherId = teacherId;
            TeacherName = teacherName;
            TeacherType = teacherType;
            TeacherSalary = teacherSalary;
        }
        public object this[char ch]
        {
            get
            {
                if (char.ToUpper(ch) == 'A')
                {
                    return TeacherId;
                }else if(char.ToUpper(ch) == 'B')
                {
                    return TeacherName;
                }else if(char.ToUpper(ch)== 'C')
                {
                    return TeacherType;
                }else if (char.ToUpper(ch) == 'D')
                {
                    return TeacherSalary;
                }
                return null;
            }
            set
            {
                if(char.ToUpper(ch) == 'A')
                {
                    this.TeacherId = (int)value;
                }else if (char.ToUpper(ch) == 'B')
                {
                    this.TeacherName=(string)value;
                }else if(char.ToUpper (ch) == 'C')
                {
                    this.TeacherType=(string)value;
                }else if (char.ToUpper(ch) == 'D')
                {
                    this.TeacherSalary=(double)value;
                }
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program(1111, "Arafat", "CSE", 35000.0);
            Console.WriteLine(obj['C']);
        }
    }
}
