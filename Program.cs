namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1- Add Student");
                Console.WriteLine("2- Add Instructor");
                Console.WriteLine("3- Add Course");
                Console.WriteLine("4- Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:


                        Console.Write("Enter Student Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Student Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Student student = new Student(id, name, age);

                        manager.AddStudent(student);

                        Console.WriteLine("Student Added Successfully");

                        break;

                    case 2:

                        Console.Write("Enter Instructor Id: ");
                        int instructorId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Instructor Name: ");
                        string instructorName = Console.ReadLine();

                        Console.Write("Enter Specialization: ");
                        string specialization = Console.ReadLine();

                        Instructor instructor = new Instructor(instructorId, instructorName, specialization);

                        manager.AddInstructor(instructor);

                        Console.WriteLine("Instructor Added Successfully");

                        break;

                       case 3:

                        Console.Write("Enter Course Id: ");
                        int courseId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Course Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Instructor Id: ");
                        int insId = Convert.ToInt32(Console.ReadLine());

                        Instructor ins = manager.FindInstructor(insId);
                        if (ins != null)
                        {
                            Course course = new Course(courseId, title, ins);

                            manager.AddCourse(course);

                            Console.WriteLine("Course Added Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Instructor Not Found");
                        }

                        break;

                    case 4:

                        Console.Write("Enter Student Id: ");
                        int studentId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Course Id: ");
                        int cId = Convert.ToInt32(Console.ReadLine());

                        if (manager.EnrollStudentInCourse(studentId, cId))
                        {
                            Console.WriteLine("Student Enrolled Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Student or Course Not Found");
                        }

                        break;
                }
            }


        }
    }
}
