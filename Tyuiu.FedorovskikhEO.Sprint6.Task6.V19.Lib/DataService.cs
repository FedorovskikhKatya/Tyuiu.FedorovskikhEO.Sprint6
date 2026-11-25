using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains("l"))
                        {
                            resStr = resStr + " " + word;
                        }
                    }
                }
            }
            return resStr.Trim();
        }
    }
}
