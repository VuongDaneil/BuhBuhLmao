using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BuBuLmao.LevelView
{
    /// <summary>
    /// Interaction logic for DifficultiesWindow.xaml
    /// </summary>
    public partial class DifficultiesWindow : Window
    {
        //bonk
        public static MediaPlayer bonk = new MediaPlayer();

        public static int id = 0;
        public DifficultiesWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            id = 1;
            PlayingWindow new1 = new PlayingWindow();
            new1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            id = 2;
            AdvancePlaying new1 = new AdvancePlaying();
            new1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            id = 3;
            ExpertPlaying new1 = new ExpertPlaying();
            new1.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            CreateLevel CreateNew = new CreateLevel();
            CreateNew.Show();
        }
    }
}
