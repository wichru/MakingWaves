using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = new SettingRange();
            Console.Write("Please provide your start date: ");
            range.Start = Console.ReadLine();
            Console.Write("Please provide your end date: ");
            range.End = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($@"Your date range is:
            {range.Start} - {range.End}");
            Console.ReadKey();
        }
    }
}