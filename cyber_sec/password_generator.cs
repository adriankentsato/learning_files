using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace PassGen2
{
    class Program
    {
        private static string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "password.txt");

        private static readonly object _objectLock = new object();

        private static Thread[] th;

        static void Main(string[] args)
        {
            int lengthA;
            int lengthB;

            if (File.Exists(_filePath)) // Check if file exists
                File.Delete(_filePath); // Delete if exists
            else
                using (var sw = File.CreateText(_filePath)) // Create the file
                    sw.WriteLine("Test Password Generator"); // Write to file

            Console.Write("Input Length A : ");
            if (int.TryParse(Console.ReadLine(), out lengthA))
            {
                Console.Write("Input Length B : ");
                if (int.TryParse(Console.ReadLine(), out lengthB))
                {
                    Console.Write("Input Exclusive Chars : ");
                    string exclusiveChars = Console.ReadLine();

                    if (lengthA > lengthB)
                    {
                        int d = lengthA;
                        lengthA = lengthB;
                        lengthB = d;
                    }

                    // Sort out characters
                    List<char> x = exclusiveChars.ToList();
                    x.Sort();
                    exclusiveChars = null;
                    exclusiveChars = string.Concat(x);

                    th = null; // Remove instances of the previous thread

                    // Create new thread array with number of threads total to
                    // smallest length of the password to the longest length
                    th = new Thread[(lengthB - lengthA) + 1];

                    // Initialize the threads
                    for (int i = 0; i < th.Length; i++)
                    {
                        // Get the password length for the current thread
                        int g = lengthA + i;

                        Thread er = new Thread(() => combination(exclusiveChars, g, g)) { IsBackground = true };
                        er.Name = i.ToString();

                        th[i] = er;
                    }

                    foreach (Thread f in th)
                    {
                        f.Start();
                    }

                    int wer = th.Length;
                    int[] w = new int[th.Length];

                    for (int i = 0; i < w.Length; i++)
                    {
                        w[i] = 0;
                    }

                    while (wer > 0)
                    {
                        for (int i = 0; i < th.Length; i++ )
                        {
                            if (!th[i].IsAlive && w[i] == 0)
                            {
                                wer--;
                                w[i] = 1;
                            }
                        }
                    }

                    Console.WriteLine("Ended all Threads");

                    if (th != null)
                    {
                        foreach (Thread t in th)
                        {
                            if (t.IsAlive)
                            {
                                t.Abort();
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }

            Console.ReadKey();
        }

        private static void combination(string exclusiveChars, int lengthFrom, int lengthTo)
        {
            // this is the output data
            //char[] data = new char[lengthTo];
            // Create and initialize password data
            char[] data = Enumerable.Repeat(exclusiveChars[0], lengthTo).ToArray();

            // this is the current character of the current position
            //int[] dataPos = new int[lengthTo];
            // Create and initialize password data positions
            int[] dataPos = Enumerable.Repeat(1, lengthTo).ToArray();

            // initialize all characters to the first characters
            // and all position of the current character to 1

            //for (int i = 0; i < lengthTo; i++)
            //{
            //    data[i] = exclusiveChars[0];
            //    dataPos[i] = 1;
            //}

            // loop from the shortest length to longest length
            //while (lengthFrom <= lengthTo)
            //{
            // start from the right most position
            int i = lengthFrom;

            // if the position goes beyond position zero then stop
            while (i > 0)
            {
                // decrement position to adjust
                i--;

                // Output new password
                if (i == lengthFrom - 1)
                {
                    // lock the thread
                    lock (_objectLock)
                    {
                        var line = string.Concat(data) + "\n";

                        // Open the file
                        using (var sw = new StreamWriter(_filePath, true))
                        {
                            // Write the generated password
                            sw.WriteLine(line);
                            sw.Close();
                        }

                        Console.Write("Thread " + lengthFrom + " - " + line);
                    }
                }
                // End - output new password

                // Update the data
                data[i] = exclusiveChars[dataPos[i]];
                ++dataPos[i];

                // Check for duplicates in the input
                while (dataPos[i] + 1 < exclusiveChars.Length && exclusiveChars[dataPos[i]] == exclusiveChars[dataPos[i] + 1])
                    ++dataPos[i];

                // check if out of bounds
                if (dataPos[i] > exclusiveChars.Length - 1)
                {
                    dataPos[i] = 0;
                }

                // Check if overflow
                if (dataPos[i] == 1)
                {
                    i--;
                }
                else
                {
                    // go back to right most position
                    i = lengthFrom - 1;
                }

                i++;
            }

            // Increment current length
            //lengthFrom++;
            //}
        }
    }
}
