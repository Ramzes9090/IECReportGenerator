
using Newtonsoft.Json;
using IECReportGenreator.Models;

namespace IECReportGenreator.Infrastructure
{
    public class WindReader
    {
        public IEnumerable<WindModel> ReadWindModels(string inputFile)
        {
            var jsonText = File.ReadAllText(inputFile);
            var windModels = JsonConvert.DeserializeObject<IEnumerable<WindModel>>(jsonText);

            return windModels;
        }
    }
}
