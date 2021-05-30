using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuBuLmao.LevelView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static MediaPlayer backgroundMusic = new MediaPlayer();
        public static MediaPlayer bonk = new MediaPlayer();

        public static int id = 1;
        public MainWindow()
        {
            InitializeComponent();

            backgroundMusic.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\theme.mp3", UriKind.Relative)); 
            backgroundMusic.Volume = 1;
            backgroundMusic.Play();
            backgroundMusic.MediaEnded += new EventHandler(Media_Ended);

        }

        //loop theme
        private void Media_Ended(object sender, EventArgs e)
        {
            backgroundMusic.Position = TimeSpan.Zero;
            backgroundMusic.Play();
        }



        //play button
        private void Playbtn_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            DifficultiesWindow Difficult = new DifficultiesWindow();
            
            Difficult.Show();
            
        }


        //Setting button-
        private void Settingbtn_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            SettingWindow Setting = new SettingWindow();

            Setting.Show();
        }

        //Highscore button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            RankWindow Highscore = new RankWindow();

            Highscore.Show();
        }


        //Quit button
        private void Quitbtn_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            this.Close();
        }

    }
}
