

namespace ConsoleEF.DAL
{
    public class StRepository
    {

        private AppDbContext dbcontext;

        public StRepository() 
        {
            dbcontext = new AppDbContext();
        }

        public void Add(Student student)
        {
            dbcontext.students.Add(student);
            dbcontext.SaveChanges();

        }

        public List<Student> Getall()
        {
            return dbcontext.students.ToList();
        }

        public Student GetByID(int id)
        {
            return dbcontext.students.FirstOrDefault(s => s.Id == id);
        }

        public void Update(Student student)
        { 
            dbcontext.Update(student);
            dbcontext.SaveChanges();
        }

        public void Remove(Student student)
        {
            dbcontext.students.Remove(student);
            dbcontext.SaveChanges();
        }

    }
}
