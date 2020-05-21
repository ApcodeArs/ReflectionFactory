using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionFactory.Models.Reports
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ReportTypeAttribute : Attribute
    {
        public ReportType ReportType { get; }

        public ReportTypeAttribute(ReportType reportType)
        {
            ReportType = reportType;
        }
    }
}
