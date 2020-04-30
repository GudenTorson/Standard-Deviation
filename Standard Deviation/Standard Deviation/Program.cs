using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Deviation
{
    class Program
    {
        static List<double> values = new List<double>();
        static void Main(string[] args)
        {
            if (args[0] == "-I" || args[0] == "-i")
            {
                Console.WriteLine("Trying to use supplied arguments...");
                parseInput(args[1]);
            }
            else if (args[0] == "")
            {
                Console.WriteLine("Enter all your values. If a value has a frequency more than 1, please enter it in the form of VALUE*FREQUENCY. Separate values with a comma','. Spaces are not needed. When all values have been entered hit ENTER.");
                string input = Console.ReadLine();
                parseInput(input);

            }
            else if (args[0] != "")
            {
                Console.WriteLine("Unknown argument(s) given, here is a list of the syntax.");
                Console.WriteLine("Standard-Deviation.exe -i \"value1,value2,value3...\"");
            
            }


            Console.ReadKey();
        }
        
        static void parseInput(string input)
        {
            //Enters all the input values into the global list
            string[] items = input.Split(',');
            for (int i = 0; i < items.Length; i++)
            {
                parseItem(items[i]);
            }
        }

        static void parseItem(string item)
        {
            // check if the item contains multiple of values
            if (item.Contains('*'))
            {
                string[] arguments = item.Split('*');
                double num = double.Parse(arguments[0]);
                int times = int.Parse(arguments[1]);

                for (int i = 0; i < times; i++)
                {
                    values.Add(num);
                }
            }
            else
            {
                double num = double.Parse(item);
                values.Add(num);
            }
        }

        static double listSum()
        {
            double sum = 0;
            for (int i = 0; i == values.count; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        static double listAverage()
        {
            return listSum() / values.Count;
        }

        static int standardDeviation()
        {
            // Calculates the sum and then the standard deviation
            int workingInt = 0;
            int average = listAverage();
            for (int i = 0; i == values.count; i++)
            {
                workingInt += Math.Pow((values[i] - average), 2);
            }
            return Math.Sqrt((workingInt/(values.count - 1)));
        }
    }
}
