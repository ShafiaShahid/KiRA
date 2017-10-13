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
    /// Interaction logic for ExerciseMenuView.xaml
    /// </summary>
    public partial class ExerciseMenuView : Window
    {

      
        public ExerciseMenuView()
        {
            InitializeComponent();
            
        }

     

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Exercise 1");
        }

        private void Label_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Exercise 2");
        }

        private void Label_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Exercise 3");
        }

        private void Label_MouseDoubleClick_3(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Exercise 4");
        }

        private void Label_MouseDoubleClick_4(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Exercise 5");
        }
    }
}
