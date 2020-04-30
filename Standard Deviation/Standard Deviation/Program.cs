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
            Console.WriteLine("Enter all your values. If a value has a frequency more than 1, please enter it in the form of VALUE*FREQUENCY. Separate values with a comma','. Spaces are not needed. When all values have been entered hit ENTER.");
            string input = Console.ReadLine();
            parseInput(input);

            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values[i]);
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
    }
}
