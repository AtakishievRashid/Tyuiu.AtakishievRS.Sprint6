using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtakishievRS.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.Contains('r'))
                        {
                            result += word + " ";
                        }
                    }
                }
            }

            return result.Trim(); 
        }
    }
}
