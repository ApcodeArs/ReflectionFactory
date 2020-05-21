using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionFactory.Models.Reports
{
    public class ReportsFactory
    {
        #region Singleton
        private static ReportsFactory _instance;

        private ReportsFactory() { }

        public static ReportsFactory GetInstance()
        {
            if (_instance == null)
                _instance = new ReportsFactory();

            return _instance;
        }
        #endregion

        public ReportBase Create(ReportType reportType, string data)
        {
            switch (reportType)
            {
                case ReportType.Lessons:
                    return new LessonsReport(data);
                case ReportType.Tests:
                    return new TestsReport(data);
                default:
                    throw new ArgumentException($"Can't find class type by {reportType.GetType().Name}.{reportType} type");
            }
        }
    }
}
