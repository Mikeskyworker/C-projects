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
    /// Логика взаимодействия для Inventory.xaml
    /// </summary>
    static class I
    {
        public static int count { get; set; }
    }
    public partial class Inventory : Window
    {
        Random r = new Random();
        public Inventory()
        {
            InitializeComponent();
            
            fill();
            
        }
        
        string b = System.IO.File.ReadAllText(@"Rewards.ini");
        public void fill()
        {
            
            switch (I.count)
            {
                case 0:
                    i1.Visibility = Visibility.Hidden;
                    i2.Visibility = Visibility.Hidden;
                    i3.Visibility = Visibility.Hidden;
                    i4.Visibility = Visibility.Hidden;
                    i5.Visibility = Visibility.Hidden;
                    i6.Visibility = Visibility.Hidden;
                    i7.Visibility = Visibility.Hidden;
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b1.IsEnabled = false;
                    b2.IsEnabled = false;
                    b3.IsEnabled = false;
                    b4.IsEnabled = false;
                    b5.IsEnabled = false;
                    b6.IsEnabled = false;
                    b7.IsEnabled = false;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    log.Text += "Nothing to open\n";
                    break;
                case 1:
                    i2.Visibility = Visibility.Hidden;
                    i3.Visibility = Visibility.Hidden;
                    i4.Visibility = Visibility.Hidden;
                    i5.Visibility = Visibility.Hidden;
                    i6.Visibility = Visibility.Hidden;
                    i7.Visibility = Visibility.Hidden;
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b2.IsEnabled = false;
                    b3.IsEnabled = false;
                    b4.IsEnabled = false;
                    b5.IsEnabled = false;
                    b6.IsEnabled = false;
                    b7.IsEnabled = false;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 2:
                    i3.Visibility = Visibility.Hidden;
                    i4.Visibility = Visibility.Hidden;
                    i5.Visibility = Visibility.Hidden;
                    i6.Visibility = Visibility.Hidden;
                    i7.Visibility = Visibility.Hidden;
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b3.IsEnabled = false;
                    b4.IsEnabled = false;
                    b5.IsEnabled = false;
                    b6.IsEnabled = false;
                    b7.IsEnabled = false;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 3:
                    i4.Visibility = Visibility.Hidden;
                    i5.Visibility = Visibility.Hidden;
                    i6.Visibility = Visibility.Hidden;
                    i7.Visibility = Visibility.Hidden;
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b4.IsEnabled = false;
                    b5.IsEnabled = false;
                    b6.IsEnabled = false;
                    b7.IsEnabled = false;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 4:
                    i5.Visibility = Visibility.Hidden;
                    i6.Visibility = Visibility.Hidden;
                    i7.Visibility = Visibility.Hidden;
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b5.IsEnabled = false;
                    b6.IsEnabled = false;
                    b7.IsEnabled = false;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 5:
                    i6.Visibility = Visibility.Hidden;
                    i7.Visibility = Visibility.Hidden;
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b6.IsEnabled = false;
                    b7.IsEnabled = false;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 6:
                    i7.Visibility = Visibility.Hidden;
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b7.IsEnabled = false;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 7:
                    i8.Visibility = Visibility.Hidden;
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b8.IsEnabled = false;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 8:
                    i9.Visibility = Visibility.Hidden;
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b9.IsEnabled = false;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 9:
                    i10.Visibility = Visibility.Hidden;
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b10.IsEnabled = false;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 10:
                    i11.Visibility = Visibility.Hidden;
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b11.IsEnabled = false;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 11:
                    i12.Visibility = Visibility.Hidden;
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b12.IsEnabled = false;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 12:
                    i13.Visibility = Visibility.Hidden;
                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b13.IsEnabled = false;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                    case 13:

                    i14.Visibility = Visibility.Hidden;
                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b14.IsEnabled = false;
                    b15.IsEnabled = false;
                    break;
                case 14:

                    i15.Visibility = Visibility.Hidden;
                    i16.Visibility = Visibility.Hidden;
                    b15.IsEnabled = false;
                    break;
                case 15:

                    i16.Visibility = Visibility.Hidden;
                    break;






            }
            if (I.count > 15) { i16.Visibility = Visibility.Hidden; }
            if (I.count < 0) { MessageBox.Show("Вы меня огорчаете.");
                MessageBox.Show("ПАЛУНДРА! ОШИБКА НА СУДНЕ!");
                System.IO.File.WriteAllText(@"WriteText.ini", "0");
                System.Environment.Exit(0);
            }



        }
        
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            this.Hide();
            w1.Show();
        }




        
        private string reward (int a)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"Rewards.ini", true);
            switch (a)
            {
                case 0:
                    writer.WriteLine("a");
                    writer.Close();
                    log.Text += "Now you can use \"Необычые\" style of bombs. \n";
                    return "a";
                    
                case 1:
                    writer.WriteLine("b");
                    writer.Close();
                    log.Text += "Now you can use \"Крутые\" style of bombs. \n";
                    return "b";
                    
                case 2:
                    writer.WriteLine("c");
                    writer.Close();
                    log.Text += "Now you can use \"Excellent\" style of bombs. \n";
                    return "c";
                    
                case 3:
                    writer.WriteLine("d");
                    writer.Close();
                    log.Text += "Now you can use \"Perfection\" style of bombs. \n";
                    return "d";
                    
                case 4:
                    writer.WriteLine("e");
                    writer.Close();
                    log.Text += "Now you can use \"TRUE\" style of bombs. \n";
                    return "e";
                    
                case 5:
                    writer.WriteLine("f");
                    writer.Close();
                    log.Text += "Now you can use \"Beauty\" style of bombs. \n";
                    return "f";
                    
                case 6:
                    writer.WriteLine("g");
                    writer.Close();
                    log.Text += "Now you can use \"Flower\" style of bombs. \n";
                    return "g";
                    
                case 7:
                    writer.WriteLine("h");
                    writer.Close();
                    log.Text += "Now you can use \"Bee\" style of bombs. \n";
                    return "h";
                    
                case 8:
                    writer.WriteLine("i");
                    writer.Close();
                    log.Text += "Now you can use \"Angel\" style of bombs. \n";
                    return "i";
                    
                case 9:
                    writer.WriteLine("j");
                    writer.Close();
                    log.Text += "Now you can use \"Ivan\" style of bombs. \n";
                    return "j";
                    
                case 10:
                    writer.WriteLine("k");
                    writer.Close();
                    log.Text += "Now you can use \"Nikolay\" style of bombs. \n";
                    return "k";
                    
                case 11:
                    writer.WriteLine("l");
                    writer.Close();
                    log.Text += "Now you can use \"Alexander\" style of bombs. \n";
                    return "l";
                    
                case 12:
                    writer.WriteLine("m");
                    writer.Close();
                    log.Text += "Now you can use \"KillREAL\" style of bombs. \n";
                    return "m";
                    
                case 13:
                    writer.WriteLine("n");
                    writer.Close();
                    log.Text += "Now you can use \"S\" style of bombs. \n";
                    return "n";
                    
                case 14:
                    writer.WriteLine("o");
                    writer.Close();
                    log.Text += "Now you can use \"Simplify\" style of bombs. \n";
                    return "o";
                   
                case 15:
                    writer.WriteLine("p");
                    writer.Close();
                    log.Text += "Now you can use \"God\" style of bombs. \n";
                    return "p";
                    


            }
            
            return null;

        }
       
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0,15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if ( b.Contains(reward(a))) { 

                  MessageBox.Show("Данный предмет уже имеется в инвентаре.","Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();
            
            
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b10_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b11_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b12_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b13_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b14_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }
        private void b15_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(r.Next(0, 15).ToString());
            log.Text += "Openning case\n";
            log.Text += "Random Number: ";
            log.Text += a.ToString();
            log.Text += "\n";
            string b = System.IO.File.ReadAllText(@"Rewards.ini");
            if (b.Contains(reward(a)))
            {

                MessageBox.Show("Данный предмет уже имеется в инвентаре.", "Внимание");
                I.count--;
                fill();
                System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
                return;
            }
            reward(a);
            I.count--;
            System.IO.File.WriteAllText(@"WriteText.ini", I.count.ToString());
            fill();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }
    }
}
