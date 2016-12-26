using System;

namespace ExtentionMethods {
    public static class StringExtentions {
        public static int WordCount(this string text) {
            string[] arr = text.Split(new string[] { "\r", "\n", "\t", " " }, StringSplitOptions.None);

            return arr.Length;
        }
    }
}

