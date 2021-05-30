using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;
using BuBuLmao.ViewModel;

namespace BuBuLmao.LevelView
{
    /// <summary>
    /// Interaction logic for CongratulationsWindow.xaml
    /// </summary>
    public partial class CongratulationsWindow : Window
    {
        //Sound effect
        public static MediaPlayer Woweffect = new MediaPlayer();

        //Score
        public static int score;
        public CongratulationsWindow()
        {
            string filepath = "";
            InitializeComponent();

            //Nhac background
            MainWindow.backgroundMusic.Pause();
            Woweffect.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\Wow.mp3", UriKind.Relative));
            Woweffect.Volume = 1;
            Woweffect.Play();


            //Hien anh thanh qua
            if (DifficultiesWindow.id == 1)
            {
                score = PlayingWindow.score;
                ScoreBoard.Text = PlayingWindow.score.ToString() + " Pts";
                filepath = "Style";
            }

            if (DifficultiesWindow.id == 2)
            {
                score = AdvancePlaying.score;
                filepath = "KristenStewart";
                ScoreBoard.Text = AdvancePlaying.score.ToString() + " Pts";
            }

            if (DifficultiesWindow.id == 3)
            {
                score = ExpertPlaying.score;
                filepath = "WildestDream";
                ScoreBoard.Text = ExpertPlaying.score.ToString() + " Pts";
            }

            GoalIMG.Source = new BitmapImage(new Uri("..\\Puzzle\\" + filepath + "\\Goal.png", UriKind.Relative));



        }


        //Close window and play music
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.backgroundMusic.Play();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SaveScore SavingData = new SaveScore();
            SavingData.Show();
        }
    }

}
