using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmamForms
{
    class ExceptionToText
    {
        private string details;
        private StreamWriter sw;

        public ExceptionToText(string details)
        {
            this.Details = details;
            using (sw = File.AppendText(@"D:\exceptionlog.txt")) //tekstbestand maken indien niet bestaat
            {
                sw.WriteLine(details.ToString()); //exception details schrijven
                sw.WriteLine(DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString()); //tijd en datum schrijven
                sw.WriteLine(""); //wit regel tovoegen
            }
            sw.Close();
        }

        public string Details { get => details; set => details = value; }

        public override string ToString()
        {
            return details.ToString() + DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        }
    }
}
