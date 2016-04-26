using GenerationText.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenerationText.DAL
{
    public class GenerationDAO : IGenerationDAO
    {
        private static IDictionary<string,List<string>> words;
         
        public GenerationDAO()
        {
            words = this.GetWords();
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

            using (StreamReader input = new StreamReader("inputWords.txt"))
            {
                var result = new Dictionary<string, List<string>>();

                while (!input.EndOfStream)
                {
                    var tempstring = input.ReadLine().Split(' ');

                    result.Add(tempstring[0], tempstring.Skip(1).ToList());         
                }

                return result;
            }
        }

        private void SaveWords()
        {
            using (StreamWriter output = new StreamWriter("inputWords.txt"))
            {
                foreach (var word in words)
                {
                    output.WriteLine(word);
                }
            }
        }
    }
}
