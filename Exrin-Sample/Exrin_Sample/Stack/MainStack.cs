using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin_Sample.Stack
{
    public class MainStack : BaseStack
    {

        public MainStack(IViewService viewService)
            : base(new NavigationContainer(new NavigationPage()), viewService, Stacks.Main)
        {
            ShowNavigationBar = false;
        }

        protected override void Map()
        {
            base.NavigationMap<MainView, MainViewModel>(nameof(Main.Main));
            base.NavigationMap<AboutView, AboutViewModel>(nameof(Main.About));
        }

        public override string NavigationStartKey
        {
            get
            {
                return nameof(Main.Main);
            }
        }

    }
}
