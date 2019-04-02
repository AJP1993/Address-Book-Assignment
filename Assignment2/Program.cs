using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Program
    {
        public static String[,] addressBook = new String[10,2];
        
        public static int Choice = 0;
        public static int record;

        public static char yesNo;

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                addressBook[i, 0] = "XXXXXX";
                addressBook[i, 1] = "XXXXXX";
            }
            
            do{
                Console.Clear();

                Console.WriteLine(" --------------------");
                Console.WriteLine("| Address book       |");
                Console.WriteLine(" --------------------");
                Console.WriteLine("  1. Add Entry");
                Console.WriteLine("  2. Delete Entry");
                Console.WriteLine("  3. Print Book to screen");
                Console.WriteLine("  4. Edit a Record");
                Console.WriteLine("  5. Search for a Record");
                Console.WriteLine("  6. Exit");
                Choice = Convert.ToInt32(Console.ReadLine());

                if (Choice == 1)
                {
                    Console.Clear();

                    Console.WriteLine(" --------------------");
                    Console.WriteLine("| Add Entry          |");
                    Console.WriteLine(" --------------------");

                    
                    Console.WriteLine("Please choose an empty record number for the new record");

                    record = Convert.ToInt32(Console.ReadLine());
                    record = record - 1;

                    if (addressBook[record,0] == "XXXXXX")
                    {
                        Console.WriteLine("Enter the First Name and Last Name");
                        Console.WriteLine("(Format: Last Name, First Name)");
                        addressBook[record, 0] = Console.ReadLine();

                        Console.WriteLine("Enter the Address");
                        Console.WriteLine("(Format: Number, Road Name, Town Name)");
                        addressBook[record, 1] = Console.ReadLine();

                        Console.WriteLine("Record added, returning to menu");
                    }

                    else
                    {
                        Console.WriteLine("Record full, returning to menu");
                    }

                    Console.ReadLine();
                }

                if (Choice == 2)
                {
                    Console.Clear();

                    Console.WriteLine(" --------------------");
                    Console.WriteLine("| Delete Entry       |");
                    Console.WriteLine(" --------------------");

                    Console.WriteLine("Please choose a record to delete");

                    record = Convert.ToInt32(Console.ReadLine());
                    record = record - 1;

                    if (addressBook[record, 0] == "XXXXXX")
                    {
                        Console.WriteLine("Record is already empty, returning to menu");
                    }

                    else
                    {
                        Console.WriteLine("Deleting Record no. " + record + ": " + addressBook[record, 0]);
                        Console.WriteLine("Are you sure you want to delete this record? (y/n)");

                        yesNo = Convert.ToChar(Console.ReadLine());

                        if (yesNo == 'y')
                        {
                            addressBook[record, 0] = "XXXXXX";
                            addressBook[record, 1] = "XXXXXX";
                            
                            Console.WriteLine("Record deleted, returning to menu");
                        }

                        else
                        {
                            Console.WriteLine("Deletion aborted, returning to menu");
                        }
                    }

                    Console.ReadLine();
                }

                if (Choice == 3)
                {
                    Console.Clear();

                    Console.WriteLine(" ----------------------");
                    Console.WriteLine("| Print Book to screen |");
                    Console.WriteLine(" ----------------------");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Record " + (i + 1));

                        if (addressBook[i, 0] == "XXXXXX")
                        {
                            Console.WriteLine("EMPTY");
                        }

                        else
                        {
                            Console.WriteLine("Name: " + addressBook[i, 0]);
                            Console.WriteLine("Address: " + addressBook[i, 1]);
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine("Press enter to return to the menu");

                    Console.ReadLine();
                }

                if (Choice == 4)
                {
                    Console.Clear();

                    Console.WriteLine(" --------------------");
                    Console.WriteLine("| Edit a Record      |");
                    Console.WriteLine(" --------------------");

                    Console.ReadLine();
                }

                if (Choice == 5)
                {
                    Console.Clear();

                    Console.WriteLine(" ---------------------");
                    Console.WriteLine("| Search for a Record |");
                    Console.WriteLine(" ---------------------");

                    Console.ReadLine();
                }
                
            
            
            }while (Choice != 6);

        }
    }
}
