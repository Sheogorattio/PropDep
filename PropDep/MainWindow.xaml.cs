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

namespace PropDep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IncomeTextBox.LostFocus += (object sender, RoutedEventArgs e) => { slider.Maximum = myControll.Data; };
            //this.MouseDoubleClick += (object sender, MouseButtonEventArgs e) => { MessageBox.Show(myControll.Data.ToString()); };
        }

        private void IncomeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if( !((e.Key >= Key.D0 && e.Key <= Key.D9)) && e.Key != Key.Delete && e.Key != Key.CapsLock && e.Key != Key.Tab && e.Key!=Key.Enter && e.Key != Key.LeftAlt && e.Key != Key.RightAlt && e.Key != Key.LeftShift && e.Key != Key.RightShift && !(e.Key == Key.Back || e.Key == Key.Delete))
            {
                IncomeTextBox.Text = IncomeTextBox.Text.Remove(IncomeTextBox.Text.Length - 1, 1);
                IncomeTextBox.SelectionStart = IncomeTextBox.Text.Length;
                IncomeTextBox.SelectionLength = 0;
            }
        }
    }
}
