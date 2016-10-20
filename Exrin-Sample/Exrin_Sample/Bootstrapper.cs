namespace ExrinSample
{
    using Exrin.Abstraction;
    using Proxy;
    using System;
    using Xamarin.Forms;

    public class Bootstrapper : Exrin.Framework.Bootstrapper
    {
        private static Bootstrapper _instance = null;

        public Bootstrapper(IInjectionProxy injection, Action<object> setRoot)
            : base(injection, setRoot) { }

        public static Bootstrapper GetInstance()
        {
            if (_instance == null)
                _instance = new Bootstrapper(new Injection(),
                                            (view) =>
                                            {
                                                Application.Current.MainPage = view as Page;
                                            });

            return _instance;
        }
    }
}
