namespace ExrinSample.ViewModel
{
    using Abstraction.Model;
    using Exrin.Abstraction;
    using Base;
    using System.Threading.Tasks;
    using Exrin.Framework;

    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(IMainModel model, IExrinContainer exrinContainer)
            : base(exrinContainer, new MainVisualState(model))
        {
        }

        // Enjoy all these events, mapped into the ViewModel.

        // This page is about to be navigated to. Do anything before the page is pushed to the stack.
        // Will wait for this to return before the page is pushed to the stack.
        public override Task OnPreNavigate(object args, Args e)
        {
            return base.OnPreNavigate(args, e);
        }

        // When this page is displayed again because the page on top of it was popped from the stack
        public override Task OnBackNavigated(object args)
        {
            return base.OnBackNavigated(args);
        }

        // When the page has been forward navigated to
        public override Task OnNavigated(object args)
        {
            return base.OnNavigated(args);
        }

        // When the page this is mapped to is popped from the Navigation Stack.
        public override void OnPopped()
        {
            base.OnPopped();
        }

        // When the page this is mapped to has its OnAppearing event called
        public override void OnAppearing()
        {
            base.OnAppearing();
        }

        // When the page this is mapped to has the disappearing event called
        public override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        // When the hardware back button is pressed
        public override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

        public IRelayCommand AboutCommand
        {
            get
            {
                return GetCommand(() =>
                {
                    return Execution.ViewModelExecute(new AboutOperation());
                });
            }
        }

        public IRelayCommand LogoutCommand
        {
            get
            {
                return GetCommand(() =>
                {
                    return Execution.ViewModelExecute(new LogoutOperation());
                });
            }
        }
    }
}
