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

namespace ATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Customers
        {
            
        }
        
        public void withdraw()
        {
            
        }
        public void deposit()
        {

        }
        public void currantvalue()
        {
          
        }
        //deposit
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            deposit();
        }
        //withdraw
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            withdraw();
        }
        //currentvalue
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currantvalue();
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textzone_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

    }
}
