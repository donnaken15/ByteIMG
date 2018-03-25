using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;

namespace ByteIMG
{
    public partial class byteimg : Form
    {
        public static string file;
        
        public byteimg()
        {
            InitializeComponent();
        }

        private void byteimg_Load(object sender, EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length == 1)
            {
                if (opendialog.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (File.Exists(Environment.GetCommandLineArgs()[1]))
                {
                    file = File.ReadAllText(Environment.GetCommandLineArgs()[1]);
                }
                else
                {
                    MessageBox.Show("Illegal file address","ERROR (Code 1)",);
                }
            }
            image.BackgroundImageLayout = ImageLayout.None;
            Bitmap img = new Bitmap(100, 100);
            image.BackgroundImage = img;
            img.SetPixel(15, 15, Color.Red);
            img.SetPixel(16, 16, Color.Red);
        }

        private void opendialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            file = File.ReadAllText(opendialog.FileName);
        }
    }
}
