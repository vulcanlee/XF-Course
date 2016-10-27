using Prism.Unity;
using DeepLink.Views;

namespace DeepLink
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MDPage>();
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<New1Page>();
            Container.RegisterTypeForNavigation<New2Page>();
            Container.RegisterTypeForNavigation<New3Page>();
            Container.RegisterTypeForNavigation<NewMPage>();
        }
    }
}
