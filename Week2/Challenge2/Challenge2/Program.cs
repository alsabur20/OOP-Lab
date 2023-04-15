using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.BL;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Credentials[] c = new Credentials[5];
            int count = 0;
            ReadFromFile(c, ref count);
            char option;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == '1')
                {
                    Console.Clear();
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    c[count] = SignUp(username, password);
                    count++;
                    WriteToFile(c, count);
                    Console.WriteLine("Signed UP successfully");
                    Console.Write("Press any key to continue..");
                    Console.ReadKey();
                }
                else if (option == '2')
                {
                    Console.Clear();
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    bool x = CheckCredentials(c, count, username, password);
                    if (x == true)
                    {
                        Console.WriteLine("Signed In successfully");
                        Console.Write("Press any key to continue..");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Credentials!!!");
                        Console.Write("Press any key to continue..");
                        Console.ReadKey();
                    }
                }
                else if (option == '3')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice!!!");
                }
            }
            while (option != '3');
            Console.Write("Press any key to exit..");
            Console.ReadKey();
        }
        static char Menu()
        {
            char option;
            Console.WriteLine("1. Sign UP");
            Console.WriteLine("2. sign IN");
            Console.WriteLine("3. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static Credentials SignUp(string username, string password)
        {
            Credentials c1 = new Credentials();
            c1.username = username;
            c1.password = password;
            return c1;
        }
        static bool CheckCredentials(Credentials[] c, int count, string username, string password)
        {
            bool x = false;
            for (int i = 0; i < count; i++)
            {
                if (c[i].username == username && c[i].password == password)
                {
                    x = true;
                    break;
                }
            }
            return x;
        }
        static void WriteToFile(Credentials[] c, int count)
        {
            string path = "E:\\Week2\\Challenge2\\membersdata.txt";
            StreamWriter myFile = new StreamWriter(path);
            for (int i = 0; i < count; i++)
            {
                myFile.WriteLine(c[i].username + "," + c[i].password);
            }
            myFile.Flush();
            myFile.Close();
        }
        static void ReadFromFile(Credentials[] c, ref int count)
        {
            string path = "E:\\Week2\\Challenge2\\membersdata.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    c[count] = new Credentials();
                    string[] data = record.Split(',');
                    c[count].username = data[0];
                    c[count].password = data[1];
                    count++;
                    if (count >= 5)
                    {
                        break;
                    }
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Unable to Load Data!!");
            }
        }
    }
}
