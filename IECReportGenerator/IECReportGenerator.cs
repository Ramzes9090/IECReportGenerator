using IECReportGenreator.Infrastructure;
using IECReportGenreator.Models;

namespace IECReportGenreator
{
    public class IECReportGenerator
    {
        WindReader _reader;
        IECWriter _writer;

        public IECReportGenerator(WindReader reader, IECWriter writer)
        {
            _reader = reader;
            _writer = writer;   
        }
        public void GenerateReport(string inputFile, string outputFile)
        {
            var windModels = _reader.ReadWindModels(inputFile);
            
            var iecModels = new List<IECModel>();

            foreach (var windModel in windModels) 
            {
                var decimalHeight = decimal.Parse(windModel.Height.ToString());

                var iceModel = new IECModel()
                {
                    Class = windModel.WindClass,
                    Height = decimal.Round(decimalHeight, 1),
                    Power = windModel.Power + "MW",
                    RotorDiameter = windModel.BladeLength * 2
                };
                iecModels.Add(iceModel);
            }

            _writer.SaveIECModels(outputFile, iecModels);
        }

        public IEnumerable<IECModel> GenerateReport(string inputFile)
        {
            var windModels = _reader.ReadWindModels(inputFile);

            var iecModels = new List<IECModel>();

            foreach (var windModel in windModels)
            {
                var decimalHeight = decimal.Parse(windModel.Height.ToString());

                var iceModel = new IECModel()
                {
                    Class = windModel.WindClass,
                    Height = decimal.Round(decimalHeight, 1),
                    Power = windModel.Power + "MW",
                    RotorDiameter = windModel.BladeLength * 2
                };
                iecModels.Add(iceModel);
            }

            return iecModels;
        }
    }
}
