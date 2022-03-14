using System;

namespace UpperSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "bU tasKI metHodla yAzmAliSiz";
            sentence= sentence.ToLower();
            Console.WriteLine(CapitalLeterr(sentence));

        }
        public static string CapitalLeterr(string sentence)
        {
            sentence = sentence.Replace('b', 'B');
            sentence = sentence.Replace("taski", "Taski");
            sentence = sentence.Replace("methodla", "Methodla");
            sentence = sentence.Replace('y', 'Y');

            return sentence;
        }
    }
    
}
