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

namespace WPF_Rassokhin_PR_10
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void Delet_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void Soft_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void CoffieCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cofe_1.Source = new BitmapImage(new Uri("Image/Xleb.jpg", UriKind.Relative));
        }

        private void TeaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cofe_1.Source = new BitmapImage(new Uri("Image/vatrushki.jpg", UriKind.Relative));
        }

        private void OrangeJuiceCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cofe_1.Source = new BitmapImage(new Uri("Image/oponki.jpg", UriKind.Relative));
        }

        private void MilkCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cofe_1.Source = new BitmapImage(new Uri("Image/pirozhki.jpg", UriKind.Relative));
        }

        private void IcedTeaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cofe_1.Source = new BitmapImage(new Uri("Image/baget.jpeg", UriKind.Relative));
        }

        private void MangoShakeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cofe_1.Source = new BitmapImage(new Uri("Image/syxari.jpg", UriKind.Relative));
        }
    }
}
