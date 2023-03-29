using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace PrimerchikRPM2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        AbonentEntities db = AbonentEntities.GetContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Abonents.Load();
            DB.ItemsSource = db.Abonents.Local.ToBindingList();
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            AddRecord f = new AddRecord();
            f.ShowDialog();
            DB.Focus();
        }
    }
}
