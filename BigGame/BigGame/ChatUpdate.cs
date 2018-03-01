using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using mshtml;
using System.Diagnostics;
using System.Windows.Threading;


namespace BigGame
{
    class ChatUpdate
    {
        private DispatcherTimer chattimer = null;
        int a = 0;
        bool connected = false;
        public void chattimerStart()
        {
            chattimer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            chattimer.Tick += new EventHandler(chattimerTick);
            chattimer.Interval = new TimeSpan(0, 0, 0, 0, 2000);
            chattimer.Start();
        }

        private void chattimerTick(object sender, EventArgs e)
        {
            a++;
            string chatdata;
            chatdata = File.ReadAllText(@"data.txt");
            if (chatdata != null && chatdata != "") { connected = true; } else { starting(); }
            if (a >= 10)
            {
                MessageBox.Show("Internal server error.\nChat isn't available.", "Server Exception"); chattimer.Stop(); return;
            }
            else
            {
                if (connected == true)
                {
                    MainWindow mw = (MainWindow)Application.Current.MainWindow;
                    mw.chat_preparing();
                    chattimer.Stop();
                }
            }

        }
        public void starting()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = @"ChatUpdater.exe";
            proc.Start();
        }
        public void updater ()
        {
            //Doesn't work now



            string chatdata,latechatdata;
            chatdata = File.ReadAllText(@"data.txt");
            starting();
            latechatdata = File.ReadAllText(@"data.txt");
            //if (latechatdata == chatdata) { } else
           // {
                MainWindow mw = (MainWindow)Application.Current.MainWindow;
            
            
                string[] str = File.ReadAllLines(@"data.txt");
               // for (int i = 0; i < latechatdata.Length; ++i) { if (str[i] == mw.chat.Items)}
           // }


        }
    }

}
