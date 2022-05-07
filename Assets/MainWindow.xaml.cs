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

namespace Assets
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Abobents());
            Manager.MainFrame = MainFrame;
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
           

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void logotip_Click(object sender, RoutedEventArgs e)
        {

        }

        private void abonents_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Abobents());
        }

        private void equipment_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Equipment());
        }

        private void assets_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Activ());
        }

        private void billing_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Billing());
        }

        private void support_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SupportUsers());
        }

        private void crm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CRM());
        }
    }
}
