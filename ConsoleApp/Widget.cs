using System.Data.SqlTypes;

namespace ConsoleApp
{
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