using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReflectionFactory.Helpers;

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
            var reportClassTypes = ReflectionHelper.GetDerivedClasses<ReportBase>();

            var necessaryClassType = reportClassTypes.FirstOrDefault(reportClassType =>
            {
                var reportTypeAttribute = (ReportTypeAttribute)Attribute.GetCustomAttribute(reportClassType, typeof(ReportTypeAttribute));
                return reportType == reportTypeAttribute.ReportType;
            });

            if (necessaryClassType == null)
                throw new ArgumentException($"Can't find class type by {reportType.GetType().Name}.{reportType} type");

            return (ReportBase)Activator.CreateInstance(necessaryClassType, data);
        }
    }
}
