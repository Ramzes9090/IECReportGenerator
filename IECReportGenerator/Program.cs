using IECReportGenreator;
using IECReportGenreator.Infrastructure;

var generator = new IECReportGenerator(new WindReader(),
                                       new IECWriter());

generator.GenerateReport("data.json", "iec.json");