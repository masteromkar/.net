using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager emp1 = new Manager("omkar", 10000, 1, "sub-maneger");
            GeneralManager emp2 = new GeneralManager("xyz", 8888, 9, "GR", "gagas");
            CEO emp3 = new CEO("omkar-sukale", 100012121, 12);

            Console.WriteLine(" Name"+emp1.name+"\n net-sal"+emp1.CalcNetSalary()+"\n EMPID "+emp1.empno+"\n Designation"+emp1.designation);

            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private string Name;
        private int EmpNo;
        private short DepNo;
        public static int count;
        public abstract decimal Basic
        {
            set;
            get;
        }

        public abstract decimal CalcNetSalary();

        public Employee(string x=null,decimal y=0,short z=0)
        {
            this.name = x;
            this.empno = ++count;
            this.depno = z;
            this.Basic = y;
        }

        public string name
        {
            set
            {
                if(value!=null)
                {
                    this.Name = value;
                }
                else
                {
                    Console.WriteLine("ENter the valid Name");
                }
            }
            get
            {
                return this.Name;
            }
        }

        public int empno
        {
            private set
            {
                this.EmpNo =value;
            }
            get
            {
                return this.EmpNo;
            }
        }

        public short depno
        {
            set;
            get;
        }
    }

    public class Manager : Employee
    {
        private string Designation; 

        public Manager(string x = null, decimal y = 0, short z = 0,string d=null):base(x,y,z)
        {
            
            this.designation = d;
            
        }

        public string designation
        {
            set
            {
                if (value!= null)
                {
                    this.Designation = value;
                }
                else
                {
                    Console.WriteLine("Enter a valid designation");
                }
            }
            get
            {
                return this.Designation;
            }
        }
       
        public override decimal Basic
        {
            set;
            get;
        }

        public override decimal CalcNetSalary()
        {
            decimal Hra = 200;
            return this.Basic + Hra;
        }
    }

    public class GeneralManager : Manager
    {
        private string Perks;

        public GeneralManager(string x = null, decimal y = 0, short z = 0, string d = null, string p=null):base(x,y,z,d)
        {
            this.perks = p;
        }
        public string perks
        {
            set;
            get;
        }
    }

    public class CEO : Employee
    {
        public CEO(string x = null, decimal y = 0, short z = 0):base(x,y,z)
        {

        }

        public override decimal Basic { get; set; }

        public sealed override decimal CalcNetSalary()
        {
            decimal hra = 1000;
            return this.Basic + hra;
        }
    }
}
