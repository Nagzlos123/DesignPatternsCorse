﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class CsvGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate csv file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Preparing data for csv");
        }
    }
}

