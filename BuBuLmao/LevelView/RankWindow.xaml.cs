using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

namespace BuBuLmao.LevelView
{
    /// <summary>
    /// Interaction logic for RankWindow.xaml
    /// </summary>
    public partial class RankWindow : Window
    {
        public const string dbconn = "Data source = D:\\BuhBuhLmao\\BuBuLmao\\Resources\\Database\\Playerdata.db";
        public RankWindow()
        {
            InitializeComponent();

            //Thiet lap ket noi database dung sqlite
            SQLiteConnection conn = new SQLiteConnection(dbconn);
            conn.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter();
            SQLiteCommand cmd = new SQLiteCommand();

            //Query
            String query = "SELECT * FROM ScoreRecord ORDER BY Points DESC";
            cmd.CommandText = query;
            ad.SelectCommand = cmd;
            cmd.Connection = conn;
            SQLiteDataReader reader = cmd.ExecuteReader();

            //Add data
            string record = "";
            while (reader.Read())
            {
                record += String.Format("{0} {1} \n", reader[0], reader[1]);
                string name = reader.GetString(0);
                int points = reader.GetInt32(1);
                PlayernameLV.Items.Add(name);
                PlayerscoreLV.Items.Add(points);
            }
        }
    }
}
