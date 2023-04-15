using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minOrders, minPrice;
            Console.Write("Enter number of minimum orders: ");
            minOrders = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum price of order: ");
            minPrice = int.Parse(Console.ReadLine());
            pizza_points(minOrders, minPrice);
            Console.ReadKey();
        }
        static void pizza_points(int minOrders, int minPrice)
        {

            string[] customers = new string[2];
            int[] orders = new int[2];
            int[] counts = new int[2];
            int count = 0;
            string path = "E:\\Week1\\SA2\\Customers.txt.txt";
            if (File.Exists(path))
            {
                int x = 0;
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    customers[x] = parseData(record, 1);
                    orders[x] = int.Parse(parseData(record, 2));
                    string temp = parseData(record, 3);
                    string temp1 = "";
                    for (int i = 1; i < temp.Length - 1; i++)
                    {
                        temp1 += temp[i];
                    }
                    for (int i = 1; i < orders[x] + 1; i++)
                    {
                        int temp2 = int.Parse(parseDataByComma(temp1, i));
                        if (temp2 >= minPrice)
                        {
                            count++;
                        }
                    }
                    counts[x] = count;
                    if (count > minOrders)
                    {
                        Console.WriteLine(customers[x]);
                    }
                }
            }
        }
        static string parseData(string line, int field)
        {
            string item = "";
            int spaceCount = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    spaceCount++;
                }
                else if (field == spaceCount)
                {
                    item += line[i];
                }
            }
            return item;
        }
        static string parseDataByComma(string line, int field)
        {
            string item = "";
            int commaCount = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    commaCount++;
                }
                else if (field == commaCount)
                {
                    item += line[i];
                }
            }
            return item;
        }
    }
}
