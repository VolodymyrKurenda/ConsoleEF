using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConsoleEF.DAL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ConsoleEF
{
    public class Menu
    {
        StRepository rep = new StRepository();

        public void menu()
        {
            while (true)
            {
                Console.Write("1 - Add Student\n2 - Show Table\n3 - Remove Student\n4 - Update Student\n0 - Exit\nYour Choice: ");
                switch (EnterChoice())
                {
                    case 0:
                        return;
                    case 1:
                        rep.Add(CreateStud());
                        break;
                    case 2:
                        ShowAllStudents();
                        break;
                    case 3:
                        rep.Remove(StudentById());
                        break;
                    case 4:
                        rep.Update(changemenu(StudentById()));
                        break;
                    default:
                        Console.WriteLine("Choose from 0 to 4");
                        break;
                }
            }
        }
        
        public Student changemenu(Student student)
        {
            while (true)
            {
                Console.Write("1 - Change name\n2 - Change Age\n3 - Change Adress\n4 - Change Email\n5 - Change Year of study\n0 - Exit\nYour Choice: ");
                switch (EnterChoice())
                {
                    case 0:
                        return student;
                    case 1:
                        student.Name = EnterName();
                        break;
                    case 2:
                        student.Age = EnterAge();
                        break;
                    case 3:
                       student.Adress = EnterAdress();
                        break;
                    case 4:
                        student.Email = EnterEmail();
                        break;
                    case 5:
                        student.Year = EnterYear();
                        break;
                    default:
                        Console.WriteLine("Choose from 0 to 5");
                        break;
                }
            }
        }

        public void ShowAllStudents()
        {
            foreach (var st in rep.Getall())
            {
                Console.WriteLine($"{st.Id} - {st.Name} - {st.Age} - {st.Adress} - {st.Email} - {st.Year}");
            }
        }

        public Student StudentById()
        {
            return rep.GetByID(EnterId());
        }

        public int EnterId()
        {
            while (true)
            {
                Console.Write("Enter Year of study: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number!");
                }
            }
        }

        public string EnterName()
        {
            Console.WriteLine("Enter Name:");
            return Console.ReadLine();
        }

        public string EnterAdress()
        {
            Console.WriteLine("Enter Adress:");
            return Console.ReadLine();
        }

        public string EnterEmail()
        {
            Console.WriteLine("Enter Email:");
            return Console.ReadLine();
        }

        public int EnterAge()
        {
            while (true)
            {
                Console.Write("Enter Year of study: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number!");
                }
            }
        }

        public int EnterYear()
        {
            while (true)
            {
                Console.Write("Enter Year of study: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number!");
                }
            }
        }

        public int EnterChoice()
        {
            while (true)
            {
                Console.Write("Enter Year of study: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number!");
                }
            }
        }

        public Student CreateStud()
        {
            return new Student { Name = EnterName(), Age = EnterAge(), Adress = EnterAdress(), Email = EnterEmail(), Year = EnterYear() };
        }

    }
}
