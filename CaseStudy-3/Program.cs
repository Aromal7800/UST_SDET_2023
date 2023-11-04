// See https://aka.ms/new-console-template for more information

using CaseStudy_3;
using CaseStudy_3.MyExceptions;
using System.Security.Cryptography;

class Program
{
    public delegate void EnrollmentHandler();
    public delegate Task EnrollmentTaskHandler();
    public static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("choose the option\n1.Admin\n2.Student\n3.Exit\n");
                Console.Write("Enter the option:");
                int optionMainMenu = Convert.ToInt32(Console.ReadLine());
                if (optionMainMenu == 1)
                {
                    while (true)
                    {
                        Course course = new Course();

                        Console.WriteLine("\tchoose the option\n\t1.Add Course\n\t2.View Report\n\t3.Withdraw Course\n\t4.MainMenu");
                        int optionMenuAdmin = Convert.ToInt32(Console.ReadLine());
                        if (optionMenuAdmin == 1)
                        {
                            EnrollmentHandler enrollmentHandler = new EnrollmentHandler(course.CourseRegistration);
                            enrollmentHandler();
                            Console.WriteLine("\t\t*****Course Added Succeessfully****");
                        }
                        else if (optionMenuAdmin == 2)
                        {
                            EnrollmentHandler enrollmentHandler = new EnrollmentHandler(course.DisplayCourses);
                            enrollmentHandler();

                        }
                        else if (optionMenuAdmin == 3)
                        {
                            EnrollmentHandler enrollmentHandler = new EnrollmentHandler(course.Withdrawal);
                            enrollmentHandler();
                        }
                        else if (optionMenuAdmin == 4)
                            break;
                        else
                        {
                            Console.WriteLine("Invalid option");
                        }
                        Console.WriteLine("\nDo you want to continue as admin \n1.yes\n2.No\n");
                        Console.Write("Enter the option");
                        int exitoptionAdminMenu = Convert.ToInt32(Console.ReadLine());
                        if (optionMainMenu == 1)
                            continue;
                        else if (exitoptionAdminMenu == 2)
                            break;
                        else
                            Console.WriteLine("Invalid option");
                    }
                }
                else if (optionMainMenu == 2)
                {
                    while (true)
                    {

                        Console.WriteLine("choose the option\n1.Register student\n2.Add Course for student" +
                            "\n3.Remove Course from student\n4.MainMenu");
                        int optionMenuUser = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student();
                        if (optionMenuUser == 4)
                            break;
                        switch (optionMenuUser)
                        {

                            case 1:

                                EnrollmentTaskHandler enrollmentHandler = new EnrollmentTaskHandler(student.Registration);
                                enrollmentHandler();
                                break;
                            case 2:
                                EnrollmentTaskHandler enrollmentHandler1 = new EnrollmentTaskHandler(student.AddCourse);
                                enrollmentHandler1();
                                break;
                            case 3:
                                EnrollmentHandler enrollmentHandler2 = new
                                     EnrollmentHandler(student.RemoveCourseFromStudent);
                                enrollmentHandler2();
                                break;
                            case 4: break;
                            default:
                                Console.WriteLine("invalid option");
                                break;

                        }

                        Console.WriteLine("\nDo you want to continue as User \n1.yes\n2.No\n");
                        Console.Write("Enter the option");
                        int exitoptionUserMenu = Convert.ToInt32(Console.ReadLine());
                        if (optionMainMenu == 0)
                            continue;
                        else if (exitoptionUserMenu == 2)
                            break;
                        else
                            Console.WriteLine("Invalid option");
                    }
                }
                else if (optionMainMenu == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }

                if (optionMainMenu != 3)
                {
                    Console.WriteLine("Do you want to continue to main menu \n1.yes\n2.No\n");
                    Console.Write("Enter the option");
                    int exitoptionMainMenu = Convert.ToInt32(Console.ReadLine());
                    if (optionMainMenu == 1)
                        continue;
                    else if (exitoptionMainMenu == 2)
                        Environment.Exit(0);
                    else
                        Console.WriteLine("Invalid option");

                }
            }
        }
        catch (CourceException courseException)
        {
            Console.WriteLine(courseException.Message);
        }
        catch (StudentException studentException)
        {
            Console.WriteLine(studentException.Message);
        }
    }
}