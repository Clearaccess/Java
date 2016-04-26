
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace GenerationText.DAL
{
    public class GenerationDAO : IGenerationDAO
    {
        private static IDictionary<string,List<string>> words;
         
        public GenerationDAO()
        {
            words = this.GetWords();
        }

        public void AddWords(List<string> text)
        {
            text = text.Select(word => word.Normalize()).ToList();

            if (!words.ContainsKey(text[0].ToLower()))
            {
                words.Add(text[0].ToLower(), new List<string>());
            }
            for (int i = 0; i < text.Count-1; i++)
            {
                if (!words.ContainsKey(text[i + 1].ToLower()))
                {
                    var tempList = new List<string>();
                    tempList.Add(text[i].ToLower());
                    words.Add(text[i + 1].ToLower(), tempList);
                    if (!words.ContainsKey(text[i].ToLower()))
                    {
                        words.Add(text[i].ToLower(), new List<string>());
                    }
                }
                else
                {
                    if (!words[text[i + 1].ToLower()].Contains(text[i].ToLower()))
                    {
                        words[text[i + 1].ToLower()].Add(text[i].ToLower());
                    }
                }
            }

            if (!words.ContainsKey(text.Last().ToLower()))
            {
                words.Add(text.Last().ToLower(), new List<string>());
            }

            this.SaveWords();
        }

        public IDictionary<string, List<string>> Getwords()
        {
            return new Dictionary<string, List<string>>(words);
        }

        private Dictionary<string,List<string>> GetWords()
        {
            if (!File.Exists("inputWords.txt"))
            {
                File.Create("inputWords.txt");
            }

            var result = new Dictionary<string, List<string>>();
            using (StreamReader input = new StreamReader("inputWords.txt"))
            {               
                var tempstringArray = input.ReadToEnd().Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in tempstringArray)
                {
                    var tempstring =item.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                    
                    if(tempstring.Length !=0)
                       result.Add(tempstring[0], tempstring.Skip(1).ToList());
                    
                }
            }

              return result;
        }

        private void SaveWords()
        {
            using (StreamWriter output = new StreamWriter("inputWords.txt"))
            {
                foreach (var word in words)
                {
                    output.WriteLine($"|{word.Key} {string.Join(" ", word.Value.ToArray())}|");
                }
            }
        }
    }
}
