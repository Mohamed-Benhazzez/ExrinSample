namespace ExrinSample.ViewModel
{
    using Abstraction.Enums;
    using Abstraction.Enums.Views;
    using Abstraction.Model;
    using Exrin.Abstraction;
    using Exrin.Framework;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class LoginOperation : IOperation
    {
        private readonly IAuthModel _authModel;

        public LoginOperation(IAuthModel authModel)
        {
            _authModel = authModel;
        }

        public Func<IList<IResult>, object, CancellationToken, Task> Function
        {
            get
            {
                return async (results, parameter, token) =>
                {
                    Result result = null;

                    if (await _authModel.Login())
                        result = new Result() { ResultAction = ResultType.Navigation, Arguments = new NavigationArgs() { Key = Main.Main, StackType = Stack.Main } };
                    else
                        result = new Result() { ResultAction = ResultType.Display, Arguments = new DisplayArgs() { Message = "Login was unsuccessful" } };
                    
                    results.Add(result);
                };
            }
        }

        public bool ChainedRollback { get; private set; } = false;

        public Func<Task> Rollback { get { return null; } }
    }
}
