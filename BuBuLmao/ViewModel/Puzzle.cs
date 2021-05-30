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
using BuBuLmao.LevelView;

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
            if (Edited != null)
                Edited(this, e);
        }

        public void Initialize(int chosen)
        {
            string directorySource = "";
            int numberOfpiece = 0;

            //Beginer
            if (chosen == 1)
            {
                numberOfpiece = 9;

                this.name = "Style";

                directorySource = "Style";

                for (int i = 0; i < 9; i++)
                {
                    this.PicPiece.Add(new PicturePiece());

                    this.PicPiece[i].index = i;

                    this.PicPiece[i].UriString = "Puzzle/" + directorySource + "/" + (i + 1).ToString() + ".png";

                    this.PicPiece[i].PuzzleImageSource = new BitmapImage(new Uri(this.PicPiece[i].UriString, UriKind.Relative));
                }
            }

            //Advance
            if (chosen == 2)
            {
                numberOfpiece = 16;

                this.name = "KristenStewart";

                directorySource = "KristenStewart";

                for (int i = 0; i < 16; i++)
                {
                    this.PicPiece.Add(new PicturePiece());

                    this.PicPiece[i].index = i;

                    this.PicPiece[i].UriString = "Puzzle/" + directorySource + "/" + (i + 1).ToString() + ".png";

                    this.PicPiece[i].PuzzleImageSource = new BitmapImage(new Uri(this.PicPiece[i].UriString, UriKind.Relative));
                }
            }

            //Expert
            if (chosen == 3)
            {
                numberOfpiece = 25;

                this.name = "WildestDream";

                directorySource = "WildestDream";

                for (int i = 0; i < 25; i++)
                {
                    this.PicPiece.Add(new PicturePiece());

                    this.PicPiece[i].index = i;

                    this.PicPiece[i].UriString = "Puzzle/" + directorySource + "/" + (i + 1).ToString() + ".png";

                    this.PicPiece[i].PuzzleImageSource = new BitmapImage(new Uri(this.PicPiece[i].UriString, UriKind.Relative));
                }
            }

            //Custom
            if (chosen == 4)
            {
                numberOfpiece = 9;

                this.name = CreateLevel.level;

                directorySource = CreateLevel.level;


                for (int i = 0; i < 9; i++)
                {
                    this.PicPiece.Add(new PicturePiece());

                    this.PicPiece[i].index = i;

                    this.PicPiece[i].UriString = "Puzzle/" + directorySource + "/" + (i + 1).ToString() + ".png";

                    this.PicPiece[i].PuzzleImageSource = new BitmapImage(new Uri(this.PicPiece[i].UriString, UriKind.Relative));
                }
            }

            //tron random
            Random rand = new Random();

            for (int i = 0; i < numberOfpiece; i++)
            {
                int random = rand.Next(0, numberOfpiece - 1);

                PicturePiece buffer;

                buffer = this.PicPiece[i];

                this.PicPiece[i] = this.PicPiece[random];

                this.PicPiece[random] = buffer;
            }
        }

        //check 
        public bool Validate(ObservableCollection<PicturePiece> itemPlacement)
        {
            ObservableCollection<PicturePiece> placement = itemPlacement;

            foreach (PicturePiece item in placement)
            {
                if ((placement.IndexOf(item) != item.index) || placement.IndexOf(item) < 0)

                    return false;
            }

            return true;
        }
    }
}
