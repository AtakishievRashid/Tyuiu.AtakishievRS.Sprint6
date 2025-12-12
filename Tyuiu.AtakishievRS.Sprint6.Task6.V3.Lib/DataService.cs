using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtakishievRS.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            string searchChar = "r"; // только строчная 'r'

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Ищем только строчную 'r'
                    if (line.Contains(searchChar))
                    {
                        result += line + Environment.NewLine;
                    }
                }
            }

            return result.Trim();
        }
    }
}
