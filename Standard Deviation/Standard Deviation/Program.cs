using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Deviation
{
    class Program
    {
        List<double> values = new List<double>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter all your values. If a value has a frequency more than 1, please enter it in the form of VALUE*FREQUENCY. Separate values with a comma','. Spaces are not needed. When all values have been entered hit ENTER.");
            string input = Console.ReadLine();
            parseInput(input);
        }
        
        static void parseInput(string input)
        {
            //Enters all the input values into the global list
            
        }
    }
}
