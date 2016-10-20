namespace ExrinSample.Base
{
    using Exrin.Abstraction;

    public class BaseViewModel : Exrin.Framework.ViewModel
    {
        public BaseViewModel(IExrinContainer exrinContainer,
                             IVisualState visualState, string caller = nameof(BaseViewModel))
                             : base(exrinContainer, visualState, caller)
        { }
    }
}
