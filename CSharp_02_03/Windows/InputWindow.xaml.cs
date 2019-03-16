using CSharp_02_03.ViewModels;
using System.Windows.Controls;

namespace CSharp_02_03.Windows
{
    /// <summary>
    /// Interaction logic for InputWindow.xaml
    /// </summary>
    public partial class InputWindow : UserControl
    {
        public InputWindow()
        {
            InitializeComponent();
            DataContext = new InputViewModel();

        }
    }
}
