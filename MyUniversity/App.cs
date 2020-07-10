using System;
using System.Linq;

namespace MyUniversity
{
    class App
    {

        public static void HelpResponse()
        {
            WriteL("'vis studenter' - viser liste over studenter og om de er meldt på kurs\n" +
                              "'vis kurs' - lister opp alle kurs, deltagere, og Id for å melde på/av studenter\n" +
                              "'ny student' - lag/legg til en ny student\n" +
                              "'vis student' - viser studenten som er knyttet opp mot sin Id\n" +
                              "'meld av' - meld av en student fra et kurs\n" +
                              "'meld på' - meld en student på et kurs\n" +
                              "'fjern student' - fjern student ved å skrive inn student-Id\n" +
                              "'cc' fjerner all tekst i konsollet, dataene er fortsatt lagret\n" +
                              "'exit' - avslutt programmet\n");

        }

        public static void Welcome()
        {
            WriteL("Velkommen til universitetet, i dette programmet\n" +
                              "brukes kommandoer til å se, endre, og lage studenter og kurs,\n" +
                              "skriv 'hjelp' uten anførselstegn (gjelder alle kommandoer) for liste over kommandoer\n");

        }


        public static void RunApp(UniStudents students, UniCourses courses)
        {
            while (true)
            {

                


                var command = Console.ReadLine();

                switch (command)
                {
                    case "hjelp": HelpResponse(); break;


                    case "ny student":
                    {
                        var s = new Student().CreateStudent(students);
                        students.Students.Add(s);
                        WriteL("Student lagt til");
                        break;
                    }

                    

                    case "fjern student":
                    {
                       var q = AskNum("Student-id: "); 
                       WriteL(students.RemoveStudent(q)); 
                       break;
                    }
                        
                    
                    case "vis kurs": WriteL(courses.ShowAllCourses()); break;

                    case "vis studenter": WriteL(students.ListStudents()); break;
                }

                if (command == "meld på")
                {
                    var q = AskNum("student-id: ");
                    var q2 = AskNum("Kurs-id: ");

                    foreach (var student in students.Students.Where(s => s.Id == q))
                    {
                        foreach (var course in courses.Courses.Where(c => c.IdCourse == q2))
                        {
                            WriteL(student.AddCourse(course));
                        }
                       
                    }
                    
                }

                if (command == "meld av")
                {
                    var q = AskNum("student-id: ");
                    var q2 = AskNum("Kurs-id: ");

                    foreach (var student in students.Students.Where(s => s.Id == q))
                    {
                        foreach (var course in courses.Courses.Where(c => c.IdCourse == q2))
                        {
                            WriteL(student.RemoveCourse(course));
                        }
                    }
                }


                if (command == "vis student")
                {
                    var q = AskNum("Student-id: ");
                    WriteL(students.FindStudent(q));
                }

                if (command == "cc") Console.Clear();
                if (command == "exit") break;
            }

        }

        public static int AskNum(string question)
        {
            Console.Write(question);
            var id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public static string Ask(string question)
        {
            Console.Write(question);
            var answer = Console.ReadLine();
            return answer;
        }

        public static void WriteL(string text)
        {
            Console.WriteLine(text);
        }


    }
    }
