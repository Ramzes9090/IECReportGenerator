using IECReportGenreator.Models;
using Newtonsoft.Json;

namespace IECReportGenreator.Infrastructure
{
    public class IECWriter
    {
        public void SaveIECModels(string outputFile, IEnumerable<IECModel> models)
        {
            File.WriteAllText(outputFile, JsonConvert.SerializeObject(models));
        }
        
    }
}
