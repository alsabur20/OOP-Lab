using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUP.IN {
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\Week1\\SignUP.IN\\membersData.txt";
            string[] usernames = new string[20];
            string[] passwords = new string[20];
            int option;
            do
            {
                readDataFromFile(path, usernames, passwords);
                Console.Clear();
                option = menu();
                if (option == 1)
                {
                    Console.WriteLine("Enter New Name: ");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter New Password: ");
                    string pass = Console.ReadLine();

                    signUp(path, username, pass);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter Name: ");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter Password: ");
                    string pass = Console.ReadLine();

                    signIn(username, pass, usernames, passwords);

                }
            }
            while (option >= 3);
            Console.Read();
        }
        static int menu()
        {
                int option;
                Console.WriteLine("1. Sign Up");
                Console.WriteLine("2. Sign In");
                Console.WriteLine("Enter Choice: ");
                option = int.Parse(Console.ReadLine());
                return option;
        }

        static void readDataFromFile(string path, string[] usernames, string[] passwords)
        {
           int x = 0;
           if (File.Exists(path))
              {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                   usernames[x] = parseData(record, 1);
                   passwords[x] = parseData(record, 2);
                   x++;
                   if (x >= 5)
                   {
                       break;
                   }
                }
                file.Close();
           }
           else
           {
                Console.WriteLine("User Does Not Exist");
           }
        }
        static void signIn(string uName, string pass, string[] usernames, string[] passwords)
        {
            bool flag=false;
            for (int i = 0; i < 5; i++)
            {
                if (uName == usernames[i] && pass == passwords[i])
                {
                    Console.WriteLine("Valid User!!");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User!!");
            }
            Console.ReadKey();
        }
        static void signUp(string path, string uName, string pass)
        {
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(uName + "," + pass);
            file.Flush();
            file.Close();
        }
        static string parseData(string line, int field)
        {
            string item="";
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
