//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace dsaDotNet
//{
//    class Student
//    {
//        private int id;

//        public int ID
//        {
//            get { return id; }
//            set { id = value; }
//        }

//        private string? name;

//        public string? Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        private string? tel;

//        public string? Tel
//        {
//            get { return tel; }
//            set { tel = value; }
//        }

//        private DateTime dateOfBirth;

//        public DateTime DateOfBirth
//        {
//            get { return dateOfBirth; }
//            set { dateOfBirth = value; }
//        }

//        // constructor
//        public Student(int d, string? n, string? t, DateTime dob)
//        {
//            ID = d;
//            Name = n;
//            Tel = t;
//            DateOfBirth = dob;
//        }

//        // methods
//        public string StudentFullName()
//        {
//            return ID + " " + Name + " " + Tel + " " + DateOfBirth;
//        }
//    }
//    class StackTest
//    {
//        void m1()
//        {

//            DateTime dob1 = new DateTime(2000, 10, 13);
//            Student s1 = new Student(1, "John Tan", "88552211", dob1);

//            DateTime dob2 = new DateTime(2001, 11, 01);
//            Student s2 = new Student(2, "Peter Lim", "85678141", dob2);


//            DateTime dob3 = new DateTime(2000, 01, 03);
//            Student s3 = new Student(3, "David Chan", "88555461", dob3);

//            DateTime dob4 = new DateTime(2000, 05, 07);
//            Student s4 = new Student(4, "Muhammed Faizal", "98762211", dob4);

//            DateTime dob5 = new DateTime(2000, 08, 09);
//            Student s5 = new Student(5, "Esther Eng", "83352245", dob5);

//            List<Student> studentList = new List<Student>();
//            studentList.Add(s1);
//            studentList.Add(s2);
//            studentList.Add(s3);
//            studentList.Add(s4);
//            studentList.Add(s5);

//            //call the method to display the student list
//            DisplayOutput(studentList);

//            studentList.Add(GetStudent());

//            DisplayOutput(studentList);
//            DisplayOutput(studentList2);

//            //method that displays all the students
//            static void DisplayOutput(List<Student> sList)
//            {
//                Console.WriteLine("");

//                //header id name tel dob
//                Console.WriteLine("{0,-5} {1,-17} {2,-10} {3,-20}",
//                    "ID", "Name", "Tel", "Date of Birth");

//                //for loop to print the rest of the info
//                foreach (Student s in sList)
//                {
//                    Console.WriteLine("{0,-5} {1,-17} {2,-10} {3,-20}",
//                       s.ID, s.Name, s.Tel, s.DateOfBirth.ToString("dd/MM/yyyy"));
//                }
//            }
//        }

//        void m1()
//        {
            


//            List<Student> studentList2 = new List<Student>();
//            string[] csvLines = File.ReadAllLines("Students.csv");
//            string[] heading = csvLines[0].Split(',');

//            // Read and display lines from the file until the end of
//            // the file is reached.
//            for (int i = 1; i < csvLines.Length; i++)
//            {
//                string[] data = csvLines[i].Split(',');
//                //Console.WriteLine("{0,-5} {1,-17} {2,-10} {3,-20}",
//                //       data[0], data[1], data[2], data[3]);
//                Student s6 = new Student(Convert.ToInt32(data[0]), data[1], data[2], Convert.ToDateTime(data[3]));
//                Student s7 = new Student(Convert.ToInt32(data[0]), data[1], data[2], Convert.ToDateTime(data[3]));
//            studentList2.Add(s6);
//            studentList2.Add(s7);
//            }
//        }
//        Student GetStudent()
//        {
//            // prompt user for info
//            Console.Write("Enter id: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter name: ");
//            string? name = Console.ReadLine();

//            Console.Write("Enter tel: ");
//            string? tel = Console.ReadLine();

//            Console.Write("Enter Date of Birth: ");
//            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

//            Console.WriteLine("");

//            return new Student(id, name, tel, dateOfBirth);
//        }

//        //list from the csv

//    }
//}


