using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace Disco_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            BackColor = Color.White;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            int color_case = number.Next(0, 11);

            switch (color_case)
            {
                case 0:
                    BackColor = Color.Red;
                    break;
                case 1:
                    BackColor = Color.Green;
                    break;
                case 2:
                    BackColor = Color.Blue;
                    break;
                case 3:
                    BackColor = Color.Magenta;
                    break;
                case 4:
                    BackColor = Color.Yellow;
                    break;
                case 5:
                    BackColor = Color.Orange;
                    break;
                case 6:
                    BackColor = Color.Orchid;
                    break;
                case 7:
                    BackColor = Color.Brown;
                    break;
                case 8:
                    BackColor = Color.Black;
                    break;
                case 9:
                    BackColor = Color.Bisque;
                    break;
                case 10:
                    BackColor = Color.DarkTurquoise;
                    break;
                case 11:
                    BackColor = Color.DarkViolet;

                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\EM\source\repos\Disco button\Disco button\beat.wav");
            player.Play();

        }
    }
}