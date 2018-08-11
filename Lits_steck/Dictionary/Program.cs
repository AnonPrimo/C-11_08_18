using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 
/// создать рассписание так, что:
/// 
/// есть три класса: група, предмет, день;
/// каждая группа изучает минимум 2 предмета в день;
/// группі не пересекаються;
/// 
/// 
/// </summary>

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, Dictionary<string, List<string>>> timetable = new Dictionary<string, Dictionary<string, List<string>>>();

            /* Dictionary<Subjects, string> subjects = new Dictionary<Subjects, string>();

             List<Subjects> subj = new List<Subjects>();
             subj.Add(new Subjects("History"));


             Days day = new Days();

             // subjects[subj[0]].Add(day.Mon);

             subjects.Add(subj[0], day.Wed);

             foreach (KeyValuePair<Subjects, string> keyValue in subjects)
             {
                 Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
             }*/

            Dictionary<string, List<string>> subjects = new Dictionary<string, List<string>>();

            List<string> subj = new List<string>();
            subj.Add("History");


            Days day = new Days();

            // subjects[subj[0]].Add(day.Mon);

            subjects.Add(subj[0], new List<string>());

            subjects[subj[0]].Add(day.Mon);
            subjects[subj[0]].Add(day.Wed);
            subjects[subj[0]].Add(day.Fry);


            foreach (KeyValuePair<string, List<string>> keyValue in subjects)
            {
                for(int i = 0; i<subjects.Values.Count; ++i)
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value[i]);
            }
            Console.WriteLine();
            for(int i = 0; i < subjects.Values.Count; ++i)
            Console.WriteLine(subjects.Keys + " - " + subjects.Values);

            //Console.WriteLine(subjects.Keys + " - " + subjects.Values);

            /* subjects["History"].Add(day.Tue);
             subjects["History"].Add(day.Fry);

             subjects["Math"].Add(day.Mon);
             subjects["Math"].Add(day.Fry);

             subjects["Programing"].Add(day.Tue);
             subjects["Programing"].Add(day.Thur);

             subjects["Physics"].Add(day.Wed);
             subjects["Physics"].Add(day.Thur);

             subjects["English"].Add(day.Tue);
             subjects["English"].Add(day.Wed);

             subjects["Electronics"].Add(day.Mon);
             subjects["Electronics"].Add(day.Wed);

             timetable.Add("DS-214", subjects);

             timetable.Add("SD-124", subjects);

             Console.WriteLine(timetable);*/

            Console.ReadLine();
        }
    }
}
