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
using mshtml;
using System.Net;
using System.IO;

namespace BigGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ListBox chat = new ListBox();
        TextBox input = new TextBox();
        Button but = new Button();
        Timers tm = new Timers();
        ChatUpdate chatupdater = new ChatUpdate();
        bool focused_input = false;
        private MediaPlayer player = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();

        }
        public void eventmanager()
        {

            EventManager.RegisterClassHandler(typeof(TextBox),
                                  UIElement.PreviewMouseLeftButtonDownEvent,
                                  new MouseButtonEventHandler(StopTextBoxClick),
                                  true);
            EventManager.RegisterClassHandler(typeof(TextBox),
                                              UIElement.GotFocusEvent,
                                              new RoutedEventHandler(input_GotFocus),
                                              true);

        }
        private void StopTextBoxClick(object sender, MouseButtonEventArgs e)
        {
            TextBox text = sender as TextBox;
            if (text != null && !text.IsKeyboardFocusWithin)
            {
                e.Handled = true;
                text.Focus();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tm.begintimerStart();
           // player.Open(new Uri(@"BeginSound.mp3", UriKind.Relative));
           // player.Play();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void preparing ()
        {
            tm.clicklabeltimerStart();
            Canvas.SetZIndex(next, 1);
            next.Visibility = Visibility.Visible;
            next.IsEnabled = true;

        }
        public void remove ()
        {
            canvas.Children.Remove(startlabel);
            canvas.Children.Remove(next);
            canvas.Children.Remove(continuelab);

        }
        public void labelmoving ()
        {
            double x = Canvas.GetLeft(continuelab);
            x+=3;
            Canvas.SetLeft(continuelab, x);
            if (x > 1366) { Canvas.SetLeft(continuelab, -288); }


        }
        private void input_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox text = sender as TextBox;
            text.Text = "";
            focused_input = true;
        }
        private void input_LostFocus(object sender, RoutedEventArgs e)
        {
                TextBox text = sender as TextBox;
                text.Text = "Type Something...";
            focused_input = false;
        }
            public void startgame()
        {
            
            remove();
            /* Chat begin */
            canvas.Children.Add(chat);
            chat.Height = 387;
            chat.Width = 271;
            Canvas.SetLeft(chat, 1094);
            Canvas.SetTop(chat, 335);
            File.WriteAllText(@"data.txt", "");
            chatupdater.starting();
            chatupdater.chattimerStart();

            canvas.Children.Add(input);
            input.Height = 45;
            input.Width = 271;
            input.GotFocus += new RoutedEventHandler(input_GotFocus);
            input.LostFocus += new RoutedEventHandler(input_LostFocus);
            input.PreviewTextInput += new TextCompositionEventHandler(input_PreviewTextInput);
            input.MaxLength = 50;
            input.Text = "Type Something...";
            Canvas.SetLeft(input, 1094);
            Canvas.SetTop(input, 722);
            /* Chat end */

            /*Games begin */
            but.Name = "KrestikiNoliki";
            canvas.Children.Add(but);
            but.Height = 47;
            but.Width = 193;
            Canvas.SetLeft(but, 57);
            Canvas.SetTop(but, 66);
            but.Content = "Крестики-нолики\n        [Online]";
            but.Click += new RoutedEventHandler(KrestikiNoliki_Start);
            /*Games end */

        }
        public void KrestikiNoliki_Start(object sender, RoutedEventArgs e)
        {
            chat_hide();

        }
        public void chat_preparing ()
        {
            string[] str = File.ReadAllLines(@"data.txt");
            for (int i = 0; i < str.Length; ++i) { chat.Items.Add(str[i]); }
        }
        public void chat_hide()
        {
            chat.Visibility = Visibility.Hidden;
            input.Visibility = Visibility.Hidden;

        }
        private void next_Click(object sender, RoutedEventArgs e)
        {
            startgame();
        }
        private void input_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ#!@$%^&*()=-+_/*.,:?№\"~`<>|{}[]$ ".IndexOf(e.Text) < 0;
        }
        public bool input_check()
        {
            bool contain = false;
            string data = input.Text.ToString();
            if (data == "" || data == null )
            {
              return false;
            }
            for (int i = 0; i < 254; ++i)
            { if (data.Contains((char)i))

                {
                   if (i == 32) { } else
                    {
                        contain = true;

                    }
                      
                }

            }
           if (contain == false) { return false; }
          
            return true;


        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) //Если прожата ENTER
            {
                if (focused_input == true)
                {
                    if (input_check() == true)
                    {
                        chat.Items.Add(input.Text);
                        input.Text = "";

                    }
                    else MessageBox.Show("Empty message.", "Error"); return;
                }

            }
        }
    }
}
