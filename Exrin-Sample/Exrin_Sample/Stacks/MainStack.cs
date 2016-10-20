namespace ExrinSample.Stacks
{
    using Exrin.Abstraction;
    using Exrin.Framework;
    using Abstraction.Enums.Views;
    using View;
    using ViewModel;
    using Xamarin.Forms;
    using Abstraction.Enums;
    using Proxy;

    public class MainStack : BaseStack
    {

        public MainStack(IViewService viewService)
            : base(new NavigationProxy(new NavigationPage()), viewService, Stack.Main)
        {
            ShowNavigationBar = false;
        }

        protected override void Map()
        {
            base.NavigationMap<MainView, MainViewModel>(nameof(Main.Main));
            base.NavigationMap<AboutView, AboutViewModel>(nameof(Main.About));
        }

        public override string NavigationStartKey
        {
            get
            {
                return nameof(Main.Main);
            }
        }

    }
}
