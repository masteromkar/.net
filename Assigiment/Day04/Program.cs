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

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public abstract class Employee
    {
        private string Name;
        private int EmpNo;
        private short DepNo;
        public static int count;
        protected decimal basic;
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
            set { }
            get { return this.DepNo; }
        }
    }

    public class Manager : Employee,IDbFunctions
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
            set { }
            get { return this.basic; }
        }

        public override decimal CalcNetSalary()
        {
            decimal Hra = 200;
            return this.Basic + Hra;
        }

        public void Delete()
        {
            Console.WriteLine("to delete manager");
        }

        public void Insert()
        {
            Console.WriteLine("to insert manager");
        }

        public void Update()
        {
            Console.WriteLine("to update manager");
        }
    }

    public class GeneralManager : Manager,IDbFunctions
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

        public new void Delete()
        {
            Console.WriteLine("to delete General manager");
        }

        public new void Insert()
        {
            Console.WriteLine("to insert General manager");
        }

        public new void Update()
        {
            Console.WriteLine("to update General manager");
        }
    }

    public class CEO : Employee, IDbFunctions
    {
        public override decimal Basic
        {
            get { return this.basic; }
            set { }
        }

        public void Delete()
        {
            Console.WriteLine("to delete CEO");
        }

        public void Insert()
        {
            Console.WriteLine("to insert CEO");
        }

        public void Update()
        {
            Console.WriteLine("to Update CEO");
        }


        public CEO(string x = null, decimal y = 0, short z = 0) : base(x, y, z)
        {

        }

      

        public sealed override decimal CalcNetSalary()
        {
            decimal hra = 1000;
            return this.Basic + hra;
        }
    }

    
}
