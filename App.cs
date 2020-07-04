using System;
using System.Linq;
using System.Threading;

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
                
                var c = Console.ReadLine();

                if (c == "hjelp") HelpResponse();
                

                if (c == "ny student")
                {
                    var s = new Student().CreateStudent();
                    students.Students.Add(s);
                    WriteL("Student lagt til");
                    Thread.Sleep(700);
                    ClearConsole();
                }

                if (c == "fjern student")
                {
                    var q = AskForId();

                    foreach (var student in students.Students.Where(student => q == student.Id.ToString()))
                    {
                        students.Students.Remove(student);
                        WriteL("Student fjernet");
                        Thread.Sleep(700);
                        ClearConsole();
                        break;
                    }
                }

                if (c == "vis student")
                {

                    foreach (var student in students.Students)
                    {
                        var q = AskForId();

                        var st = student.Id;
                        if (q == st.ToString()) WriteL(student.StudentInfo(courses));
                    }
                }


                if (c == "vis studenter") students.ListStudents(courses);
                


                if (c == "vis kurs") courses.ShowAllCourses();
                

                if (c == "exit") break;
            }

        }

        public static string AskForId()
        {
            return Ask("Student-id: ");
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

        public static void ClearConsole()
        {
            Console.Clear();
        }


    }
    }
