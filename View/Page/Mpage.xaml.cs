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
using Task4._1.View.Page.Menu;
using static Task4._1.Core.Core;

namespace Task4._1.View.Page
{
    /// <summary>
    /// Логика взаимодействия для Mpage.xaml
    /// </summary>
    public partial class Mpage 
    {
        public Mpage()
        {
            InitializeComponent();
        }

        private void G1_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MC.Navigate(new MenuList());


        }

       

        private void G3_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
