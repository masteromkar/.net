using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empdetails
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("======================================================");
            employee o1 = new employee("Amol", 123465, 10);
            employee o2 = new employee("Amol", 123465);
            employee o3 = new employee("Amol");
            employee o4 = new employee();
            o1.display(o1);
            Console.WriteLine("======================================================\n \n");
            Console.WriteLine("======================================================");
            o2.display(o2);
            Console.WriteLine("======================================================\n \n");
            Console.WriteLine("======================================================");

            o3.display(o3);
            Console.WriteLine("======================================================\n \n");
            Console.WriteLine("======================================================");
            o4.display(o4);
            Console.WriteLine("======================================================");

            Console.ReadLine();

        }
    }

     public class employee
    {
        public string Name;
        public int EmpNo;
        public decimal Basic;
        public short DeptNo;
        public static int count;

        employee(string x = null, decimal y = 0, short z = 0)
        {
            name = x;
            basic = y;
            depno = z;
            empNo = count;
        }

        static employee()
        {
            count++;
        }

        employee()
        {

        }


        public int empNo
        {
            set
            {
                int a = Convert.ToInt32(value);
                this.EmpNo = a;
            }
            get
            {
                return this.EmpNo;
            }
        }
  
        public decimal basic
        {
            set
            {
                decimal a=Convert.ToDecimal(value);
                if (1 < a && a < 10000)
                {
                    this.Basic = a;
                }
                else
                {
                    Console.WriteLine("Basic sal is between 1 to 10000");

                }
            }
            

            get
            {
                return this.Basic;
            }
        }

        public string name
        {
            set
            {
                if (value != null)
                {
                    this.Name = value;
                }
                else
                {
                    Console.WriteLine("no blank names should be allowed");
                }
            }

            get
            {
                return this.Name;
            }
        }

        public short depno
        {
            set
            {
                short a = Convert.ToInt16(value);
                if(1<a && a<128)
                {
                    this.DeptNo = a;
                }    
                else
                {
                    Console.WriteLine("Enter valid department number");
                }
            }
            get
            {
                return this.DeptNo;
            }
        }

        public decimal GetNetSalary(decimal basic)
        {
            decimal Hra=100;
            decimal Net = basic + Hra;
            return Net;
        }

        public void display(employee o)
        {
            Console.WriteLine(" Name of Employee: " + o.name);
            Console.WriteLine(" ID number : " + o.empNo);
            Console.WriteLine(" Net salary: " + o.GetNetSalary(o.basic));
            Console.WriteLine(" Department No: " + o.depno);
        }

    }
}
