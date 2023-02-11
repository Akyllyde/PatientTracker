using System;

using PatientTracker.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PatientTracker.Views
{
    public sealed partial class WebViewPage : Page
    {
        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
