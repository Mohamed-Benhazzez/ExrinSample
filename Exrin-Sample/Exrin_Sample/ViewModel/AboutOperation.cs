namespace ExrinSample.ViewModel
{
    using Abstraction.Enums;
    using Abstraction.Enums.Views;
    using Exrin.Abstraction;
    using Exrin.Framework;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class AboutOperation : IOperation
    {
        public AboutOperation()
        {
        }

        public Func<IList<IResult>, object, CancellationToken, Task> Function
        {
            get
            {
                return (results, parameter, token) =>
                {
                    Result result = new Result() { ResultAction = ResultType.Navigation, Arguments = new NavigationArgs() { Key = Main.About, StackType = Stack.Main } };
                   
                    results.Add(result);

                    return Task.FromResult(true);
                };
            }
        }

        public bool ChainedRollback { get; private set; } = false;

        public Func<Task> Rollback { get { return null; } }
    }
}