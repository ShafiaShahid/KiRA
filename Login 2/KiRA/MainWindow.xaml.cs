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
using System.Windows.Navigation;
using System.Windows.Shapes;
using KiRA.Models;
using KiRA.Data;
using KiRA.Views;
using MySql;
using MySql.Data.MySqlClient;

namespace KiRA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
            try
            {
                User user = DataRead.GetUser(1);
                
            }
            catch (Exception e)
            {

                string msg = e.Message;
                return;
            }

          //  var loginView = new LoginViews();
          //  var window = new MainWindow();
           //  window.Content = loginView;

            

        }

       

        private void Button_Click(object sender, EventArgs e)
        {
           

            //   MySqlConnection conn = null;
              ///  MySqlDataReader rdr = null;

        try 
        {
          //  conn = new MySqlConnection("Server=kira-web.mysql.database.azure.com; Port=3306; Database=kira-db; Uid=incentrio@kira-web; Pwd=Incentri0; SslMode=Preferred;");
          //  conn.Open();
        
         //   string stm =  "SELECT * FROM kira_user WHERE username = '" + this.txt_user_name.Text + "' and pass ='" + this.txt_password.Text + "'";

         //   MySqlCommand cmd = new MySqlCommand(stm, conn);
//             rdr = cmd.ExecuteReader();

       //     int count = 0;
       //     while (rdr.Read()) 
        //    {

         //       count ++;

            // }            
            User user = DataRead.GetUser(this.txt_user_name.Text, this.txt_password.Text);

            

        /*    if(count == 1){
                MessageBox.Show("Username and password is correct");

            }
            if(count >1){
                MessageBox.Show(" Duplicate Username and password, please try again!");

            }
            if(count <1){
                MessageBox.Show(" Username and password is incorrect");

            } */

        } catch (Exception ex) 
        {
            MessageBox.Show(ex.Message);
        } 
    }
}
        }

        

        


       
          
    