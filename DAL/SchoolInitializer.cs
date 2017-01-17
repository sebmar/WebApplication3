using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using WebApplication3.Models;

namespace WebApplication3.DAL
{

    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
{
new Student{FirstMidName="Carson",LastName="Alexander" },
new Student{FirstMidName="Meredith",LastName="Alonso"},
new Student{FirstMidName="Arturo",LastName="Anand"},
new Student{FirstMidName="Gytis",LastName="Barzdukas"},
new Student{FirstMidName="Yan",LastName="Li"},
new Student{FirstMidName="Peggy",LastName="Justice"},
new Student{FirstMidName="Laura",LastName="Norman"},
new Student{FirstMidName="Nino",LastName="Olivetto"}
};
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
{
new Course{CourseID=1050,Title="Chemistry",Credits=3,},
new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
new Course{CourseID=1045,Title="Calculus",Credits=4,},
new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
new Course{CourseID=2021,Title="Composition",Credits=3,},
new Course{CourseID=2042,Title="Literature",Credits=4,}
};
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
{
new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.BDB},
new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.DST},
new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.DB},
new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.DST},
new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.NDST},
new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.BDB},
new Enrollment{StudentID=3,CourseID=1050},
new Enrollment{StudentID=4,CourseID=1050,},
new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.DB},
new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.DOP},
new Enrollment{StudentID=6,CourseID=1045},
new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.BDB},
};
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
