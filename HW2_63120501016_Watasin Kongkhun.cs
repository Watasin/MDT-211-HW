using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityRegistration
{
    enum Menu
    {
        RegisterNewActivity = 1,
        RegisterNewStudent = 2,
        RegisterNewTeacher =3,
        DeleteActivity = 4,
        DeleteStudent = 5,
        DeleteTeacher = 6,
        GetListActivity=7,
        GetListStudent=8,
        GetListTeacher=9
    }

    public class ManageUtils
    {
        static Register register;

        public static void PreparePersonListWhenProgramIsLoad()
        {
             register = new Register();
        }

        public static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeader()
        {
            Console.WriteLine("Welcome to activity registration application.");
            Console.WriteLine("----------------------------------------------------");
        }

        static void PrintListMenu()
        {
            Console.WriteLine("1. Register new activity.");
            Console.WriteLine("2. Register new student.");
            Console.WriteLine("3. Register new teacher.");
            Console.WriteLine("4. Delete activity.");
            Console.WriteLine("5. Delete student.");
            Console.WriteLine("6. Delete teacher.");
            Console.WriteLine("7. Get List Activity.");
            Console.WriteLine("8. Get List Student.");
            Console.WriteLine("9. Get List Teacher.");
        }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewActivity)
            {
                ShowInputRegisterNewActivityScreen();
            }
            else if (menu == Menu.RegisterNewStudent)
            {
                ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.DeleteActivity)
            {
                ShowInputDeleteActivityScreen();
            }
            else if (menu == Menu.DeleteStudent)
            {
                ShowInputDeleteStudentScreen();
            }
            else if (menu == Menu.DeleteTeacher)
            {
                ShowInputDeleteTeacherScreen();
            }
            else if (menu == Menu.GetListActivity)
            {
                ShowGetListActivityScreen();
            }
            else if (menu == Menu.GetListStudent)
            {
                ShowGetListStudentScreen();
            }
            else if (menu == Menu.GetListTeacher)
            {
                ShowGetListTeachScreen();
            }
        }

        static void ShowInputRegisterNewActivityScreen()
        {
            Console.Clear();
            PrintHeaderRegisterActivity();

            
            InputNewActivityFromKeyboard();
        }

        static void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

           
            InputNewStudentFromKeyboard();
        }

        static void ShowInputRegisterNewTeacherScreen()
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();
            
            InputNewTeacherFromKeyboard();
        }

        static void ShowInputDeleteActivityScreen()
        {
            Console.Clear();
            PrintHeaderDeleteActivity();


            InputDeleteActivityFromKeyboard();
        }

        static void ShowInputDeleteStudentScreen()
        {
            Console.Clear();
            PrintHeaderDeleteStudent();


            InputDeleteStudentFromKeyboard();
        }

        static void ShowInputDeleteTeacherScreen()
        {
            Console.Clear();
            PrintHeaderDeleteTeacher();


            InputDeleteTeacherFromKeyboard();
        }

        static void ShowGetListActivityScreen()
        {
            Console.Clear();
            register.listActivity();
            InputExitFromKeyboard();
        }

        static void ShowGetListStudentScreen()
        {
            Console.Clear();
            register.ListStudent();
            InputExitFromKeyboard();
        }

        static void ShowGetListTeachScreen()
        {
            Console.Clear();
            register.ListTeacher();
            InputExitFromKeyboard();
        }

        static void InputExitFromKeyboard()
        {
            string text = "";
            while (text != "exit")
            {
                Console.WriteLine("Input: ");
                text = Console.ReadLine();
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void PrintHeaderRegisterActivity()
        {
            Console.WriteLine("Register new activity.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderRegisterStudent()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderRegisterTeacher()
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderDeleteActivity()
        {
            Console.WriteLine("Delete activity.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderDeleteStudent()
        {
            Console.WriteLine("Delete student.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderDeleteTeacher()
        {
            Console.WriteLine("Delete teacher.");
            Console.WriteLine("---------------------");
        }

        static void ShowMessageInputMenuIsInCorrect()
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }

        static void InputNewActivityFromKeyboard()
        {
          

                Activity activity = CreateNewActivity();
                register.addActivity(activity);
            

                Console.Clear();
                PrintMenuScreen();
        }

        static void InputNewTeacherFromKeyboard()
        {
           

                Teacher teacher = CreateNewTeacher();

                Activity activity = SetActivity();

                register.addTeacher(activity, teacher);
            

                Console.Clear();
                PrintMenuScreen();
        }

        static void InputNewStudentFromKeyboard()
        {
         

                Student student = CreateNewStudent();

                Activity activity = SetActivity();

                register.addStudent(activity, student);
            

                Console.Clear();
                PrintMenuScreen();
        }

        static void InputDeleteActivityFromKeyboard()
        {


            Activity activity = SetActivity();
            register.removeActivity(activity);


            Console.Clear();
            PrintMenuScreen();
        }

        static void InputDeleteTeacherFromKeyboard()
        {


            Teacher teacher = SetTeacher();

            Activity activity = SetActivity();

            register.removeTeacher(activity, teacher);


            Console.Clear();
            PrintMenuScreen();
        }

        static void InputDeleteStudentFromKeyboard()
        {


            Student student = SetStudent();

            Activity activity = SetActivity();

            register.removeStudent(activity, student);


            Console.Clear();
            PrintMenuScreen();
        }


        static Activity SetActivity()
        {
            return new Activity() { Id = InputActivityID() };
        }

        static Student SetStudent()
        {
            return new Student() { Id = InputActivityID() };
        }

        static Teacher SetTeacher()
        {
            return new Teacher() { Id = InputActivityID() };
        }

        static Activity CreateNewActivity()
        {
            return new Activity(){ Id=InputId(),Name = InputName()};
        }

        static Student CreateNewStudent()
        {
            return new Student() { Id = InputId(), Name = InputName() };
        }

        static Teacher CreateNewTeacher()
        {
            return new Teacher() { Id = InputId(), Name = InputName() };
        }

        static string InputId()
        {
            Console.Write("Id: ");

            return Console.ReadLine();
        }

        static string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }

        static string InputActivityID()
        {
            Console.Write("Activity Id: ");

            return Console.ReadLine();
        }

        static string InputStudentID()
        {
            Console.Write("Student Id: ");

            return Console.ReadLine();
        }

        static string InputTeacherID()
        {
            Console.Write("Teacher Id: ");

            return Console.ReadLine();
        }
    }
}
