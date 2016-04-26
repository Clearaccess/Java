using System.Collections.Generic;

namespace GenerationText.DAL
{
    public interface IGenerationDAO
    {
        IDictionary<string, List<string>> Getwords();
        void AddWords(List<string> text);
    }
}