using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Task4._1.Core.Core;

namespace Task4._1.View.Page.Menu
{
    /// <summary>
    /// Логика взаимодействия для MenuList.xaml
    /// </summary>
    public partial class MenuList
    {
        public MenuList()
        {
            InitializeComponent();
        }

        private void E1_Click(object sender, RoutedEventArgs e)
        {
            int A = 0;
            int B = 0;
            int r = 0;
            int summ=0;
            Random i= new Random();
            int[]mass= new int[66];
            for (int j = 0; j < 66; j++)
            {
                mass[j] = i.Next(-100,100);


                A = mass[j];
                B = mass[j];
                if (A<B)

                while (A < B)
                {
                   
                    r = mass[j];
                    r++;

                }
                while(summ<r)
                    summ = r;
                    summ++;

                
            
            }
                
            MessageBox.Show($"{summ}","Задание 1",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void E2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E14_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MC.Navigate(new Mpage());

        }
    }
}
