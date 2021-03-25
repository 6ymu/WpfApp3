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

namespace WpfApp3
{
    public class CoachLesson
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public int Price { get; set; }

      
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameworkElement.StyleProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata
            {
                DefaultValue = FindResource(typeof(Window))
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = (txtBoxFirstName.Text).Trim();
            string surname = (txtBoxSecondName.Text).Trim();

            
            if(name!="" && surname!="")
            {
                lblOutput.Content = "Бонжур, " + name + " " + surname+"!";
            }
        }
    }
}
