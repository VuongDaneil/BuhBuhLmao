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
        public CongratulationsWindow()
        {
            string filepath = "";
            InitializeComponent();
            if (DifficultiesWindow.id == 1)
            {
                filepath = "Style";
            }

            if (DifficultiesWindow.id == 2)
            {
                filepath = "KristenStewart";
            }

            if (DifficultiesWindow.id == 3)
            {
                filepath = "WildestDream";
            }

            GoalIMG.Source = new BitmapImage(new Uri("..\\Puzzle\\" + filepath + "\\Goal.png", UriKind.Relative));
        }
    }
}
