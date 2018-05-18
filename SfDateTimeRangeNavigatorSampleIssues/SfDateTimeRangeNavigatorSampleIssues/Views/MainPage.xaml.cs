using SfDateTimeRangeNavigatorSampleIssues.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfDateTimeRangeNavigatorSampleIssues.Views
{
#if !DEBUG
    [XamlCompilation(XamlCompilationOptions.Compile)]
#endif
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel context;

        public MainPage()
        {
            InitializeComponent();

            context = new MainPageViewModel(Navigation);
            BindingContext = context;
        }
    }
}