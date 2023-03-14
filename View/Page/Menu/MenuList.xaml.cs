using ControlzEx.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
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
            int m = 0;
            int t = 0;
            int q = 0;
            int sum = 0;
            Random a = new Random();
            int[] mass = new int[44];
            for (int z = 0; z < 44; z++)
            {
                mass[z] = a.Next(-100, 100);


                m = mass[z];
                t = mass[z];
                if (m  < t)

                    while (m < t)
                    {

                        q = mass[z];
                        q++;

                    }
                while (sum < q)
                    sum = q;
                sum++;



            }

            MessageBox.Show($"{sum}", "Задание 2", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            double An = 1.25;
            double N = 55;
            double Fact = 0.00;
            Fact = Math.Pow(An, N);
            MessageBox.Show($"{Fact}", "Задание 3", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void E4_Click(object sender, RoutedEventArgs e)
        {
            double eg = 0.00;
            Random random= new Random();
            eg= random.Next(-10,10);
            int stepen = random.Next(-10,10);
            double sw = 0.00;
            
            while (eg < 10 && stepen<10)
            {
                sw=Math.Pow(eg, stepen);
                if (sw == Math.Truncate(sw))
                {
                    sw+=1;
                }
            }
            MessageBox.Show($"{sw}", "Задание 4", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void E5_Click(object sender, RoutedEventArgs e)
        {
            double ax = 1.11;
            int fn = 15;
             double yer = 0;
            while(ax!=fn)
            {
                yer = 1 + ax * fn;
                ax++;
            }
            MessageBox.Show($"{yer}", "Задание 5", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void E6_Click(object sender, RoutedEventArgs e)
        {
            double al = 1.11;
            int fx = 15;
            double yer = 0;
            while (al != fx)
            {
                yer = 1 + al * fx;
                al++;
            }
            MessageBox.Show($"{yer}", "Задание 5", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void E7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E9_Click(object sender, RoutedEventArgs e)
        {
            int sad = 5;
            double rea = 1;
            double qwe = 0.00;
            while(rea<=25)
            {
                rea += 1;
                rea++;
                qwe = sad += 1;
                sad++;
            }
            MessageBox.Show($"{qwe}", "Задание 9", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void E10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E11_Click(object sender, RoutedEventArgs e)
        {
            int let = 1;
            double wa = 1;
            double ew = 15;
            double rew = 0.00;
            while (ew <= 25)
            {
                ew += 1;
                ew++;
                rew = 1+wa/let+1;
                let++;
            }
            MessageBox.Show($"{rew}", "Задание 11", MessageBoxButton.OK, MessageBoxImage.Information);


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
