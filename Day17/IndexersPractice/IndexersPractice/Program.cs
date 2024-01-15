
namespace IndexerPractice
{
    public class Program
    {
        int Sid;
        string SName, Department, Section;
        double Marks;
        int SClass;
        public Program(int Sid,int SClass,string Sname,string Department,string Section,double Marks)
        {
            this.Sid = Sid;
            this.SClass = SClass;
            this.SName = Sname;
            this.Department = Department;
            this.Section = Section;
            this.Marks = Marks;
        }
        public object this[int index]
        {
            get
            {
                if(index == 0)
                {
                    return Sid;
                }else if(index== 2)
                {
                    return SName;
                }else if(index== 3)
                {
                    return Department;
                }else if (index== 4)
                {
                    return Section;
                }
                else if(index== 5)
                {
                    return Marks;
                }
                else if(index== 1)
                {
                    return SClass;
                }
                return null;
            }
            set
            {
                if (index == 0)
                {
                    this.Sid = (int)value;
                }else if (index == 1)
                {
                    this.SClass = (int)value;
                }else if(index == 2)
                {
                    this.SName = (string)value;
                }else if(index == 3)
                {
                    this.Department= (string)value;
                }else if(index==4)
                {
                    this.Section= (string)value;
                }else if(index == 5)
                {
                    this.Marks = (double)value;
                }
            }
        }
        public object this[string name]
        {
            get {
                if (name.ToUpper() == "SID")
                {
                    return Sid;
                }else if(name.ToUpper() == "SCLASS")
                {
                    return SClass;
                }else if(name.ToUpper() == "SNAME")
                {
                    return SName;
                }else if(name.ToUpper() == "DEPARTMENT")
                {
                    return Department;
                }else if(name.ToUpper()== "SECTION")
                {
                    return Section;
                }else if (name.ToUpper() == "MARKS")
                {
                    return Marks;
                }
                return null;
            }
        }
    }
}
