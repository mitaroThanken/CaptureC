using System.Windows.Controls;

using CaptureC.ViewModels;

namespace CaptureC.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
