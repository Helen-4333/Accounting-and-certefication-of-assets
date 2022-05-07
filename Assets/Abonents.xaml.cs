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
    /// Логика взаимодействия для Abobents.xaml
    /// </summary>
    public partial class Abobents : Page
    {

        

        public Abobents()
        {
            InitializeComponent();
            ComboType.ItemsSource = AssetsAccountingEntities.GetContext().Abonent.ToList();  

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                AssetsAccountingEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGAbonents.ItemsSource = AssetsAccountingEntities.GetContext().Abonent.ToList();
             
            }
        }

        private void ToursGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckActual_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckNoActual_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
