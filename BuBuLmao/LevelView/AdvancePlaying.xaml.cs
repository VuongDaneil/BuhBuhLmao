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
    /// Interaction logic for AdvancePlaying.xaml
    /// </summary>
    public partial class AdvancePlaying : Window
    {
        //Score
        public static int score = 75000;

        Puzzle puzzle = new Puzzle();
        ObservableCollection<PicturePiece> itemPlacement = new ObservableCollection<PicturePiece>();
        PicturePiece emptyItem = new PicturePiece();

        ListBox lbxDragSource;
        Canvas cvDragSource;
        //ObservableCollection<> stulist = new ObservableCollection<string>();


        //Initialized khoi tao anh va vi tri
        public AdvancePlaying()
        {
            InitializeComponent();

            //chosen level
            puzzle.Initialize(2);

            emptyItem.index = -1;
            emptyItem.PuzzleImageSource = new BitmapImage();
            emptyItem.UriString = "";

            for (int i = 0; i < 16; i++)
            {
                //vi tri dich cua manh ghep
                itemPlacement.Add(emptyItem);
                itemPlacement[i].index = i;
            }
            //cho vao listbox xaml

            itemsList.ItemsSource = puzzle.PicPiece;

            puzzle.Edited += new EventHandler(puzzle_Edited);
        }


        #region thao tac chon & keo 
        //Keo tu listbox vao khung canvas
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //
        private void itemList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = sender as ListBox;
            lbxDragSource = parent;

            object data = GetObjectDataFromPoint(lbxDragSource, e.GetPosition(parent));

            if (data != null)
            {
                PicturePiece itemSelected = data as PicturePiece;
                itemSelected.DragFrom = typeof(ListBox);
                DragDrop.DoDragDrop(lbxDragSource, data, DragDropEffects.Move);
            }
        }

        //keo 1 manh hinh anh trong canvas
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PzItmCvs_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Canvas parent = sender as Canvas;
            cvDragSource = parent;
            object data = GetDataFromCanvas(cvDragSource);

            if (data != null)
            {
                PicturePiece itemSelected = data as PicturePiece;
                itemSelected.DragFrom = typeof(Canvas);
                DragDrop.DoDragDrop(cvDragSource, data, DragDropEffects.Move);
            }
        }
        #endregion


        #region thao tac tha bang chuot
        private void PuzzleItemDrop(object sender, DragEventArgs e)
        {
            //get item
            Canvas destination = sender as Canvas;
            PicturePiece itemTransferred = null;
            object data = e.Data.GetData(typeof(PicturePiece)) as PicturePiece;

            itemTransferred = data as PicturePiece;
            //xu ly anh cho vua cai khung canvas
            Image imageControl = new Image()
            {
                Width = destination.Width,
                Height = destination.Height,
                Source = itemTransferred.PuzzleImageSource,
                Stretch = Stretch.UniformToFill
            };

            //if empty canvas
            if (destination.Children.Count == 0)
            {
                //put item in canvas
                destination.Children.Add(imageControl);

                //Update PuzzleItemPlacement
                int indexToUpdate = int.Parse(destination.Tag.ToString());

                if (itemTransferred.DragFrom == typeof(ListBox))
                {
                    //updat
                    this.itemPlacement[indexToUpdate] = itemTransferred;

                    //delete item from listbox
                    ((IList)lbxDragSource.ItemsSource).Remove(itemTransferred);

                }
                else if (itemTransferred.DragFrom == typeof(Canvas))
                {
                    //keo item tuw canvas khac(dk)
                    //udate vi tri manh duoc keo
                    int previousIndex = itemPlacement.IndexOf(itemTransferred);

                    itemPlacement[indexToUpdate] = itemTransferred;


                    itemPlacement[previousIndex] = emptyItem;

                    //delete picture from listbox
                    Canvas associated = GetAssociatedCanvasByIndex(previousIndex);
                    associated.Children.Clear();
                    associated = null;

                }
                else
                {
                    MessageBox.Show("error");
                }
            }


            //if canvas isnt empty
            else if (destination.Children.Count > 0)
            {

                //canvas isnt empty and drag from listbox - stop draging do nothing
                if (itemTransferred.DragFrom == typeof(ListBox))
                {
                    return;
                }

                //canvas isnt empty and drag from another canvas -> switch them
                else if (itemTransferred.DragFrom == typeof(Canvas))
                {
                    //get the draging item and destination index 
                    //index anh goc
                    int sourceIndex = itemPlacement.IndexOf(itemTransferred);
                    //index manh dich
                    int destinationIndex = int.Parse(destination.Tag.ToString());

                    object buffer = null;

                    //doi index
                    Image image0 = new Image() { Width = destination.Width, Height = destination.Height, Stretch = Stretch.Fill };
                    image0.Source = itemPlacement[sourceIndex].PuzzleImageSource;

                    Image image1 = new Image() { Width = destination.Width, Height = destination.Height, Stretch = Stretch.Fill };
                    image1.Source = itemPlacement[destinationIndex].PuzzleImageSource;
                    //trao doi vi tri 2 picture
                    GetAssociatedCanvasByIndex(sourceIndex).Children.Clear();
                    GetAssociatedCanvasByIndex(destinationIndex).Children.Clear();

                    GetAssociatedCanvasByIndex(sourceIndex).Children.Add(image1);
                    GetAssociatedCanvasByIndex(destinationIndex).Children.Add(image0);

                    image0 = null;
                    image1 = null;

                    //switch placement
                    buffer = itemPlacement[sourceIndex];
                    itemPlacement[sourceIndex] = itemPlacement[destinationIndex];
                    itemPlacement[destinationIndex] = buffer as PicturePiece;

                    buffer = null;

                }
            }

            //update diem
            score -= 500;
            if (score < 0) score = 0;

            //check xem co hop le khong
            puzzle.OnEdit(EventArgs.Empty);

            itemTransferred.DragFrom = null;
        }
        #endregion

        #region Check if wins
        //Kiem tra 
        void puzzle_Edited(object sender, EventArgs e)
        {
            bool validate = puzzle.Validate(itemPlacement);

            if (validate)
            {
                CongratulationsWindow WIN = new CongratulationsWindow();
                WIN.Show();
            }
        }
        #endregion


        #region associated item with index (i-> manh picture[i])
        private Canvas GetAssociatedCanvasByIndex(int index)
        {
            int i = index;
            if (i == 0)
                return puzzlePart1;
            else if (i == 1)
                return puzzlePart2;
            else if (i == 2)
                return puzzlePart3;
            else if (i == 3)
                return puzzlePart4;
            else if (i == 4)
                return puzzlePart5;
            else if (i == 5)
                return puzzlePart6;
            else if (i == 6)
                return puzzlePart7;
            else if (i == 7)
                return puzzlePart8;
            else if (i == 8)
                return puzzlePart9;
            else if (i == 9)
                return puzzlePart10;
            else if (i == 10)
                return puzzlePart11;
            else if (i == 11)
                return puzzlePart12;
            else if (i == 12)
                return puzzlePart13;
            else if (i == 13)
                return puzzlePart14;
            else if (i == 14)
                return puzzlePart15;
            else if (i == 15)
                return puzzlePart16;

            return null;
        }
        #endregion

        //---------
        #region get data from draging item
        private object GetDataFromCanvas(Canvas cvDragSource)
        {
            //lay index tu manh dang chon
            int canvasIndex = int.Parse(cvDragSource.Tag.ToString());

            //lay ra manh hinh anh
            PicturePiece item = itemPlacement[canvasIndex];
            return item;
        }

        /// <param name="dragSource"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        private object GetObjectDataFromPoint(ListBox dragSource, Point point)
        {
            UIElement element = dragSource.InputHitTest(point) as UIElement;

            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = dragSource.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == dragSource)
                    {
                        return null;
                    }
                }
                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }
            return null;
        }
        #endregion
    }
}
