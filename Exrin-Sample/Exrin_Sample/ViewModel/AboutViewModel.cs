namespace ExrinSample.ViewModel
{
    using Abstraction.Model;
    using Exrin.Abstraction;
    using Base;

    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(IMainModel model, IExrinContainer exrinContainer) 
            : base(exrinContainer, new AboutVisualState(model))
        {            
        }
    }
}
