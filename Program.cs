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
           
            StudentDataWriter();
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
                    dateOfBirth = "O2/O3/1996"
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
                    dateOfBirth = "O1/O8/1999"
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
                    dateOfBirth = "O1/O8/1996"
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
                    dateOfBirth = "O5/O5/1998"
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
                    dateOfBirth = "O2/O5/1997"
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
            Console.WriteLine("File saved as" + Path);


        }
        public static void StudentPromoter()
        {
            Program _StudData = new Program();
            foreach (Student stud in _StudData.students)
            {
                if(stud.informaticsMark + stud.informaticsMark + stud.physicsMark > 150)
                {
                    Console.WriteLine(stud.firstName + " " + stud.surName + "Is promoted");

                }
                else
                {
                    Console.WriteLine(stud.firstName + " " + stud.surName + "Is not promoted");
                }
            }


            
        }
    }
}
