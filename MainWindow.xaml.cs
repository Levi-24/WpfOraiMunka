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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbx1.Items.Add("Csütörtök");
            lbx1.Items.Add("Péntek");
            lbx1.Items.Add("Szombat");
            lbx1.Items.Add("Vasárnap");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("ASD", "XD", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.OK);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    lbl1.Content = "Igen";
                    break;
                case MessageBoxResult.No:
                    lbl1.Content = "Nem";
                    break;
                case MessageBoxResult.Cancel:
                    lbl1.Content = "Mégse";
                    break;
            }
        }
    }
}
