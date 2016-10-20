

namespace Exrin_Sample.Container
{
    public class AuthenticationContainer : Exrin.Framework.ViewContainer, ISingleContainer
    {

        public AuthenticationViewContainer(AuthenticationStack stack): base(ViewContainers.Authentication.ToString(), stack.Proxy.NativeView)
        {
            Stack = stack;

        }

        public IStack Stack { get; set; }

    }
}
