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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Peach_Launcher.Panels.Sys
{
    /// <summary>
    /// Interaction logic for pwrOpts.xaml
    /// </summary>
    public partial class pwrOpts : Window
    {
        public pwrOpts()
        {
            InitializeComponent();
        }

        #region ========== PANEL EVENTS ==========

        private void pwrOptsPnl_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ========== SYS BUTTON CLICK EVENTS ==========

        private void sysBtnShutdown_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Shutting Down");
        }

        private void sysBtnRestart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Restarting");
        }

        private void sysBtnQuitLauncher_Click(object sender, RoutedEventArgs e)
        {
            var peachLauncher = Application.Current.MainWindow;
            peachLauncher.Close();
        }

        #endregion
    }
}
