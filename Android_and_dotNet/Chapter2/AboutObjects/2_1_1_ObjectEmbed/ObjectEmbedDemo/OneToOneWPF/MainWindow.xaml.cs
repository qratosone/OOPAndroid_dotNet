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

namespace OneToOneWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowCounter(0);
        }


        private void ShowCounter(int Counter)
        {
            lblInfo.Text = String.Format("按钮被单击了{0}次", Counter);
        }

        private int Counter = 0;
        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            ShowCounter(++Counter);
        }
    }
}
