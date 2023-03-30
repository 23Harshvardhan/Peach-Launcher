using Peach_Launcher.Panels.Sys;
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
        }

        #region ========== Action Bar Events ==========

        private void btnPowerOptions_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point actBarPos = rectActionBar.TranslatePoint(new Point(0, 0), this);

            pwrOpts powerOptionsPanel = new pwrOpts();
            powerOptionsPanel.Left = actBarPos.X;
            powerOptionsPanel.Top = actBarPos.Y + 50;
            powerOptionsPanel.Owner = this;
            powerOptionsPanel.Show();
        }

        #endregion
    }
}
