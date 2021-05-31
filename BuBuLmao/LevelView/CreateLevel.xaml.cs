using System;
using System.Collections.Generic;
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
using MessageBox = System.Windows.MessageBox;
using Rectangle = System.Drawing.Rectangle;

namespace BuBuLmao.LevelView
{
    /// <summary>
    /// Interaction logic for CreateLevel.xaml
    /// </summary>
    public partial class CreateLevel : Window
    {
        //bonk
        public static MediaPlayer bonk = new MediaPlayer();

        //Tao ten lv va ten folder
        public static String level;

        private Uri newuri;
        public CreateLevel()
        {
            InitializeComponent();
            level = lvlname.Text;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            //Open file (dinh dang anh)
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            op.ShowDialog();
            newimg.Source = new BitmapImage(new Uri(op.FileName));
            newuri = new Uri(op.FileName);
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
                string a = ((BitmapImage)newimg.Source).UriSource.AbsolutePath;
                //System.Windows.MessageBox.Show(a);
                MessageBox.Show("Successful!!!");
                CutImage(a);
            }
        }

        private void CutImage(string filepath)
        {
            //Create folder name
            //Random rnd = new Random();
            //int id = rnd.Next(1, 200);
            string leveltitle = lvlname.Text;

            String NewFolderPath = "D:\\BuhBuhLmao\\BuBuLmao\\Puzzle\\" + leveltitle;
            if (Directory.Exists(NewFolderPath) == false)
            {
                Directory.CreateDirectory(NewFolderPath);
            }
            //


            // make user image square
            string a = ((BitmapImage)newimg.Source).UriSource.AbsolutePath;
            // Create a Bitmap object from a file.
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.BeginInit();
            myBitmap.UriSource = newuri;
            myBitmap.DecodePixelWidth = 300;
            myBitmap.DecodePixelHeight = 300;
            myBitmap.EndInit();

            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(myBitmap));

            using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\Goal.png", System.IO.FileMode.Create))
            {
                encoder.Save(fileStream);
            }

            /*BitmapImage src = new BitmapImage();
            BitmapImage part = new BitmapImage();
            src.BeginInit();
            src.UriSource = myBitmap.UriSource;
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    CroppedBitmap cp1 = new CroppedBitmap(src, new Int32Rect(j * 120, i * 120, 120, 120));
                    BitmapEncoder newCroped = new PngBitmapEncoder();
                    newCroped.Frames.Add(BitmapFrame.Create(cp1));
                    using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\part" + i + ".png", System.IO.FileMode.Create))
                    {
                        newCroped.Save(fileStream);
                    }
                }
            } */




            /*
            BitmapImage src = new BitmapImage();
            BitmapImage part = new BitmapImage();
            src.BeginInit();
            src.UriSource = myBitmap.UriSource;
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit(); */

            // piece 1-2-3
            for (int i = 0; i < 3; i++) //x
            {
                    int j = 0; //y
                    CroppedBitmap cp1 = new CroppedBitmap(myBitmap, new Int32Rect(i * 100, j * 100, 100, 100));
                    BitmapEncoder newCroped = new PngBitmapEncoder();
                    newCroped.Frames.Add(BitmapFrame.Create(cp1));
                    //index for one piece
                    int indx = i + 1;
                    using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\" + indx + ".png", System.IO.FileMode.Create))
                    {
                        newCroped.Save(fileStream);
                    }
            }

            // piece 4-5-6
            for (int i = 0; i < 3; i++) //x
            {
                    int j = 1; //y

                    CroppedBitmap cp1 = new CroppedBitmap(myBitmap, new Int32Rect(i * 100, j * 100, 100, 100));
                    BitmapEncoder newCroped = new PngBitmapEncoder();
                    newCroped.Frames.Add(BitmapFrame.Create(cp1));
                    //index for one piece
                    int indx = i + 4;
                    using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\" + indx + ".png", System.IO.FileMode.Create))
                    {
                        newCroped.Save(fileStream);
                    }
            }

            // piece 7-8-9
            for (int i = 0; i < 3; i++) //x
            {
                    int j = 2; //y

                    CroppedBitmap cp1 = new CroppedBitmap(myBitmap, new Int32Rect(i * 100, j * 100, 100, 100));
                    BitmapEncoder newCroped = new PngBitmapEncoder();
                    newCroped.Frames.Add(BitmapFrame.Create(cp1));
                    //index for one piece
                    int indx = i + 7;
                    using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\" + indx + ".png", System.IO.FileMode.Create))
                    {
                        newCroped.Save(fileStream);
                    }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();

            CustomPlaying customLevel = new CustomPlaying();
            customLevel.Show();
        }
    }
}
