﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuBuLmao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int id = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Playbtn_Click(object sender, RoutedEventArgs e)
        {

            PlayingWindow new1 = new PlayingWindow();
            new1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateLevel Createlv = new CreateLevel();
            Createlv.Show();
        }
    }
}
