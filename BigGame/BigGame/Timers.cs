using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.IO;

namespace BigGame
{
    class Timers
    {
        private DispatcherTimer begintimer = null;
        private DispatcherTimer clicklabeltimer = null;
        
       

        public void begintimerStart()
        {
            begintimer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            begintimer.Tick += new EventHandler(begintimerTick);
            begintimer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            begintimer.Start();
        }

        private void begintimerTick(object sender, EventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.startlabel.Opacity += 0.01;
            if (mw.startlabel.Opacity >= 1) { mw.preparing(); begintimer.Stop(); return; }

        }

        public void clicklabeltimerStart()
        {
            clicklabeltimer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            clicklabeltimer.Tick += new EventHandler(clicklabeltimerTick);
            clicklabeltimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            clicklabeltimer.Start();

        }

        private void clicklabeltimerTick(object sender, EventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.labelmoving();

        }

    }
}
