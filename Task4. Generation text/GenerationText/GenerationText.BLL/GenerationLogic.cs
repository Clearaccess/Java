using GenerationText.BLL.Interface;
using GenerationText.DAL;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenerationText.BLL
{
    public class GenerationLogic
    {
        private IGenerationDAO data = new GenerationDAO();
        private Random rand = new Random();
        private Dictionary<string, bool> wordsUse;

        public GenerationLogic()
        {
            wordsUse = new Dictionary<string, bool>();

            foreach (var word in data.Getwords().Keys)
            {
                wordsUse.Add(word, false);
            }
        }

        public string GenerateRandom(string word)
        {
            if (!this.data.Getwords().ContainsKey(word))
            {
                throw new ArgumentException("This word not exist");
            }

            if (string.IsNullOrWhiteSpace(word) || string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("Word is empty or consist of WhiteSpace");
            }
            string result = string.Empty;
            int i = 0;
            this.UpdateWordUse();
            //this.InitialisationDfs();
            this.DFS(word,rand.Next(1,100),ref result,ref i);

            return result;
        }

        public string GenerateRandom(int n)
        {
            string result = string.Empty;
            int i = 0;
           // this.InitialisationDfs();
            this.DFS(wordsUse.Keys.ToArray()[rand.Next(1, wordsUse.Count)], n, ref result, ref i);

            return result;
        }

        public void AddText(string text)
        {
            var separator = this.GetSeparator(text);
            var tempstring =text.Split(separator.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            this.data.AddWords(tempstring);
        }

        public void AddFile(string path)
        {
            using (StreamReader input = new StreamReader(path))
            {
                var text = input.ReadToEnd();
                var separator = this.GetSeparator(text);

                this.data.AddWords(text.Split(separator.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList());
            }
        }

        private void InitialisationDfs()
        {
            foreach (var words in wordsUse.Keys)
            {
                this.wordsUse[words] = false;
            }
        }

        private void DFS(string start, int n, ref string result, ref int count)
        {
            if (count == n)
            {
                return;
            }
            result += " " + start;
            count++;
            var dictonary = this.data.Getwords()[start];
            
            this.DFS(dictonary[rand.Next(0, dictonary.Count)], n, ref result, ref count);

            
        }

        private List<string> GetSeparator(string text)
        {
            var separator = new List<string>();
            foreach (var tempChar in text)
            {
                if ((char.IsSeparator(tempChar) || char.IsPunctuation(tempChar)) && !separator.Contains(tempChar.ToString()))
                {
                    separator.Add(tempChar.ToString());
                }
            }

            return separator;
        }

        private void UpdateWordUse()
        {
            wordsUse.Clear();

            foreach (var word in data.Getwords().Keys)
            {
                wordsUse.Add(word, false);
            }
        }

    }
}
