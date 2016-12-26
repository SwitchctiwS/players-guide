using System;

namespace ExtentionMethods {
    public static class StringExtentions {
        public static int WordCount(this string text) {
            string[] arr = text.Split(new char[] { '\r', '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return arr.Length;
        }

        public static int SentenceCount(this string text) {
            string[] arr = text.Split('.');

            return arr.Length - 1;
        }

        public static int ParagraphCount(this string text) {
            string[] arr = text.Split('\n');

            return arr.Length - 1;
        }

        public static int CodeLineCount(this string text) {
            string[] arr = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return arr.Length;
        }
    }
}