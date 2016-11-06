namespace ExrinSample.ViewModel
{
    using Abstraction.Model;
    using Base;
    using Exrin.Abstraction;
    using Exrin.Framework;

    public class LoginViewModel : BaseViewModel
    {
        private readonly IAuthModel _model;
     
        public LoginViewModel(IAuthModel model, IExrinContainer exrinContainer) :
           base(exrinContainer, new LoginVisualState(model))
        {
            _model = model;
        }

        public IRelayCommand LoginCommand
        {
            get
            {
                return GetCommand(() =>
                {
                    return Execution.ViewModelExecute(new LoginOperation(_model));
                });
            }
        }

    }
}
