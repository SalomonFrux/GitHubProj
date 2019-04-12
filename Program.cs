using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace TheGitHubProject
{
    public class Program
    {

        static void Main(string[] args)
        {

            //StudentDataWriter();
            //AgeSorter();
            StudentPromoter();
            Console.Read();
        }

        List<Student> students = new List<Student>
            {
                new Student
                {
                    surName = "John ",
                    firstName = "Stenson",
                    sex = 'M',
                    informaticsMark = 95,
                    mathematicsMark = 85,
                    physicsMark = 90,
                    scholarship = "received",
                    dateOfBirth = Convert.ToDateTime("1996/2/3"),
                    age = calculateage(Convert.ToDateTime("1996/2/3"))


    },
                new Student
                {
                    surName = "Mary ",
                    firstName = "Ward",
                    sex = 'F',
                    informaticsMark = 70,
                    mathematicsMark = 50,
                    physicsMark = 70,
                    scholarship = "Not received",
                    dateOfBirth = Convert.ToDateTime("1999/1/8"),
                    age = calculateage(Convert.ToDateTime("1999/1/8"))
                },
                new Student
                {
                    surName = "Ram  ",
                    firstName = "Gerald",
                    sex = 'M',
                    informaticsMark = 10,
                    mathematicsMark = 29,
                    physicsMark = 30,
                    scholarship = "Not received",
                    dateOfBirth = Convert.ToDateTime("1996/1/8"),
                    age = calculateage(Convert.ToDateTime("1996/1/8"))
                },
                new Student
                {
                    surName = "James  ",
                    firstName = "Bynes",
                    sex = 'M',
                    informaticsMark = 95,
                    mathematicsMark = 90,
                    physicsMark = 90,
                    scholarship = " received",
                    dateOfBirth = Convert.ToDateTime("1998/5/5"),
                    age = calculateage(Convert.ToDateTime("1998/5/5"))
                },
                new Student
                {
                    surName = "Nick ",
                    firstName = "Niron",
                    sex = 'M',
                    informaticsMark = 80,
                    mathematicsMark = 50,
                    physicsMark = 60,
                    scholarship = "Not received",
                    dateOfBirth = Convert.ToDateTime( "1997/2/5"),
                    age = calculateage(Convert.ToDateTime("1997/2/5"))
                }
            };



        public static void StudentDataWriter()
        {
            Program _StudData = new Program();

            string Path = "StudentData.txt";
            FileStream fs = new FileStream(Path, FileMode.Create, FileAccess.Write);

            BinaryFormatter Formatter = new BinaryFormatter();



            foreach (Student stud in _StudData.students)
            {
                Formatter.Serialize(fs, stud);
            }
            Console.ForegroundColor = System.ConsoleColor.DarkRed;

            fs.Close();
            Console.WriteLine("File saved as " + Path);


        }
        public static void StudentPromoter()
        {
            Program _StudData = new Program();
            foreach (Student stud in _StudData.students)
            {
                if (stud.informaticsMark + stud.informaticsMark + stud.physicsMark > 150)
                {
                    Console.WriteLine(stud.firstName + " " + stud.surName + "Is promoted " + stud.age);

                }
                else
                {
                    Console.WriteLine(stud.firstName + " " + stud.surName + "Is not promoted " + stud.age);
                }
            }



        }
        public static void AgeSorter()
        {

        }
        public static string calculateage(DateTime dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            DateTime PastYearDate = dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = Now.Subtract(PastYearDate).Hours;
            int Minutes = Now.Subtract(PastYearDate).Minutes;
            int Seconds = Now.Subtract(PastYearDate).Seconds;
            return String.Format("Age: {0} Year {1} Month(s) ",
            Years, Months);
        }
    }
}
