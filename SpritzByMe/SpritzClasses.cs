using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpritzByMe
{
    public class LinkedListWithInit<T> : LinkedList<T>
    {
        public void Add(T item)
        {
            ((ICollection<T>)this).Add(item);
        }
    }
    public class StateHandler 
    {
        
    }

    public class StringInfo
    {
        public static string[] TrimSpaces(string text)
        {
            while (text.Contains("  ")) { text = text.Replace("  ", " "); }
            while (text.Contains("\t")) { text = text.Replace("\t", " "); }
            while (text.Contains("\n")) { text = text.Replace("\n", " "); }
            return text.Split();
        }
    }
        public class InfoBoard : StringInfo
    {
        public static string WordCounter(string text)
        {
            int count = 0;
            string[] texted = TrimSpaces(text);
            foreach (string word in texted) count++;
            return Convert.ToString(count);
        }
    }
    public class WordsPerMinute // TODO
    {
        public Dictionary<string, int> WPMdic = new Dictionary<string, int> { {"100",600 },{ "150", 400 }, { "200", 300 }, { "250", 240 }, { "300", 200 }, { "350", 171 }, { "400", 150 }, { "450", 133 }, { "500", 120 }, { "550", 109 }, { "600", 100 }, { "650", 90 }, { "700", 85 }, { "750", 80 }, { "800", 75 }, { "850", 70 }, { "900", 66 }, { "950", 63 }, { "1000", 60 }, { "1050", 57 }, { "1100", 54 }, { "1150", 52 }, { "1200", 50 } };
        static LinkedList<int> Delays = new LinkedListWithInit<int> { 600,400,300,240,200,171,150,133,120,109,100,90,85,80,75,70,66,63,60,57,54,52,50};
        public LinkedListNode<int> currentDelay = Delays.First;
    }
}
