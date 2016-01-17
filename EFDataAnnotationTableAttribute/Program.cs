using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAnnotationTableAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            EFContext ctx = new EFContext();

            //Querying the Database so that the Context is initialised
            ctx.Customers.Where(e => e.CustomerID == 0);

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
