using System;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new StudentContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
