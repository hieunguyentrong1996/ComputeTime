using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var span = ComputeTime(DateTime.Now, DateTime.Now.AddDays(1).AddHours(2).AddMinutes(45));
            Console.WriteLine(span);
            Console.ReadKey();
        }
        public static string ComputeTime(DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            TimeSpan span = (dateTimeEnd - dateTimeStart);
            return String.Format($"{span.Days} days, {span.Hours} hours, {span.Minutes} minutes, {span.Seconds} seconds, {span.Milliseconds} milliseconds");
        }
    }
}
