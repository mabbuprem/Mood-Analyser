using moodAnalyser;
using System;

namespace moodAnalyser
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Mood analyser program.");
            HappyOrSad happySad = new HappyOrSad("I am in sad a mood");
            string Result = happySad.AnalysingMood();
            Console.WriteLine(Result);
        }
    }
}
