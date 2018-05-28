using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldClassLibrary.Models;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            messageModel hw = new messageModel();

            //setting the Message here, but the model value could be assigned from an external datasource.
            hw.Message = "Hello World!";

            Console.WriteLine(hw.Message);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
