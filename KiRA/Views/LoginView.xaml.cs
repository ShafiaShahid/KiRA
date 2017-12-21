using KiRA.Data;
using KiRA.Models;
using MySql.Data.MySqlClient;
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


namespace KiRA.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                MySqlConnection conn = null;
                MySqlDataReader rdr = null;


                conn = new MySqlConnection("Server=kira-web.mysql.database.azure.com; Port=3306; Database=kira-db; Uid=incentrio@kira-web; Pwd=Incentri0; SslMode=Preferred;");
                conn.Open();

                string stm = "SELECT * FROM kira_user WHERE username = '" + this.txt_user_name.Text + "' and pass ='" + this.txt_password.Text + "'";

                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();



                int count = 0;
                while (rdr.Read())
                {

                    count++;

                }
                if (count == 1)
                {

                    // MessageBox.Show("Username and password is correct");
                    ExerciseMenuView EMV = new ExerciseMenuView();
                    this.Close();
                    EMV.ShowDialog();

                }
                if (count > 1)
                {
                    MessageBox.Show(" Duplicate Username and password, please try again!");

                }
                if (count < 1)
                {
                    MessageBox.Show(" Username and password is incorrect");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
