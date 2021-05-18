using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BuBuLmao.ViewModel
{
    class PicturePiece
    {
        //index (stt)
        public int index = -1;

        public ImageSource PuzzleImageSource { get; set; }
        //duong dan den hinh anh
        public string UriString { get; set; }
        //keo
        public Type DragFrom { get; set; }
    }
}
