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

namespace Сalendar_of_jokes
{
    /// <summary>
    /// Логика взаимодействия для JokeElement.xaml
    /// </summary>
    public partial class JokeElement : UserControl
    {
        public JokeElement()
        {
            InitializeComponent();
        }

        private void Choosed_theme_Click(object sender, RoutedEventArgs e)
        {
            Choosed_theme.Background = new SolidColorBrush(Color.FromArgb(103, 58, 183, 100));
        }

    }
}

