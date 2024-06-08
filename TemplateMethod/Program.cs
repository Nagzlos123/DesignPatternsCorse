using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** PDF ****");
            var pdfGenerator = new PdfGenerator();
            pdfGenerator.GenerateRaport();

            Console.WriteLine("**** CSV ****");
            var csvGenerator = new CsvGenerator();
            csvGenerator.GenerateRaport();

            Console.WriteLine("**** Excel ****");
            var excelGenerator = new ExcelGenerator();
            excelGenerator.GenerateRaport();
            Console.ReadLine();
        }
    }
}
