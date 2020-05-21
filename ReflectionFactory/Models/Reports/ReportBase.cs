using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionFactory.Models.Reports
{
    public abstract class ReportBase
    {
        protected string Data;

        protected ReportBase(string data)
        {
            Data = data;
        }

        public abstract void Generate();

        /// <returns>Output report full path</returns>
        public string Save()
        {
            //todo add save logic 
            Console.WriteLine("Save report");
            
            return string.Empty;
        }
    }
}