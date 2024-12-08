using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kent.SelfStudies.School.JavaPort.NumToWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] labels = { " hundred ", " thousand ", " million ", " billion " };
            string[] ones = { "ten", "eleven", "twelve", "thir", "fif", "eigh", "teen", "twen", "ty" };

            string input = textBox1.Text;
            String output = "";
            int length = input.Length;

            bool check = false;

            for (int i = 0, j = length - ((length / 3) * 3), zero = 0; i < length; )
            {
                if (check)
                {
                    if (length == 4 || length == 5 || length == 6)
                    {
                        if (zero < 3)
                            output += labels[1];
                    }
                    else if (length == 7 || length == 8 || length == 9)
                    {
                        if (zero < 3)
                        {
                            if (i == 1 || i == 2 || i == 3)
                                output += labels[2];
                            else if (i == 4 || i == 5 || i == 6)
                                output += labels[1];
                        }
                    }
                    else if (length == 10)
                    {
                        if (zero < 3)
                        {
                            if (i == 1)
                                output += labels[3];
                            else if (i == 4)
                                output += labels[2];
                            else if (i == 7)
                                output += labels[1];
                        }
                    }
                    zero = 0;
                    check = false;
                }
                else
                {
                    switch (j)
                    {
                        case 0:
                            switch (input[i])
                            {
                                case '0':
                                    zero++;
                                    break;
                                default:
                                    output += numbers[Convert.ToInt32(input[i].ToString())] + labels[0];
                                    break;
                            }
                            j = 3;
                            break;
                        case 1:
                            switch (input[i])
                            {
                                case '0':
                                    if (length == 1)
                                        output += numbers[0];
                                    zero++;
                                    break;
                                default:
                                    output += numbers[Convert.ToInt32(input[i].ToString())];
                                    break;
                            }
                            break;
                        case 2:
                            switch (input[i])
                            {
                                case '0':
                                    zero++;
                                    break;
                                case '1':
                                    switch (input[i + 1])
                                    {
                                        case '0':
                                            zero++;
                                            goto case '1';
                                        case '1':
                                        case '2':
                                            output += ones[Convert.ToInt32(input[i + 1].ToString())];
                                            break;
                                        case '3':
                                            output += ones[3] + ones[6];
                                            break;
                                        case '5':
                                            output += ones[4] + ones[6];
                                            break;
                                        case '8':
                                            output += ones[5] + ones[6];
                                            break;
                                        default:
                                            output += numbers[Convert.ToInt32(input[i + 1].ToString())] + ones[6];
                                            break;
                                    }
                                    i++;
                                    break;
                                case '2':
                                    output += ones[7] + ones[8];
                                    break;
                                case '3':
                                    output += ones[3] + ones[8];
                                    break;
                                case '5':
                                    output += ones[4] + ones[8];
                                    break;
                                case '8':
                                    output += ones[5] + ones[8];
                                    break;
                                default:
                                    output += numbers[Convert.ToInt32(input[i].ToString())] + ones[8];
                                    break;
                            }
                            break;
                    }
                    i++;
                    j--;
                    if (j == 0)
                        check = true;
                }
            }
            textBox2.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
