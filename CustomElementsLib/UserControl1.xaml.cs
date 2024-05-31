using System.Text;
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
    public partial class UserControl1 : UserControl
    {
        public string InfoText
        {
            get { return (string)GetValue(InfoTextProperty); }
            set { SetValue(InfoTextProperty, value); }
        }

        public static readonly DependencyProperty InfoTextProperty =
            DependencyProperty.Register("o((>ω< ))o", typeof(string), typeof(UserControl1), new PropertyMetadata("Ну тут типа текстಠ_ಠ"));

        public void UpdateInfoText()
        {
            infoText.Text = InfoText;
        }
    }
}
