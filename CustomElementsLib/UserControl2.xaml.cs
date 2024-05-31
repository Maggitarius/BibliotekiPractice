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

namespace CustomElementsLib
{
    public partial class UserControl2 : UserControl
    {
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (contentPresenter.Visibility == Visibility.Visible)
            {
                contentPresenter.Visibility = Visibility.Collapsed;
                toggleButton.Content = "Развернуть";
            }
            else
            {
                contentPresenter.Visibility = Visibility.Visible;
                toggleButton.Content = "Свернуть";
            }
        }
    }
}
