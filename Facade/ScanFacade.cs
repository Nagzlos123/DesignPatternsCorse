using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /*
     * Aggregation and integration of objects from the scanner class.
     */
    public class ScanFacade
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecurityScanner securityScanner = new SecurityScanner();
        private DependencyScanner dependencyScanner = new DependencyScanner();
        private ReportGenerator reportGenerator = new ReportGenerator();

        public void Scan(string githubUrl)
        {
            Console.WriteLine($"Scaning {githubUrl}");

            var qualityScanErrors = qualityScanner.QualityScan(githubUrl);
            var securityScaErrors = securityScanner.SecurityScan(githubUrl);
            var dependencyScanErrors = dependencyScanner.DependencyScan(githubUrl);

            Console.WriteLine("Scan report:");
            reportGenerator.GenerateReport(qualityScanErrors, securityScaErrors, dependencyScanErrors);
        }

    }
}
