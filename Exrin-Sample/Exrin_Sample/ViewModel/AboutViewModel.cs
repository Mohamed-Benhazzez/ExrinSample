namespace ExrinSample.ViewModel
{
    using Abstraction.Model;
    using Exrin.Abstraction;
    using Base;
    using System.Collections.Generic;

    public class AboutViewModel : BaseViewModel
    {
       
        public AboutViewModel(IMainModel model, IExrinContainer exrinContainer) 
            : base(exrinContainer, new AboutVisualState(model))
        {
        }

        //public override async void OnAppearing()
        //{
        //    // Testing a SilentPop when coming to this page
        //    base.OnAppearing();
        //    await _navigationService.SilentPop(Abstraction.Enums.Stack.Main, new List<string>() { Abstraction.Enums.Views.Main.Main.ToString() });
        //}

    }
}
