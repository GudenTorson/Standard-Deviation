﻿using System;
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
                switch(args[0].ToLower())
                {
                    case "-l":
                        try
                        {
                            Console.WriteLine("Trying to use supplied arguments...");
                            parseInput(args[1]);
                        }
                        catch
                        {
                            Console.WriteLine("\nUnknown argument(s) given, here is a list of the syntax.");
                            Console.WriteLine("Standard-Deviation-X-X.exe -i \"value1,value2,value3...\" Calculates the standard deviation for the given values");
                            Console.WriteLine("Standard-Deviation-X-X.exe -a Displays information about the application.");
                            Environment.Exit(1);
                        }
                        break;

                    case "-a":
                        // If the argument -A or -a is given display the information abut the application
                        Console.WriteLine("\nStandard Deviation ver " + "0.4");
                        Console.WriteLine("Developed by Elliot Hultgren and Tor Smedberg");
                        Environment.Exit(1);
                        break;

                    default:
                        // If unknown arguments are given , display the help page
                        Console.WriteLine("\nUnknown argument(s) given, here is a list of the syntax.");
                        Console.WriteLine("Standard-Deviation-X-X.exe -i \"value1,value2,value3...\" Calculates the standard deviation for the given values");
                        Console.WriteLine("Standard-Deviation-X-X.exe -a Displays information about the application.");
                        Environment.Exit(1);
                        break;
                }
            }
            else
            {
                // If no arguments are given, launch the program normally
                Console.WriteLine("Enter all your values. If a value has a frequency more than 1, please enter it in the form of VALUE*FREQUENCY. Separate values with a semicolon';'. Spaces are not needed. When all values have been entered hit ENTER.");
                string input = Console.ReadLine();
                parseInput(input);
            }

            Console.WriteLine("\nSum: " + listSum());
            Console.WriteLine("Average: " + listAverage());
            Console.WriteLine("Median: " + listMedian());
            Console.WriteLine("Standard Deviation: " + standardDeviation());

            //Pause so that the user can read the results
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        #region parser
        static void parseInput(string input)
        {
            // parses all the inputed values into the global list
            string[] items = input.Split(';');
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
                int frequency = int.Parse(arguments[1]);

                for (int i = 0; i < frequency; i++)
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

        #region mathFunctions
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

        static double listMedian()
        {
            // sort the list
            values.Sort();

            // check if the list has an odd number of values
            if ((values.Count + 1) % 2 == 0)
            {
                return values[(values.Count + 1) / 2 - 1];
            }
            else
            {
                return (values[values.Count / 2] + values[values.Count / 2 - 1]) / 2;
            }
        }
        #endregion
    }
}
