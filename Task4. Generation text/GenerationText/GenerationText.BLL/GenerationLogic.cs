using GenerationText.BLL.Interface;
using GenerationText.DAL;
using GenerationText.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationText.BLL
{
    public class GenerationLogic: IGenerationLogic
    {
        IGenerationDAO data = new GenerateDAO();

        public string GetGenerateText1()
        {
            Dictionary<string, List<string>> words = this.data.GetWords();
            Dictionary<string, int> relWords = new Dictionary<string, int>();
            int num = 0;
            foreach(string i in words.Keys)
            {
                relWords.Add(i,num);
            }
            Random rnd = new Random(words.Count);
            List<string> outputText = DFS(rnd.Next());
            return;
        }

        public string GetGenerateText2(char begWord)
        {
            return;
        }

        public string GetGenerateText3(int countWords)
        {
            return;
        }

        private void Generation1(string top)
        {
            Dictionary<string, bool> use = new Dictionary<string, bool>();
        }

        private
    }
}
