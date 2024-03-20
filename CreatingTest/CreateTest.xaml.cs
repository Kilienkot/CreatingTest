using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreatingTest
{
    /// <summary>
    /// Логика взаимодействия для CreateTest.xaml
    /// </summary>
    public partial class CreateTest : Page
    {
        List<Model> list = jsonka.des<List<Model>>("test.json") ?? new List<Model>();
        public CreateTest()
        {
            InitializeComponent();
            data.ItemsSource = list;
        }

        private void dataGrid_BeginningEdit(object sender, DataGridCellEditEndingEventArgs e)
        {
            jsonka.ser("test.json", list);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data.ItemsSource = null;
            data.ItemsSource = list;
        }
    }
}
