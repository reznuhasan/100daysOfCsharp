
namespace IndexersPractice1
{
    public class Program
    {
        int EmployeeId;
        string EmployeeName;
        int EmployeeAge;
        string Department;
        char Section;
        double Salary;
        public Program(int employeeId, string employeeName, int employeeAge, string department, char section, double salary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeAge = employeeAge;
            Department = department;
            Section = section;
            Salary = salary;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return EmployeeId;
                }else if (index == 1)
                {
                    return EmployeeName;
                }else if(index == 2)
                {
                    return EmployeeAge;
                }else if(index == 3)
                {
                    return Department;
                }else if(index == 4)
                {
                    return Section;
                }else if (index == 5)
                {
                    return Salary;
                }
                return null;
            }
            set
            {
                if (index == 0)
                {
                    this.EmployeeId =(int) value;
                }else if(index == 1)
                {
                    this.EmployeeName= (string)value;
                }else if(index == 2)
                {
                    this.EmployeeAge=(int) value;
                }else if(index == 3)
                {
                    this.Department= (string)value;
                }else if (index == 4)
                {
                    this.Section=(char)value;
                }else if (index == 5)
                {
                    this.Salary=(double)value;
                }
            }
        }
        static void Main(string[] args)
        {
            Program obj=new Program(1015,"Rizwan",30,"Software",'A',3500.00);
            Console.WriteLine(obj[1]);
            obj[1] = "Ariful";
            Console.WriteLine(obj[1]);
        }
    }
}
