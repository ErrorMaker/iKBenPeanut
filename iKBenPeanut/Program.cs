using System;
using Sulakore;
using System.Windows.Forms;

namespace iKBenPeanut
{
    static class Program
    {
        public static HSession Account { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            Application.Run(new Main());
        }
    }
}