using System;
using System.IO;
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

namespace WpfApplication11
{
    /// <summary>
    /// Логика взаимодействия для Shop.xaml
    /// </summary>
    public partial class Shop : Window
    {
        int counts;
        public Shop()
        {
            
            InitializeComponent();
            if (System.IO.File.ReadAllText(@"Adwertisment.ini") == "True") { addvertisment.IsEnabled = false; }
            D.Points = Convert.ToInt32(System.IO.File.ReadAllText(@"Money.ini"));
            balance.Content = "КриптоШишек: ";
            balance.Content += D.Points.ToString();
        }

        private void case1click_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите купить 1 Blue Case за 100 криптошишек?",
  "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (D.Points >= 100)
                {
                    D.Points -= 100;
                    System.IO.File.WriteAllText(@"Money.ini", D.Points.ToString());
                    balance.Content = "КриптоШишек: ";
                    balance.Content += D.Points.ToString();
                    MessageBox.Show("Blue Case куплен. Проверьте ваш инвентарь.", "Успешно!");
                    counts++;
                }
                else { MessageBox.Show("Недостаточно средств.", "Ошибка!");  return; }
            }
            else
            {
                
                return;
            }

        }



        public void write(int a)
     
        {
            if (read() == "" || read() == "0")
            {
                System.IO.File.WriteAllText(@"WriteText.ini", counts.ToString());
            } else
            {
                int k = Convert.ToInt32(read());
                int sum = counts + k;
                System.IO.File.WriteAllText(@"WriteText.ini", sum.ToString());
            }

        }
        public string read()
        {
            try
            {
                return System.IO.File.ReadAllText(@"WriteText.ini");

            }
            catch(Exception ex) { MessageBox.Show("An error occurated.", "Error"); return "0"; }
                
           

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            write(counts);
            this.Hide();
            Window1 w1 = new Window1();
            w1.Show();
        }

        private void addvertisment_Click(object sender, RoutedEventArgs e)
        {
            if (System.IO.File.ReadAllText(@"Adwertisment.ini") != "True")
            {
                if (D.Points >= 1200)
                {
                    D.Points -= 1200;
                    System.IO.File.WriteAllText(@"Money.ini", D.Points.ToString());
                    balance.Content = "КриптоШишек: ";
                    balance.Content += D.Points.ToString();
                    MessageBox.Show("Успешно куплено!","Успех!");
                    System.IO.File.WriteAllText(@"Adwertisment.ini", "True");
                    Window1 w1 = new Window1();
                    w1.advert();
                } else MessageBox.Show("Недостаточно средств.", "Ошибка!"); return;
            }
            else MessageBox.Show("Вы уже приобрели эту функцию!", "Ошибка!"); return;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }
    }
}
