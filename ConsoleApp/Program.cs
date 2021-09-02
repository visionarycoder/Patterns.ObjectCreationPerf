using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using ObjectLibrary.Factory;
using ObjectLibrary.Messaging;

namespace ConsoleApp
{

    class Program
    {

        static void Main(string[] args)
        {

            foreach (var range in new[] { 1_000, 10_000, 100_000, 1_000_000, 10_000_000, 100_000_000 })
            {

                var stopwatch = Stopwatch.StartNew();
                foreach (var _ in Enumerable.Range(0, range))
                {
                    var widget = Activator.CreateInstance<Widget>();
                }
                Console.WriteLine($"Activator {range:#,0} => {stopwatch.Elapsed}");

                stopwatch.Restart();
                foreach (var _ in Enumerable.Range(0, range))
                {
                    var widget = new Widget();
                }
                Console.WriteLine($"New       {range:#,0} => {stopwatch.Elapsed}");
            }

        }

    }

    public class Widget
    {
        private static int id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public SqlMoney Price { get; set; }

        public Widget()
        {
            Id = id++;
        }
    }



}