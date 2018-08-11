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

            Dictionary<string, string> subjects = new Dictionary<string, string>();

            List<Subjects> subj = new List<Subjects>();
            subj.Add(new Subjects("History"));


            Days day = new Days();

            // subjects[subj[0]].Add(day.Mon);

            subjects.Add(subj[0].ToString(), day.Wed);

            foreach (KeyValuePair<string, string> keyValue in subjects)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

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
