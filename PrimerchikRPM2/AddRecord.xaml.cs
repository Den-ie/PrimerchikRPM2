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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;

namespace PrimerchikRPM2
{
    /// <summary>
    /// Логика взаимодействия для AddRecord.xaml
    /// </summary>
    public partial class AddRecord : Window
    {
        public AddRecord()
        {
            InitializeComponent();
            this.Height += 25;
        }

        AbonentEntities db = AbonentEntities.GetContext();
        Abonent p1 = new Abonent();

        private void Add(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click_Add(object sender, RoutedEventArgs e)

        {
            StringBuilder errors = new StringBuilder();

            if (FIO.Text.Length == 0)
                errors.AppendLine("Baequte gammnna");
            if (Gender.Text != "Муж." && Gender.Text != "Жен.")
                errors.AppendLine("Bsequte non Myx/KeH");
            if (INN.Text.Length != 12 |
            double.TryParse(INN.Text, out double x) == false)
                errors.AppendLine("Henpasunbuuilt MH");

            if (AgePicker.Text.Length == 0) errors.AppendLine("Bsequre gaty");

            DateTime dt = DateTime.Now;

            DateTime dp = Convert.ToDateTime(AgePicker.SelectedDate);

            int yt = dt.Year;

            int yp = dp.Year;

            if (yt - yp < 18)
            {
                errors.AppendLine("Bseante npasnnbHo Aaty poKmeHHA");
            }
        }
    }
}
