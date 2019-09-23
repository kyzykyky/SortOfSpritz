using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpritzByMe
{
    public class LinkedListWithInit<T> : LinkedList<T>
    {
        public void Add(T item)
        {
            ((ICollection<T>)this).Add(item);
        }
    }

    public class StringManipulator
    {
        public static string[] TrimSpaces(string text)
        {
            while (text.Contains("  ")) { text = text.Replace("  ", " "); }
            return text.Split();
        }
        public static string LetterPainter(string word) //ToDo
        {
            if (word.Length > 1)
            {
                char[] wordo = word.ToCharArray();
                wordo[wordo.Length / 2] = wordo[wordo.Length / 2];
                word = wordo.ToString();
            }
            return word;
        }
        public static string[] Punctuation(string[] text)
        {
            string textt = string.Join(" ", text);
        	while (textt.Contains("?")) { textt = textt.Replace("?", " ?"); }
        	while (textt.Contains(".")) { textt = textt.Replace(".", " ."); }
        	while (textt.Contains(",")) { textt = textt.Replace(",", " ,"); }
        	return textt.Split();
        }
        public static async void AdditionalAwait(string word) //ToDo
        {
        	

            if (word.Contains(","))
            {
                await Task.Delay(500);
            }
            else if (word.Contains("."))
            {
                await Task.Delay(1000);
            }
            else if (word.Contains("!"))
            {
                await Task.Delay(1000);
            }
            else if (word.Contains("?"))
            {
                await Task.Delay(1000);
            }
        }
    }
        public class InfoBoard : StringManipulator
    {
        public static string WordCounter(string text)
        {
            int count = 0;
            string[] texted = TrimSpaces(text);
            foreach (string word in texted) count++;
            return Convert.ToString(count-1);
        }
        
    }
    public class WordsPerMinute 
    {
        public Dictionary<string, int> WPMdic = new Dictionary<string, int> { {"100",600 },{ "150", 400 }, { "200", 300 }, { "250", 240 }, { "300", 200 }, { "350", 171 }, { "400", 150 }, { "450", 133 }, { "500", 120 }, { "550", 109 }, { "600", 100 }, { "650", 90 }, { "700", 85 }, { "750", 80 }, { "800", 75 }, { "850", 70 }, { "900", 66 }, { "950", 63 }, { "1000", 60 }, { "1050", 57 }, { "1100", 54 }, { "1150", 52 }, { "1200", 50 } };
        static LinkedList<int> Delays = new LinkedListWithInit<int> { 600,400,300,240,200,171,150,133,120,109,100,90,85,80,75,70,66,63,60,57,54,52,50};
        public LinkedListNode<int> currentDelay = Delays.First;
    }
}
