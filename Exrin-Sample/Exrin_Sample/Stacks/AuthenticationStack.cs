namespace ExrinSample.Stacks
{
    using Abstraction.Enums;
    using Abstraction.Enums.Views;
    using Exrin.Abstraction;
    using Exrin.Framework;
    using Proxy;
    using View;
    using ViewModel;
    using Xamarin.Forms;

    public class AuthenticationStack : BaseStack
    {
        public AuthenticationStack(IViewService viewService)
            : base(new NavigationProxy(new NavigationPage()), viewService, Stack.Authentication)
        {
            ShowNavigationBar = false;
        }
        protected override void Map()
        {
            base.NavigationMap<LoginView, LoginViewModel>(nameof(Authentication.Login));
        }

        public override string NavigationStartKey
        {
            get
            {
                return nameof(Authentication.Login);
            }
        }
    }
}
