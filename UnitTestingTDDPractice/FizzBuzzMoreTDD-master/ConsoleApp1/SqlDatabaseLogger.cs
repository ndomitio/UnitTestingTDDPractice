using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SqlDatabaseLogger : ILogger
    {
        public void Log(string v)
        {
            Console.WriteLine("This was sent to the DB" + v.ToString());
        }
    }
}
