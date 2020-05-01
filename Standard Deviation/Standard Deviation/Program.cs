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
            if (args.Length > 0)
            {
                if (args[0] == "-L" || args[0] == "-l")
                {
                    // If the arguments -L or -l are supplied use the supplied arguments
                    try
                    {
                        Console.WriteLine("Trying to use supplied arguments...");
                        parseInput(args[1]);
                    }
                    catch
                    {
                        Console.WriteLine("Unknown argument(s) given, here is a list of the syntax.");
                        Console.WriteLine("Standard-Deviation.exe -i \"value1,value2,value3...\"");
                        Environment.Exit(1);
                    }

                }
                
                else if (args[0] != "")
                {
                    // If unknown arguments are given , display the help page
                    Console.WriteLine("Unknown argument(s) given, here is a list of the syntax.");
                    Console.WriteLine("Standard-Deviation.exe -i \"value1,value2,value3...\"");
                    Environment.Exit(1);
                }
            }
            else
            {
                // If no arguments are given, launch the program normally
                Console.WriteLine("Enter all your values. If a value has a frequency more than 1, please enter it in the form of VALUE*FREQUENCY. Separate values with a comma','. Spaces are not needed. When all values have been entered hit ENTER.");
                string input = Console.ReadLine();
                parseInput(input);
            }

            double std = standardDeviation();
            Console.WriteLine("\nStandard Deviation: " + std);

            //Pause so that the user can read the results
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        #region parser
        static void parseInput(string input)
        {
            // parses all the inputed values into the global list
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
        #endregion

        #region mathFunction
        static double listSum()
        {
            // Calculates the sum for all the values in the list
            double sum = 0;
            for (int i = 0; i < values.Count; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        static double listAverage()
        {
            // Calculates the average for the list
            return listSum() / values.Count;
        }

        static double standardDeviation()
        {
            // Calculates the standard deviation for the list
            double temp = 0;
            double average = listAverage();
            for (int i = 0; i < values.Count; i++)
            {
                temp += Math.Pow((values[i] - average), 2);
            }
            return Math.Sqrt((temp / (values.Count - 1)));
        }
        #endregion
    }
}
