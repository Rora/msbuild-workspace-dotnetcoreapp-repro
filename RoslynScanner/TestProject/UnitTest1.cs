using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoslynScanner;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            Scanner.Init();
        }

        [TestMethod]
        public async Task ScanNet50Project()
        {
            //This one fails (I think because it doesn't load in any referenced assemblied)
            await Scanner.ScanAsync("..\\..\\..\\..\\RoslynScanner.sln", "Net50ProjectToAnalyze");
        }

        [TestMethod]
        public async Task ScanNetCoreApp31Project()
        {
            //This one fails (I think because it doesn't load in any referenced assemblied)
            await Scanner.ScanAsync("..\\..\\..\\..\\RoslynScanner.sln", "NetCoreApp31ProjectToAnalyze");
        }

        [TestMethod]
        public async Task ScanNetStandard20Project()
        {
            //This one succeeds
            await Scanner.ScanAsync("..\\..\\..\\..\\RoslynScanner.sln", "NetStandard20ProjectToAnalyze");
        }
    }
}
