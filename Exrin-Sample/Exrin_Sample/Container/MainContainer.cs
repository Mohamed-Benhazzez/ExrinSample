namespace ExrinSample.Container
{
    using Exrin.Abstraction;
    using Stacks;

    public class MainContainer : Exrin.Framework.ViewContainer, ISingleContainer
    {

        public MainContainer(MainStack stack)
            : base(Abstraction.Enums.Container.Main.ToString(), stack.Proxy.NativeView)
        {
            Stack = stack;
        }

        public IStack Stack { get; set; }

    }
}
