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
using Excel = Microsoft.Office.Interop.Excel;
using System.Xml.Linq;
using System.Data;
using System.IO;

namespace Vygolov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataSet data1 = new DataSet();
            //data1.ReadXml(@"C:\Users\student\source\repos\Vygolov\XMLSchema1.xsd");
                   
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        
        {
            if (cb1.IsSelected==true)
            {
                StreamWriter writer = new StreamWriter(@"C:\Users\student\source\repos\Vygolov\save\fff.csv");
                writer.WriteLine("name; lastname; group");
                writer.WriteLine(tb1.Text + ";" + tb2.Text + ";" + cb1.Content);
                writer.Close();
                }
        }

        
    }
}
