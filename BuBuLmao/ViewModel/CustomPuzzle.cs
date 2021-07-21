using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    class CustomPuzzle
    {
        public ObservableCollection<PicturePiece> PicPieces = new ObservableCollection<PicturePiece>();

        public EventHandler Edited;

        //id che do choi
        public static int id ;

        public CustomPuzzle()
        {

        }

        public void OnEdit(EventArgs e)
        {
            if (Edited != null)
                Edited(this, e);
        }

        public void Initialize(int chosen, string lvlname, BitmapImage newimgForLevel)
        {
            int numberOfpiece = 9;

            #region Cut image method and put it in itemplacement
            if (chosen == 1)
            {
                id = 1;


                //Cac buoc xu ly: beginer mode (Cat anh lam 9 phan + luu lai anh goc)
                //Take one image from Iamge control (xaml) then split it into 9 part (PicturePiece) (trong random)
                //Create folder to contain the level, store pictures in that folder

                //-------------------------

                //Create folder name
                //Random rnd = new Random();
                //int id = rnd.Next(1, 200);
                string leveltitle = lvlname;

                String NewFolderPath = "D:\\BuhBuhLmao\\BuBuLmao\\Puzzle\\" + leveltitle;
                if (Directory.Exists(NewFolderPath) == false)
                {
                    Directory.CreateDirectory(NewFolderPath);
                }
                //


                // Create a Bitmap object from newImgImage to make it square and 300*300
                BitmapImage myBitmap = new BitmapImage();

                myBitmap.BeginInit();
                myBitmap.UriSource = newimgForLevel.UriSource;
                myBitmap.DecodePixelWidth = 300;
                myBitmap.DecodePixelHeight = 300;
                myBitmap.EndInit();

                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(myBitmap));

                using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\Goal.png", System.IO.FileMode.Create))
                {
                    encoder.Save(fileStream);
                }

                //Get the picture
                //Split into 9 pieces -> put in itemplacement;

                int indx = 1;

                int indxInCollection = 0;

                for (int i = 0; i < 3; i++) //x
                {
                    for (int j = 0; j < 3; j++) //y
                    {
                        CroppedBitmap cp1 = new CroppedBitmap(myBitmap, new Int32Rect(j * 100, i * 100, 100, 100));
                        BitmapEncoder newCroped = new PngBitmapEncoder();
                        newCroped.Frames.Add(BitmapFrame.Create(cp1));

                        //index for one piece
                        using (var fileStream = new System.IO.FileStream(NewFolderPath + "\\" + indx + ".png", System.IO.FileMode.Create))
                        {
                            newCroped.Save(fileStream);
                        }
                        //Put in collection <>PicturePiece
                        this.PicPieces.Add(new PicturePiece());

                        this.PicPieces[indxInCollection].index = indxInCollection;

                        //this.PicPieces[i].UriString = "Puzzle/" + leveltitle + "/" + (i + 1).ToString() + ".png";

                        this.PicPieces[indxInCollection].PuzzleImageSource = cp1;

                        indxInCollection++;
                        indx++;
                    }
                }
            }
            #endregion

            #region play old level (co san trong folder Puzzle)
            else if (chosen == 2)
            {
                id = 2;
                numberOfpiece = 9;

                String directorySource = CreateLevel.level;


                for (int i = 0; i < 9; i++)
                {
                    this.PicPieces.Add(new PicturePiece());

                    this.PicPieces[i].index = i;

                    this.PicPieces[i].UriString = "../Puzzle/mm/" + i.ToString() + ".png";

                    this.PicPieces[i].PuzzleImageSource = new BitmapImage(new Uri(this.PicPieces[i].UriString, UriKind.Relative));
                }

            }
            #endregion

            #region random pieces
            //tron random cac manh
            Random rand = new Random();

            for (int i = 0; i < numberOfpiece; i++)
            {
                int random = rand.Next(0, numberOfpiece - 1);

                PicturePiece buffer;

                buffer = this.PicPieces[i];

                this.PicPieces[i] = this.PicPieces[random];

                this.PicPieces[random] = buffer;
            }
            #endregion
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