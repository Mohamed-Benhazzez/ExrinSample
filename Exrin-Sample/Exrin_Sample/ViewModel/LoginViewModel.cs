using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin_Sample.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IAuthModel _model;
        public LoginViewModel(IAuthModel model, IExrinContainer exrinContainer) :
           base(model, exrinContainer, new LoginVisualState(model))
        {
            _model = model;
        }

        public IRelayCommand LoginCommand
        {
            get
            {
                return GetCommand(() =>
                {
                    return Execution.ViewModelExecute(new LoginOperation(AuthModel, (LoginVisualState)VisualState, _resourceContainer));
                });
            }
        }

    }
}
