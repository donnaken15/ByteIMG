using System;
using System.Windows.Forms;

namespace ByteIMG
{
    static class Program
    {
        public static string[] args;

        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new byteimg());
        }
    }
}
