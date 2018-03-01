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

namespace WpfApplication11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    static class D
    {
        public static string DATA { get; set; }
        public static bool DATE { get; set; }

        public static bool playing { get; set; }

        public static int Points { get; set; }
        public static string current { get; set; }
    }
    public partial class MainWindow : Window
    {
        int n = 5;
        int m = 5;
        int[,] array; // Объявление ссылки на двумерный массив
        Random r = new Random();
        int open = 0;
        public MainWindow()
        {


            if (D.DATE == false)
            {
                I.count = 0;
                Window1 w1 = new Window1();
                this.Hide();
                w1.Show();

            }
        }

        public void InitGame()
        {
            InitializeComponent();
            
            n = Convert.ToInt32(D.DATA); //Конвертация данных с textblock с Window1 в int
            m = Convert.ToInt32(D.DATA); //Тоже самое
            array = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < m; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            generate();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Button b = new Button();
                    grid.Children.Add(b);
                    Grid.SetColumn(b, j);
                    Grid.SetRow(b, i);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Button b = new Button();
                    b.Click += new RoutedEventHandler(Button_Click);
                    b.MouseRightButtonDown += new MouseButtonEventHandler(b1_MouseRightButtonDown);
                    grid.Children.Add(b);
                    Grid.SetColumn(b, j);
                    Grid.SetRow(b, i);
                }
            }
            

        }
       public void generate () // Генерация бомб
        {


            int procent = ((n * m) * 25) / 100;

            for (int i = 0; i < procent; i++)
            {
                int a = r.Next(0, n);
                int b = r.Next(0, n);
                array[a, b] = -1;

            }



        }
        public int colvo(int y, int x)
        {  //проверка на бомбы также бомбы теперь -1 для удобства работы

            int value = 0;
            if ((x == 0) && (y == 0))
            {
                if (array[0, 1] == -1) { value++; } else { nestfield(1, 0);  }
                if (array[1, 1] == -1) { value++; } else { nestfield(1, 1);  }
                if (array[1, 0] == -1) { value++; } else { nestfield(0, 1);  }
                return value;
            }
            if ((x == n - 1) && (y == m - 1))
            {
                if (array[n - 2, m - 1] == -1) { value++; }
                else
                { nestfield(n - 2, m - 1);  }
                if (array[n - 1, m - 2] == -1) { value++; }
                else
                { nestfield(n - 1, m - 2); }
                if (array[n - 2, m - 2] == -1) { value++; }
                else
                { nestfield(n - 2, m - 2);  }
                return value;
            }
            if ((x == n - 1) && (y == 0))
            {
                if (array[n - 2, 0] == -1) { value++; }
                else
                { nestfield(0, n - 2); }
                if (array[n - 2, 1] == -1) { value++; }
                else
                { nestfield(1, n - 2);  }
                if (array[n - 1, 1] == -1) { value++; }
                else
                { nestfield(1, n - 1); }
                return value;
            }
            if ((x == 0) && (y == m - 1))
            {
                if (array[0, m - 2] == -1) { value++; }
                else
                { nestfield(m - 2, 0);  }
                if (array[1, m - 2] == -1) { value++; }
                else
                { nestfield(m - 2, 1);  }
                if (array[1, m - 1] == -1) { value++; }
                else
                { nestfield(m - 1, 1);  }
                return value;
            }
            if ((x == 0))
            {
                if (array[0, y - 1] == -1) { value++; }
                //{ nestfield(y-1,0); open++; }
                if (array[0, y + 1] == -1) { value++; }
                // { nestfield(0,y+1); open++; }
                if (array[1, y] == -1) { value++; }
                //{ nestfield(y, 1); open++; }
                if (array[1, y - 1] == -1) { value++; }
                //{ nestfield(y - 1, 1); open++; }
                if (array[1, y + 1] == -1) { value++; }
                //{ nestfield(y + 1, 1); open++; }
                return value;
            }
            if ((y == 0))
            {
                if (array[x - 1, 0] == -1) { value++; }
                //{ nestfield(0, x - 1); open++; }
                if (array[x + 1, 0] == -1) { value++; }
                //{ nestfield(0, x + 1); open++; }
                if (array[x, 1] == -1) { value++; }
                //{ nestfield(1, x); open++; }
                if (array[x - 1, 1] == -1) { value++; }
                //{ nestfield(1, x - 1); open++; }
                if (array[x + 1, 1] == -1) { value++; }
                //{ nestfield(1, x + 1); open++; }
                return value;
            }
            if ((y == m - 1))
            {
                if (array[x - 1, y] == -1) { value++; }
                //{ nestfield(y, x - 1); open++; }
                if (array[x - 1, y - 1] == -1) { value++; }
                //{ nestfield(y - 1, x - 1); open++; }
                if (array[x, y - 1] == -1) { value++; }
                //{ nestfield(y - 1, x); open++; }
                if (array[x + 1, y - 1] == -1) { value++; }
                //{ nestfield(y - 1, x + 1); open++; }
                if (array[x + 1, y] == -1) { value++; }
                //{ nestfield(y, x + 1); open++; }
                return value;
            }
            if ((x == m - 1))
            {
                if (array[x, y - 1] == -1) { value++; }
                if (array[x, y + 1] == -1) { value++; }
                if (array[x - 1, y - 1] == -1) { value++; }
                if (array[x - 1, y] == -1) { value++; }
                if (array[x - 1, y + 1] == -1) { value++; }
                return value;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[x - 1 + i, y - 1 + j] < 0) { value++; }
                }

            }
            return value;


        }


        public void win () // Проверка победы
        {
            if (open >= (n * m)+1)
            {
                MessageBox.Show("Вы победили!");
                Window1 w1 = new Window1();
                this.Close();
                w1.Show();
            }
            else return;


        }


        public void lose (object sender, RoutedEventArgs e)
        {
            Button b = (sender as Button);

            b.Content = new Image
            {
                
                Source = new BitmapImage(new Uri(D.current, UriKind.Relative)),
                VerticalAlignment = VerticalAlignment.Center,
            };
            b.IsEnabled = false;
            MessageBox.Show("Вы проиграли.","Увы.");
            System.IO.File.WriteAllText(@"Money.ini", D.Points.ToString());
            this.Close();
            Window1 w1 = new Window1();
            w1.Show();



        }
        public int openfield(int y_pos, int x_pos)
        {
            if (array[y_pos, x_pos] == -1)
            {
                return -1;
            }
            else
            {
                D.Points += 10;
                int localvar = colvo(x_pos, y_pos);

                return localvar;

            }


        }

        public void nestfield(int x, int y)
        {
            open++;
            int local = colvo(x, y);
            TextBlock b = new TextBlock();
        
            b.Text += local.ToString();
            b.VerticalAlignment = VerticalAlignment.Center;
            b.HorizontalAlignment = HorizontalAlignment.Center;
            grid.Children.Add(b);
            Grid.SetColumn(b, x);
            Grid.SetRow(b, y);


        }

    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            open++;
            Button b = (sender as Button);
            int x_pos = Grid.GetColumn(b);
            int y_pos = Grid.GetRow(b);
            b.IsEnabled = false;
            
            int point;
            point = openfield(y_pos, x_pos);
            if (point == -1)
            {
                lose(sender, e);
            }
            else
            {
                string sss = point.ToString();
                b.Content = sss;
                win();

               
            }

        }
        private void b1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {


            Button b = (sender as Button);
            b.Content = new Image
            {
                Source = new BitmapImage(new Uri("images/flag.png", UriKind.Relative)),
                VerticalAlignment = VerticalAlignment.Center,
            };
            int x_pos = Grid.GetColumn(b);
            int y_pos = Grid.GetRow(b);
            if (array[y_pos, x_pos] == -1) { open++; }; //Если не бомба -- считать за открытую клетку
            win();
    }


        private void Window_Closed(object sender, EventArgs e)
        {
            //Application.Current.Shutdown();
        }
    }
}
