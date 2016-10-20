

namespace Exrin_Sample.Base
{
    public class BaseViewModel : Exrin.Framework.ViewModel
    {
        public BaseViewModel(IAuthModel authModel, IExrinContainer exrinContainer,
                             IVisualState visualState, string caller = nameof(BaseViewModel))
                             : base(exrinContainer, visualState, caller)
        { }
    }
}
