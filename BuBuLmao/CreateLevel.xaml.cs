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
using Rectangle = System.Drawing.Rectangle;

namespace BuBuLmao
{
    /// <summary>
    /// Interaction logic for CreateLevel.xaml
    /// </summary>
    public partial class CreateLevel : Window
    {
        private Uri newuri;
        public CreateLevel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            op.ShowDialog();
            newimg.Source = new BitmapImage(new Uri(op.FileName));
            newuri = new Uri(op.FileName);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = ((BitmapImage)newimg.Source).UriSource.AbsolutePath;
            System.Windows.MessageBox.Show(a);
            CutImage(a);
        }

        private void CutImage(string filepath)
        {
            //Create folder name
            Random rnd = new Random();
            int id = rnd.Next(1, 200);


            String NewFolderPath = "D:\\BuhBuhLmao\\BuBuLmao\\Puzzle\\PuzzleNumber" + id;
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
            myBitmap.DecodePixelWidth = 360;
            myBitmap.DecodePixelHeight = 360;
            myBitmap.EndInit();

            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(myBitmap));

            using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\newGoal.png", System.IO.FileMode.Create))
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

            
            BitmapImage src = new BitmapImage();
            BitmapImage part = new BitmapImage();
            /*src.BeginInit();
            src.UriSource = myBitmap.UriSource;
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit(); */

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    CroppedBitmap cp1 = new CroppedBitmap(myBitmap, new Int32Rect(j * 120, i * 120, 120, 120));
                    BitmapEncoder newCroped = new PngBitmapEncoder();
                    newCroped.Frames.Add(BitmapFrame.Create(cp1));
                    using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\part" + i + ".png", System.IO.FileMode.Create))
                    {
                        newCroped.Save(fileStream);
                    }
                }
            }
        }

    }
}
