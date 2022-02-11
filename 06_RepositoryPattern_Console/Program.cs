using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class Program
    {
        static void Main(string[] args)                     //This method is the Entry to the application or start the application. its Single responsibility is the Entry to the application.  //Any Method should have a single responsibility.
        {
            ProgramUI program = new ProgramUI();            //Making an instance of our ProgramUI   //
            program.Run();                                  //calling our public 'Run' Method
        }
    }
}
