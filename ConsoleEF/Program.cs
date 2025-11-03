using ConsoleEF.DAL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ConsoleEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();

            m.menu();

            //var student = new Student
            //{
            //    Name = "Oleg",
            //    Age = 18,
            //    Email = "oleg@gmail.com",
            //    Adress = "USA",
            //    Year = 3
            //};


            //rep.Add(student);
            //var st1 = rep.GetByID(2);
            //rep.Remove(st1);

            //foreach (var st in rep.Getall())
            //{
            //    Console.WriteLine($"{st.Id} - {st.Name} - {st.Age} - {st.Adress} - {st.Email} - {st.Year}");
            //}

            //var st = rep.GetByID(2);
            //st.Name = "Alex";
            //rep.Update(st);
            //Console.WriteLine($"{st.Id} - {st.Name} - {st.Age} - {st.Adress} - {st.Email} - {st.Year}");
            
        }
       
        
    }
}
