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
using System.Windows.Threading;
using System.Media;

/* */

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    static public class Data { static public bool start { get; set; } }
    public partial class MainWindow : Window
    {
        /* public void generate ()
         {
             Image enemy = new Image();
             enemy.Source = new BitmapImage(new Uri(@"C:\Users\icYFTL\source\repos\Game\Game\images\enemy.jpg"));
             //Random rx = new Random();
             // Random ry = new Random();
             // int randy = ry.Next(0,290);
             Canvas.SetTop(enemy, 0);
             Canvas.SetLeft(enemy, 0);
         }*/
        bool ismuted=false;
        public MainWindow()
        {
            InitializeComponent();
            if (Data.start == false)
            {
                StartWindow w1 = new StartWindow();
                this.Hide();
                w1.Show();
            }
            
        }
        public void audio(bool a)
        {
            SoundPlayer sp;
            string source = "Audio/Das Mörtal - Hotline Miami II.wav"; 
            int b = randomn(0, 2);
            if (b == 0)
            {
                source = "Audio/Das Mörtal - Hotline Miami II.wav";
            }
            if (b == 1)
            {
                source = "Audio/Hotline Miami 2 - CS-GO.wav";
            }
            
            sp = new SoundPlayer(@source);
            if (a == true)
            {
                sp.Play();
            }
            else sp.Stop();
        }
        private DispatcherTimer timer = null;
        private int x;
        int speed = 20;
        int scoreCount = 0;
        public void timerStart()
        {
            timer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, speed);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e) //Тут код выполняется циклично с интервалом speed (ms)
        {
            score.Content = scoreCount.ToString();
            double x = Canvas.GetLeft(enemy);//Вычисление x от enemy
            double y = Canvas.GetTop(enemy);//Вычесление y от enemy
            x -= 5; //Единичный шаг enemy
            Canvas.SetLeft(enemy, x); //Установка новой координаты  enemy
            if (x < -200) //Если enemy вышел за пределы canvas
            {

                Canvas.SetTop(enemy, randomn(0, 200));//Перемещаем enemy на рандомную позицию по Y (от 0 до 200)
                Canvas.SetLeft(enemy, 600);//Перемещаем enemy на по X (600)
                speed = randomn(1, 10); //Генерим скорость движения enemy (1 ms - 10 ms)
                timer.Interval = new TimeSpan(0, 0, 0, 0, speed);//Установка скорости
                enemy.Height = randomn(50, 200); enemy.Width = randomn(50, 200); //Рандомная генерация размера enemy
                scoreCount++;


            }

            check();//Проверка на столкновение
        }
        public void resolve ()
        {
            try
            {
               int a =  Convert.ToInt32(System.IO.File.ReadAllText(@"bestscore.ini").ToString());
               if (a < scoreCount) { System.IO.File.WriteAllText(@"bestscore.ini", scoreCount.ToString()); }
            }
            catch (Exception ex) { System.IO.File.WriteAllText(@"bestscore.ini", "0"); return; }
        }
        public void check ()
        {
            double enemyx = Canvas.GetLeft(enemy);
            double enemyy = Canvas.GetTop(enemy);
            double playerx = Canvas.GetLeft(player);
            double playery = Canvas.GetTop(player);
            if (enemyx == playerx+50)
            {
                for (int i = 0; i < 50; i++) { if (enemyy == playery || enemyy - i == playery) {
                        MessageBox.Show("You lose!");
                        audio(false);
                        resolve();
                        timer.Stop();
                        this.Hide();
                        StartWindow s1 = new StartWindow();
                        s1.scoreUpdater();
                        s1.Show();
                        break;
                    }
                }
                for (int i = 0; i < 75; i++)
                     if (enemyy == playery || enemyy+i == playery) {
                        MessageBox.Show("You lose!");
                        audio(false);
                        resolve();
                        timer.Stop();
                        this.Hide();
                        StartWindow s1 = new StartWindow();
                        s1.scoreUpdater();
                        s1.Show();
                        break;
                    }
            }

        }

        public int randomn (int a, int b)
        {
            Random r = new Random();
            return r.Next(a,b);


        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Image gen = new Image();
            double x = Canvas.GetLeft(player);
            double y = Canvas.GetTop(player);
            if (e.Key == Key.Up) //Если прожата UP
            {
                if (y - 10 > -4) { } else { y = -4; return; }
                y -= 10;

            }
            if (e.Key == Key.Down)
            {
                if (y + 10 < 265) { } else { y = 265; return; }
                y += 10;

            }
            if (e.Key == Key.M)
            {
                if (ismuted == false) { audio(false); ismuted = true; }
                else
                {
                    audio(true);
                    ismuted = false;
                }
            }

                //Canvas.SetLeft(player, x);
                Canvas.SetTop(player, y);
            
        }

        private void mute_Click(object sender, RoutedEventArgs e)
        {
            if (ismuted == false)
            {
                audio(false); ismuted = true;
                //mute_img.Source = new BitmapImage(new Uri(@"Pictures/muted.png"));
            }
            else
            {
                audio(true);
                ismuted = false;
                //mute_img.Source = new BitmapImage(new Uri(@"Pictures/unmuted.png"));
            }
        }
    }
}
