using System;
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

namespace BuBuLmao.ViewModel
{
    class PicturePiece
    {
        //index (stt)
        public int index = -1;

        public ImageSource PuzzleImageSource { get; set; }
        //duong dan den hinh anh
        public string UriString { get; set; }

        public Type DragFrom { get; set; }
    }
}
