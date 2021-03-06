using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
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
using System.Windows.Shapes;
using BuBuLmao.ViewModel;
using MessageBox = System.Windows.MessageBox;
using Rectangle = System.Drawing.Rectangle;

namespace BuBuLmao.LevelView
{
    /// <summary>
    /// Interaction logic for CreateLevel.xaml
    /// </summary>
    public partial class CreateLevel : Window
    {

        //bonk effect
        public static MediaPlayer bonk = new MediaPlayer();

        //Tao ten lv va ten folder
        public static String level;

        public static BitmapImage NewGoal = new BitmapImage();

        public static Uri ImgUri;

        public CreateLevel()
        {
            InitializeComponent();
            level = lvlname.Text;
        }


        #region xu ly anh
        //Mo 1 anh, nhap ten cho man choi (level)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            op.ShowDialog();
            newimg.Source = new BitmapImage(new Uri(op.FileName));

            ImgUri = new Uri(op.FileName);
        }


        //Cut image (tao level + folder)
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            

            if (String.IsNullOrEmpty(lvlname.Text))
            {
                MessageBox.Show("Please input your level's name first!");
            }
            else
            {
                level = lvlname.Text;
                //string a = ((BitmapImage)newimg.Source).UriSource.AbsolutePath;
                
                MessageBox.Show("Successful!!!");
            }
        }

        #endregion


        //Bat dau choi (Custom game khong tinh diem, khong xep hang)
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();


            CustomPlaying customLevel = new CustomPlaying();
            customLevel.Show();
        }

        //Help button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Step 1: click LOAD button\r\n" +
                "Step 2: Choose your image\r\n" +
                "Step 3: Enter your level's name\r\n" +
                "Step 3: Click CREATE button\r\n" +
                "Step 4: Click PLAY button and enjoy!\r\n");
        }
    }
}
