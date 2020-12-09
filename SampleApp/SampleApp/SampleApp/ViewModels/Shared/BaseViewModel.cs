using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.ViewModels.Shared
{
  public  class BaseViewModel: ExtendedBindableObject
    {
    }
    public enum TabType
    {
        Home,
        CookNow,
        Plan,
        Learn,
        Shop
    }
}
