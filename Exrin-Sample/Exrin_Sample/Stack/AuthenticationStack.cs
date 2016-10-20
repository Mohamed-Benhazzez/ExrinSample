using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin_Sample.Stack
{
    public class AuthenticationStack : BaseStack
    {
        public AuthenticationStack(IViewService viewService)
            : base(new NavigationContainer(new NavigationPage()), viewService, Stacks.Authentication)
        {
            ShowNavigationBar = false;
        }
        protected override void Map()
        {
            base.NavigationMap<PinView, PinViewModel>(nameof(Authentication.Pin));
            base.NavigationMap<LoginView, LoginViewModel>(nameof(Authentication.Login));
            base.NavigationMap<ResetView, ResetViewModel>(nameof(Authentication.Reset));
            base.NavigationMap<VerifyView, VerifyViewModel>(nameof(Authentication.Verify));
            base.NavigationMap<SplashView, SplashViewModel>(nameof(Authentication.Splash), true);
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
