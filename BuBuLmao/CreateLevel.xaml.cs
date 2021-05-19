using System;
using System.Collections.Generic;
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

namespace BuBuLmao
{
    /// <summary>
    /// Interaction logic for CreateLevel.xaml
    /// </summary>
    public partial class CreateLevel : Window
    {
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
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Rectangle r = new Rectangle(i * (newimg.Image.Width / 4),
                                                y * (pictureBox1.Image.Height / 4),
                                                pictureBox1.Image.Width / 4,
                                                pictureBox1.Image.Height / 4);

                    g.DrawRectangle(pen, r);

                    list.Add(cropImage(pictureBox1.Image, r));
                }
            }
        }

        private void CutImage(string img)
        {
            int count = 0;
            
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri(img, UriKind.Relative);
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    objImg[count++] = new CroppedBitmap(src, new Int32Rect(j * 120, i * 120, 120, 120));
        }
    }
}
