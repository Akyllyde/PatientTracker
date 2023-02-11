using System;

using PatientTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PatientTracker.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
