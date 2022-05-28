using System;
using System.Collections.Generic;
using System.Linq;
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

namespace mega_random
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = second.Text;
            string b = Convert.ToString(random_num.Class1.Mega_random(1, 5));
            first.Text = b;
            if (b == a)
            {
                string c = random_num.Class2.Yes(null);
                third.Text = c;
            }
            if (b != a)
            {
                string d = random_num.Class3.No(null);
                third.Text = d;
            }
        }
    }
}
