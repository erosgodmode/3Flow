using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TrioFlow
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
