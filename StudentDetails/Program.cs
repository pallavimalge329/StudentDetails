using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class HostelStudent
    {
        // member attributes
        
        public int roomno;

        public HostelStudent( int roomno)
        {
            // to resolve the conflict 
            this.roomno = roomno;
        }

        public void display()
        {
            Console.WriteLine("=========Employee Details==========");
            Console.WriteLine("HostelStudent Room No  : {0}", roomno);
        }

    }

    class Student : HostelStudent
    {
       string studentid;
        string name;

        public Student( int roomno, string studentid, string name)
                  : base( roomno)
        {
            this.studentid = studentid;
            this.name = name;
        }

        ~Student() { }

        public void StudentDetails()
        {
            // calling method of a base class
            base.display();

            // additional details
            Console.WriteLine("Student id : {0}", studentid);
            Console.WriteLine("Student Name : {0}", name);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Demo!");
            // default constructor
            //Employee emp1 = new Employee("E001", "Abhishek", 24, 45.5F);


            Student std1 = new Student( 12, "S001", "Pallavi");

            std1.StudentDetails();
            Console.ReadKey();
        }

    }

}
