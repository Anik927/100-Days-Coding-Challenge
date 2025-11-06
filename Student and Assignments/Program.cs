using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_and_Assignments;

namespace Student_and_Assignments
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        
static void Main(string[] args)
        {
            
            Console.WriteLine("Choose Your option:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Show All Details");
            Console.WriteLine("0. Exit");

            int option = -1 ;
            while (option != 0)
            {
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine();
                    Console.WriteLine("You entered the number " + option);
                    Console.WriteLine();
                    switch (option)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            Console.WriteLine("Select id of student to remove");
                                int removeID = int.Parse(Console.ReadLine());
                            
                            if (students.RemoveAll(s => s.StudentId == removeID) > 0)
                            {
                                Console.WriteLine($"Student with ID {removeID} removed.");
                            }
                            else
                            {
                                Console.WriteLine("Student with that ID not found!");
                            }                        
                            break;

                        case 3:
                           
                            foreach(Student s in students)
                                s.ShowDetails();
                            break;

                        case 0:
                            Console.WriteLine("Bye!");                            
                            break;

                    }
                }
                else
                    Console.WriteLine("Invalid Number");                
            }

        }

        static void AddStudent()
        {
            int id;
            string name;

            Console.Write("Enter Student ID: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID! Please enter a number.");
            }

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            var student = new Student { StudentId = id, Name = name };
            List<Assignment> tempAssignments = new List<Assignment>();
            // Loop to add assignments
            while (true)
            {
                Console.Write("Add an assignment? (y/n): ");
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == "n")
                    break;

                Console.Write("Enter Assignment Title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Due Date (yyyy-MM-dd): ");
                DateTime dueDate;
                while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
                {
                    Console.WriteLine("Invalid date! Please enter in yyyy-MM-dd format.");
                }

                Console.Write("Enter Score: ");
                double score;
                while (!double.TryParse(Console.ReadLine(), out score))
                {
                    Console.WriteLine("Invalid score! Please enter a number.");
                }

                tempAssignments.Add(new Assignment(title, dueDate, score));
                Console.WriteLine("Assignment added!");
            }
            student.Assignments = tempAssignments;
            students.Add(student);
            Console.WriteLine($"Student {name} with {student.Assignments.Count} assignments added!");
        }

    }
}
