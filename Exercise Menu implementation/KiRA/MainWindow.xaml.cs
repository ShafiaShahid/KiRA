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

        }

     

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            LoginView window1 = new LoginView();
            this.Close();
            window1.ShowDialog();
        }

        
        
}    }

        

        


       
          
    