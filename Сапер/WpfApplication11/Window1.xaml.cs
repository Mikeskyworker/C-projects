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


namespace WpfApplication11
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
   
    public partial class Window1 : Window
    {
       
        private MediaPlayer _mpBgr;
        private MediaPlayer _mpCurSound;
        
        public Window1()
        {
            D.current = "BombTypes/1bomb.png";
            InitializeComponent();
           
            advert();
            point.Content = "КриптоШишек: ";
            point.Content += D.Points.ToString();
            try
            {
                I.count = Convert.ToInt32(read());
            }
            catch (Exception ex) {
                MessageBox.Show("ПАЛУНДРА! ПРОБЛЕМА С ФАЙЛАМИ ИГРЫ. Уже исправляем.","ААААААААААА");
                System.IO.File.WriteAllText(@"WriteText.ini", "0");
                I.count = Convert.ToInt32(read());
            }
        }

        public void advert ()
        {
            if (System.IO.File.ReadAllText(@"Adwertisment.ini") == "True")
            {
                add.Visibility = Visibility.Hidden;
                this.Height -= 60;

            } else
            {
                if (D.playing == false)
                {
                    _mpBgr = new MediaPlayer();
                    _mpCurSound = new MediaPlayer();
                    _mpBgr.Open(new Uri(@"azino.wav", UriKind.RelativeOrAbsolute));
                    _mpBgr.Play();
                    D.playing = true;
                }
            }
            
        


    }

        public bool combo (string a)
        {

            string allow = System.IO.File.ReadAllText(@"Rewards.ini").ToString();
            

                switch (allow.Contains(a))
                {
                    case true :
                        return true;

                }
            
            return false;





        }
        public string read()
        {
            try
            {
                return System.IO.File.ReadAllText(@"WriteText.ini");

            }
            catch (Exception ex) { MessageBox.Show("An error occurated.", "Error"); return "0"; }



        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            switch (selectedItem.Content.ToString())
            {
                case "Обычные":
                    D.current = "BombTypes/1bomb.png";
                    break;
                case "Необычные":
                    if (combo("a") == true)
                    {
                        D.current = "BombTypes/Необычные.png";
                    }
                    else { MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Крутые":
                    if (combo("b") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Excellent":
                    if (combo("c") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Perfection":
                    if (combo("d") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "TRUE":
                    if (combo("e") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Beauty":
                    if (combo("f") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Flower":
                    if (combo("g") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Bee":
                    if (combo("h") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Angel":
                    if (combo("i") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Ivan":
                    if (combo("j") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Nikolay":
                    if (combo("k") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "Alexander":
                    if (combo("l") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "KillREAL":
                    if (combo("m") == true)
                    {
                        D.current = "BombTypes/KillREAL.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                case "S":
                    if (combo("n") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                 case "Simplify":
                    if (combo("o") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;
                 case "God":
                    if (combo("p") == true)
                    {
                        D.current = "BombTypes/1bomb.png";
                    }
                    else
                    {
                        MessageBox.Show("Вы еще не открыли данный вид бомб.", "Внимание!");
                    }
                    break;





            }
        }
            public void button_Click_1(object sender, RoutedEventArgs e)
        {
            if (
                insert.ToString().Contains("1") == true
                ||
                insert.ToString().Contains("2") == true
                ||
                insert.ToString().Contains("3") == true
                ||
                insert.ToString().Contains("4") == true
                ||
                insert.ToString().Contains("5") == true
                ||
                insert.ToString().Contains("6") == true
                ||
                insert.ToString().Contains("7") == true
                ||
                insert.ToString().Contains("8") == true
                ||
                insert.ToString().Contains("9") == true
                ||
                insert.ToString().Contains("0") == true

                ) { } else { MessageBox.Show("Введены запрещенные символы!"); insert.Text = ""; return; }
            if (Convert.ToInt32(insert.Text.ToString()) > 20 ||  Convert.ToInt32(insert.Text.ToString()) < 4)
            {
                MessageBox.Show("Неверное значение. Попробуйте еще раз", "Внимание!");
                insert.Text = "";
                return;
            }
            this.Hide();
            D.DATA = Convert.ToString(insert.Text);
            D.DATE = (true);
            MainWindow m1 = new MainWindow();
            m1.InitGame();
            m1.Show();
            
            
            
        }

        private void insert_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Shop shop = new Shop();
            shop.Show();
        }

        private void inventory_Click(object sender, RoutedEventArgs e)
        {
            Inventory inv = new Inventory();
            this.Hide();
            inv.Show();
        }

        private void link_Click(object sender, RoutedEventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
