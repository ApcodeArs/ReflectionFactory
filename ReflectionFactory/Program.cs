using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReflectionFactory.Models.Reports;

namespace ReflectionFactory
{
    public class Program
    {
        private const int ExpectedArgsCount = 2;

        static void Main(string[] args)
        {
            try
            {
                if (args.Count() != ExpectedArgsCount)
                    throw new ArgumentException($"{ExpectedArgsCount} input parameters was expected");

                //read data from args
                var reportType = (ReportType) Convert.ToInt32(args[0]);
                //todo add conversion logic
                var data = args[1];

                var report = ReportsFactory.GetInstance().Create(reportType, data);

                report.Generate();
                report.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
