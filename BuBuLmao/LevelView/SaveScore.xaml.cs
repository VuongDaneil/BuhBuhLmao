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
using System.Data.SQLite;

namespace BuBuLmao.LevelView
{
    /// <summary>
    /// Interaction logic for SaveScore.xaml
    /// </summary>
    public partial class SaveScore : Window
    {
        //bonk effect
        public static MediaPlayer bonk = new MediaPlayer();

        public const string dbconn = "Data source = D:\\BuhBuhLmao\\BuBuLmao\\Resources\\Database\\Playerdata.db";

        public SaveScore()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bonk.Open(new Uri(@"D:\BuhBuhLmao\BuBuLmao\Asset\Audio\bonk.mp3", UriKind.Relative));
            bonk.Volume = 1;
            bonk.Play();


            //Thiet lap ket noi database dung sqlite
            SQLiteConnection conn = new SQLiteConnection(dbconn);
            conn.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter();
            SQLiteCommand cmd = new SQLiteCommand();

            //Query
            String query = "INSERT INTO ScoreRecord VALUES ('" + Playername.Text + "', '" + CongratulationsWindow.score + "')";
            cmd.CommandText = query;
            ad.SelectCommand = cmd;
            cmd.Connection = conn;
            SQLiteDataReader reader = cmd.ExecuteReader();


            MessageBox.Show("Done!");
            this.Close();
        }
    }
}
