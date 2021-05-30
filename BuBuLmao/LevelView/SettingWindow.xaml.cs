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
    /// Interaction logic for SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
        }


        //Resume music
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.backgroundMusic.Play();
        }

        //Pause music
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow.backgroundMusic.Pause();
        }

        //My group
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" <- Bủ Bủ Lmao!! The puzzle game -> \r\n Đỗ Minh Vượng \r\n Nguyễn Trung Kiên \r\n Nguyễn Thị Thanh");
        }
    }
}
