using System.Windows.Controls;

using CaptureC.ViewModels;

namespace CaptureC.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
