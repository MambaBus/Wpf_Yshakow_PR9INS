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

namespace Wpf_Yshakow_PR9INS
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ListBoxItem lbi = (ListBoxItem)(phonesList.ItemContainerGenerator.ContainerFromIndex(1));
            TextBlock.Text = lbi.Content.ToString();

            ListBoxItem lbi2 = (ListBoxItem)(phonesList.ItemContainerGenerator.ContainerFromIndex(4));
            TextBlock2.Text = lbi2.Content.ToString();
        }
    }
}
