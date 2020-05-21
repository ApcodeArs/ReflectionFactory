using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionFactory.Models.Reports
{
    [ReportType(ReportType.Lessons)]
    public sealed class LessonsReport: ReportBase
    {
        public LessonsReport(string data) : base(data)
        {
            //todo add some useful logic
        }

        public override void Generate()
        {
            //todo add some generation logic
            Console.WriteLine("Generate LessonsReport");
        }
    }
}
