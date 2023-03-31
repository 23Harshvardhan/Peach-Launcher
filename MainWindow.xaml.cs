using Peach_Launcher.Panels.Sys;
using Peach_Launcher.Panels.Util;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Peach_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            #region ========== DISPATCHED TIMER ==========

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            #endregion
        }

        #region ========== UI EVENTS ==========

        #region ========== Clock ==========

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblActClock.Content = DateTime.Now.ToString("hh:mm tt");
        }

        #endregion

        #endregion

        #region ========== ACTION BAR EVENTS ==========

        private void btnPowerOptions_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (SysVar.pwrOptsOpen == false)
            {
                SysVar.pwrOptsOpen = true;

                Point actBarPos = rectActionBar.TranslatePoint(new Point(0, 0), this);

                pwrOpts powerOptionsPanel = new pwrOpts();

                powerOptionsPanel.Opacity = 0;
                powerOptionsPanel.Left = actBarPos.X;
                powerOptionsPanel.Top = actBarPos.Y + 50;
                powerOptionsPanel.Owner = this;
                powerOptionsPanel.Show();

                // Animation properties starts here
                DoubleAnimation anim = new DoubleAnimation();
                anim.From = 0;
                anim.To = 1;
                anim.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                Storyboard storyBoard = new Storyboard();
                storyBoard.Children.Add(anim);
                Storyboard.SetTarget(anim, powerOptionsPanel);
                Storyboard.SetTargetProperty(anim, new PropertyPath(Window.OpacityProperty));
                storyBoard.Begin();
                // Animation properties ends here
            }
        }

        #endregion
    }
}
