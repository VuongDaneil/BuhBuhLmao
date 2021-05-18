using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuBuLmao.ViewModel
{
    
    class PlayingModel
    {
        private Bitmap ImageFile;

        //Template for the picture
        private const int CELL_size = 60;
        private const int PIECES_count = 4;
        private PictureBox[] picCELL = new PictureBox[PIECES_count * PIECES_count];

        //Position
        private const int OffsetX = 300;
        private const int OffsetY = 10;

        //Mouse position
        private Point startDragPoint;

        //Picture position
        private Point PicPosition;


    }

    
}
