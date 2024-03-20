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

namespace CreatingTest
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {

        List<Model> list = jsonka.des<List<Model>>("test.json") ?? new List<Model>();
        public SecondWindow(int iniialize)
        {
            InitializeComponent();
            if (iniialize == 1) frame.Content = new CreateTest();
            else if (iniialize == 2)
            {
                if (list.Count == 0) frame.Content = new TestIsEmpty();
                else frame.Content = new StartTest(list);
                redactTest.IsEnabled = false;
            }
        }
        private void Window_Closed(object sender, EventArgs e) { }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (list.Count == 0) frame.Content = new TestIsEmpty();
            else frame.Content = new StartTest(list);
        }

        private void redactTest_Click(object sender, RoutedEventArgs e) => frame.Content = new CreateTest();
    }
}
