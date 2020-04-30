using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Deviation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] != "-i" || args[0] != "-i")
            { 
            Console.WriteLine("Enter all your values. If a value has a frequency more than 1, please enter it in the form of VALUE*FREQUENCY. Separate values with a comma','. Spaces are not needed. When all values have been entered hit ENTER.");
            string input = Console.ReadLine();
            listValues(input);
            }

        }
        
        static void listValues(string input)
        {
            //Enters all the input values into the global list
            
        }
    }
}
