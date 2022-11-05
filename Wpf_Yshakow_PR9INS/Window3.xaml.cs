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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = "Hello world";
            string[] arr = str.Split(' ');
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length != 1)
                {
                    char ch1 = arr[i][0];
                    char ch2 = arr[i][arr[i].Length - 1];
                    arr[i] = ch2 + arr[i].Substring(1, arr[i].Length - 2) + ch1;
                }
                result += arr[i] + " ";
                t2.Text = result.ToString();
            }
        }
    }
}
