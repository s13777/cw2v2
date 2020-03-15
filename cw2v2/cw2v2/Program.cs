using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace cw2v2
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                var path = @"/Users/Trzeciak/Desktop/dane.csv";
                Console.WriteLine("Hello World!");
                var fi = new FileInfo(path);
                var hash = new HashSet<Student>(new OwnComparer());
                var todaysDate = DateTime.Today;
                using (var stream = new StreamReader(fi.OpenRead()))
                {
                    string line = null;
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] kolumny = line.Split(',');
                        var newStudent = new Student
                        {
                            FirstName = kolumny[0],
                            LastName = kolumny[1],
                            StudiesName = kolumny[2],
                            StudiesMode = kolumny[3],
                            IndexNumber = "s" + kolumny[4],
                            BirthDate = kolumny[5],
                            Mail = kolumny[6],
                            MothersName = kolumny[7],
                            FathersName = kolumny[8]
                        };
                    }
                }
                XDocument xmlFile = new XDocument(new XElement("uczelnia",
                                   new XAttribute("createdAt", todaysDate),
                                    new XAttribute("author", "Dominik Kabala"),

                                   new XElement("studenci",
                                       from student in hash
                                       select new XElement("student",
                                           new XAttribute("indexNumber", student.IndexNumber),
                                           new XElement("fname", student.FirstName),
                                           new XElement("lname", student.LastName),
                                           new XElement("birthdate", student.BirthDate),
                                           new XElement("email", student.Mail),
                                           new XElement("mothersName", student.MothersName),
                                           new XElement("fathersName", student.FathersName),
                                           new XElement("studies",
                                               new XElement("name", student.StudiesName),
                                               new XElement("mode", student.StudiesMode)
                                           )
                                       )
                                   )));

                xmlFile.Save(@"/Users/Trzeciak/Desktop/result.xml");

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex + "bledna sciezka");

            }

            catch (FileNotFoundException ex)
            {

                Console.WriteLine(ex + "Plik nie istnieje");



            }
        }
    }
}
