using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    class Puzzle
    {
        public ObservableCollection<PicturePiece> PicPiece = new ObservableCollection<PicturePiece>();
        public string name;
        public event EventHandler Edited;
        public Puzzle()
        {

        }

        public void OnEdit(EventArgs e)
        {
            if (Edited != null) Edited(this, e);
        }

        public void Initialize(int choice)
        {
            string directorySource = "";

            if(choice == 1)
            {
                this.name = "RabbitPuzzle";
                directorySource = "RabbitPuzzle";
            }

            for (int i = 0; i<9; i++)
            {
                this.PicPiece.Add(new PicturePiece());
                this.PicPiece[i].index = 1;
                this.PicPiece[i].UriString = "Puzzle/" + directorySource + "/" + (i + 1).ToString() + ".png";
                this.PicPiece[i].PuzzleImageSource = new BitmapImage(new Uri(this.PicPiece[i].UriString, UriKind.Relative));
            }

            //Tron random
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int rand = random.Next(0, 8);
                PicturePiece buffer;
                buffer = this.PicPiece[i];
                this.PicPiece[i] = this.PicPiece[rand];
                this.PicPiece[rand] = buffer;
            }
        }

        //cach tinh 
        public bool Validate(ObservableCollection<PicturePiece> itemPlacement)
        {
            ObservableCollection<PicturePiece> placement = itemPlacement;

            foreach(PicturePiece item in itemPlacement)
            {
                if ((itemPlacement.IndexOf(item) != item.index) || itemPlacement.IndexOf(item) < 0)
                    return false;
            }

            return true;
        }
    }
}
