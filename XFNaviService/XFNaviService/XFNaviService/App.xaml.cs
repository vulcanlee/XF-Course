using Prism.Unity;
using XFNaviService.Views;

namespace XFNaviService
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MDPage>();
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<Sub1Page>();
            Container.RegisterTypeForNavigation<Sub2Page>();
            Container.RegisterTypeForNavigation<Sub3Page>();
            Container.RegisterTypeForNavigation<NaviDemoHomePage>();
        }
    }
}
