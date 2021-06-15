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

        //bonk effect
        public static MediaPlayer bonk = new MediaPlayer();

        //Score
        public static int score;
        public CongratulationsWindow()
        {
            string filepath = "";
            InitializeComponent();

            GoalIMG.Source = new BitmapImage(new Uri("..\\Puzzle\\" + filepath + "\\Goal.png", UriKind.Relative));

            //Nhac background
            MainWindow.backgroundMusic.Pause();
            Woweffect.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\Wow.mp3", UriKind.Relative));
            Woweffect.Volume = 1;
            Woweffect.Play();


            //Hien anh thanh qua (Goal.png)
            //Level co san
            if (DifficultiesWindow.id == 1) //Easy
            {
                score = PlayingWindow.score;
                ScoreBoard.Text = PlayingWindow.score.ToString() + " pts!!!";
                filepath = "Style";

                GoalIMG.Source = new BitmapImage(new Uri("..\\Puzzle\\" + filepath + "\\Goal.png", UriKind.Relative));
            }

            if (DifficultiesWindow.id == 2) //Advance
            {
                score = AdvancePlaying.score;
                filepath = "KristenStewart";
                ScoreBoard.Text = AdvancePlaying.score.ToString() + " Pts";

                GoalIMG.Source = new BitmapImage(new Uri("..\\Puzzle\\" + filepath + "\\Goal.png", UriKind.Relative));
            }

            if (DifficultiesWindow.id == 3) //Expert
            {
                score = ExpertPlaying.score;
                filepath = "WildestDream";
                ScoreBoard.Text = ExpertPlaying.score.ToString() + " Pts";

                GoalIMG.Source = new BitmapImage(new Uri("..\\Puzzle\\" + filepath + "\\Goal.png", UriKind.Relative));
            }


            //Custom level
            else if (DifficultiesWindow.id != 1 && DifficultiesWindow.id != 2 && DifficultiesWindow.id != 3)
            {
                if (CustomPuzzle.id == 1) //Custom (Create level)
                {
                    filepath = CreateLevel.level;
                    GoalIMG.Source = new BitmapImage(CreateLevel.ImgUri);
                }
            }
        }


        //Close window and play music
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            MainWindow.backgroundMusic.Play();
            this.Close();
        }

        //Save window
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();


            SaveScore SavingData = new SaveScore();
            SavingData.Show();
        }
    }

}
