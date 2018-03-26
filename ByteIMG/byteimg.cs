using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;

namespace ByteIMG
{
    public partial class byteimg : Form
    {
        /*
         
            ERROR CODES:

            # : TITLE OF ERROR : DESCRIPTION

            1 : Illegal file address : Missing file

            2 : Blank file : Blank file

            3 : Corrupted file : Miswritten bytes in file contents, usually one line being longer or shorter than the rest

             */

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
                    MessageBox.Show("Illegal file address", "ERROR (Code 1)", MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }
            }
            image.BackgroundImageLayout = ImageLayout.None;
            Bitmap img = new Bitmap(image.Width, image.Height);
            image.BackgroundImage = img;
            char white = '0';
            char black = '1';
            char lf = '\n';
            char cr = '\r';
            char nl = '\u0025';
            char[] imgarray=file.ToCharArray();
            int x = 1;
            int y = 0;
            int maxlength1 = file.IndexOf(lf);
            int maxlength2 = file.IndexOf(cr);
            int maxlines1 = 0;
            int maxlines2 = 0;
            for (int i = 0; i < imgarray.Length;)
            {
                if (imgarray[i] == lf)
                {
                    y += 1;
                    maxlines1++;
                    x=0;
                }
                if (imgarray[i] == cr && imgarray[1 + 1] == lf)
                {
                    y += 1;
                    maxlines2++;
                    x=0;
                }
                /*if (imgarray[i] == white)
                {
                    img.SetPixel(file.IndexOf(white) + x-1, y, Color.White);
                }*/
                if (imgarray[i] == black)
                {
                    img.SetPixel(file.IndexOf(black) + x, y, Color.Black);
                }
                i++;
                x++;
            }
            ClientSize = new Size(maxlength1, maxlines1);
        }

        private void opendialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            file = File.ReadAllText(opendialog.FileName);
        }
    }
}
