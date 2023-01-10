using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_ConsoleApp1
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public string FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }

    }
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
    public enum CourseLevel
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }

    public class PlutoContext : DbContext
    {
        public PlutoContext():base("name=DefaultConnection")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
    public class Program
    {
        /*
         * steps to use EntityFramework:
         * install-package EntityFramework -Version:6.4.4
         * create your classes "models"
         * create class derived from DbContext Class
         * Create you DbSets
         * Add the connection string in your config file
         * In the your DbContext class in the constractor call base("name=connection string")
         * In Package manager console enable-migrations , this command run only one time in the project
         * useing database centric name is better than using model centric name
         * enable-migrations
         * add-migration migratinname
         * update-database -verbose
         * add-migration migratinname -IgnorChanges -Force
         * to revert migration and bring the database to and old version use:
         * update-database -TargetMigration:RenameTitleColumnWithNameInCourseTable
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Console.ReadLine();
        }
    }
}
