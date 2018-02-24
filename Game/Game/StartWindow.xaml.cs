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
using System.Windows.Threading;


namespace Game
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private DispatcherTimer timer = null;
        public StartWindow()
        {
            InitializeComponent();
            scoreUpdater();
        }
        int x = 0;

        public void scoreUpdater ()
        {
            try
            {
                bestscore.Content = System.IO.File.ReadAllText(@"bestscore.ini").ToString();
            }
            catch (Exception ex) { bestscore.Content = "0"; }

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
            Data.start = true;
            MainWindow mw = new MainWindow();
            mw.timerStart();
            mw.audio(true);
            mw.Show();
            

        }
    }
}
