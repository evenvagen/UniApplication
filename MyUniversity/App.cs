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
                        var q = AskForId();

                        foreach (var student in students.Students.Where(student => q == student.Id.ToString()))
                        {
                            students.Students.Remove(student);
                            WriteL($"Student {student.Id} fjernet");
                            break;
                        }
                        break;
                    }
                        
                      
                    case "vis studenter": students.ListStudents(); break;

                    case "vis kurs": courses.ShowAllCourses(); break;
                }


                if (command == "vis student")
                {
                    var q = AskForId();

                    foreach (var student in students.Students)
                    {
                        var st = student.Id;
                        if (q == st.ToString()) WriteL(student.StudentInfo());
                    }
                }


                if (command == "exit") break;
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



    }
    }
