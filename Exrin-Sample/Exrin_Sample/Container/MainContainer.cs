using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin_Sample.Container
{
    public class MainContainer : Exrin.Framework.ViewContainer, ISingleContainer
    {

        public AuthenticationViewContainer(AuthenticationStack stack): base(ViewContainers.Authentication.ToString(), stack.Proxy.NativeView)
        {
            Stack = stack;

        }

        public IStack Stack { get; set; }

    }
}
