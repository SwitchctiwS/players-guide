using System;
using System.IO;

namespace ExtentionMethods {
    class MainClass {
        public static void Main(string[] args) {
            string text = File.ReadAllText(@"/home/jared_thibault/test.txt");
            string[] files = GetCsFileTexts("/media/jared_thibault/SHARED/Projects/Programming/CSharp/_Algorithms/");

            Console.WriteLine("Word Count: {0}", text.WordCount());
            Console.WriteLine($"Sentence Count: {text.SentenceCount()}");
            Console.WriteLine($"Paragraph Count: {text.ParagraphCount()}");
            Console.WriteLine($"Code Line Count: {text.CodeLineCount()}");
            Console.WriteLine($"Code Line Count of Files: {TotalCodeLineCount(files)}");
        }

        public static string[] GetCsFileTexts(string filePath) {
            string[] fileDirs = Directory.GetFiles(filePath, "*.cs");
            string[] files = new string[fileDirs.Length];

            for (int i = 0; i < fileDirs.Length; i++) {
                files[i] = File.ReadAllText(fileDirs[i]);
            }

            return files;
        }

        public static int TotalCodeLineCount(string[] texts) {
            int sum = 0;

            for (int i = 0; i < texts.Length; i++) {
                sum += texts[i].CodeLineCount();
            }

            return sum;
        }
    }
}
