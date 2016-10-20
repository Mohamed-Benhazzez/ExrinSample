namespace ExrinSample.Container
{
    using Exrin.Abstraction;
    using Stacks;

    public class AuthenticationContainer : Exrin.Framework.ViewContainer, ISingleContainer
    {

        public AuthenticationContainer(AuthenticationStack stack)
            : base(Abstraction.Enums.Container.Authentication.ToString(), stack.Proxy.NativeView)
        {
            Stack = stack;

        }

        public IStack Stack { get; set; }

    }
}
