
using System.Dynamic;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;

namespace lab4
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(GetEverySentenceWord(Console.ReadLine()));
            Console.WriteLine("-------------------------");
            foreach (var sentence in GetSentencesWithoutWord(Console.ReadLine(), Console.ReadLine()))
                Console.WriteLine(sentence.ToString());
        }

        public static string GetEverySentenceWord(string text)
        {
            var words = GetWords(text);
            var wordsFreq = new Dictionary<string, int>();
            foreach (var sentence in words)
                foreach (var word in sentence)
                {
                    if (!wordsFreq.ContainsKey(word)) wordsFreq.Add(word, 1);
                    else wordsFreq[word]++;
                }
            foreach (var word in wordsFreq)
                if (word.Value == words.Count)
                    return word.Key;
            return "";
        }

        static List<List<string>> GetWords(string text)
        {
            List<List<string>> words = new();
            foreach (var sentence in text.Split(
                new char[] { ';', '!', '?', '.' },
                System.StringSplitOptions.RemoveEmptyEntries))
            {
                var resultSentence = new List<string>();
                bool isWord = false;
                int wordStart = 0;
                for (int i = 0; i < sentence.Length; i++)
                {
                    if ((sentence[i] == '\'' || char.IsLetter(sentence[i])) && !isWord)
                    {
                        isWord = true;
                        wordStart = i;
                        continue;
                    }
                    if (!(sentence[i] == '\'') && !char.IsLetter(sentence[i]) && isWord)
                    {
                        isWord = false;
                        resultSentence.Add(sentence[wordStart..i].ToLower());
                    }
                }
                if (isWord) resultSentence.Add(sentence[wordStart..].ToLower());
                if (resultSentence.Count > 0) words.Add(resultSentence);
            }
            return words;
        }

        public static List<StringBuilder> GetSentencesWithoutWord(string text, string word)
        {
            var sentences = new List<StringBuilder>();
            const string datePattern = @"(0[1-9]|[12][0-9]|3[01])[/.](0[1-9]|1[012])[/.](\d\d\d\d|\d\d)";
            foreach (var sentence in text.Split(
                new char[] { ';', '!', '?' },
                System.StringSplitOptions.RemoveEmptyEntries))
                if (!sentence.Contains(word) && Regex.IsMatch(sentence, datePattern))
                {
                    sentences.Add(new StringBuilder(sentence));
                }
            return sentences;
        }
    }
}