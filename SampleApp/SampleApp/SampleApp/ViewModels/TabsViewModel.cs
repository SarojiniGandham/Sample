using SampleApp.ViewModels.Shared;
using SampleApp.Views;
using SampleApp.Views.Tabs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleApp.ViewModels
{
    public class TabsViewModel : BaseViewModel
    {
        // TabType TabItem;
        HomeView homeTab;
        PlansView plansViewTab;
        CookNowView cookNowViewTab;
        LearnView learnViewTab;
        ShopView shopViewTab;
        public TabsViewModel()
        {
            PageContent = new ContentView();
            DisplayPageSetup(GlobalConstants.HomeStyleId);
        }
        private bool _tabsVisibility;

        public bool TabsVisibility
        {
            get { return _tabsVisibility; }
            set
            {
                _tabsVisibility = value;
                RaisePropertyChanged(() => TabsVisibility);
            }
        }

        #region Properties
      
        private ContentView _pageContent;
        public ContentView PageContent
        {
            get { return _pageContent; }
            set
            {
                _pageContent = value;
                RaisePropertyChanged(() => PageContent);
            }
        }
        private ImageSource _homeIcon;
        public ImageSource HomeIcon
        {
            get { return _homeIcon; }
            set
            {
                _homeIcon = value;
                RaisePropertyChanged(() => HomeIcon);
            }
        }
        private ImageSource _plansIcon;
        public ImageSource PlansIcon
        {
            get { return _plansIcon; }
            set
            {
                _plansIcon = value;
                RaisePropertyChanged(() => PlansIcon);
            }
        }
        private ImageSource _cookNowIcon;
        public ImageSource CookNowIcon
        {
            get { return _cookNowIcon; }
            set
            {
                _cookNowIcon = value;
                RaisePropertyChanged(() => CookNowIcon);
            }
        }
        private ImageSource _learnIcon;
        public ImageSource LearnIcon
        {
            get { return _learnIcon; }
            set
            {
                _learnIcon = value;
                RaisePropertyChanged(() => LearnIcon);
            }
        }
        private ImageSource _shopIcon;
        public ImageSource ShopIcon
        {
            get { return _shopIcon; }
            set
            {
                _shopIcon = value;
                RaisePropertyChanged(() => ShopIcon);
            }
        }
       
       
        private TabType _currentActiveTab;
        public TabType CurrentActiveTab
        {
            get { return _currentActiveTab; }
            set
            {
                _currentActiveTab = value;
                RaisePropertyChanged(() => CurrentActiveTab);
            }
        }
        #endregion
        #region Commands
        public ICommand DisplayCommand => new Command<string>(styleId => DisplayPageSetup(styleId));
/// <summary>
/// It is using for tabs apperaing
/// </summary>
        public void ViewAppearing()
        {
            switch (CurrentActiveTab)
            {
                case TabType.Home:
                    if (homeTab != null)
                    {
                        homeTab.TabAppearing();
                    }
                    break;
                case TabType.CookNow:
                    if (cookNowViewTab != null)
                    {
                        cookNowViewTab.TabAppearing();
                    }
                    break;
                case TabType.Plan:
                    if (plansViewTab != null)
                    {
                        plansViewTab.TabAppearing();
                    }
                    break;
                case TabType.Shop:
                    if (shopViewTab != null)
                    {
                        shopViewTab.TabAppearing();
                    }
                    break;
                case TabType.Learn:
                    if (learnViewTab != null)
                    {
                        learnViewTab.TabAppearing();
                    }
                    break;
                default:
                    break;
            }
        }
        public void ViewDisappearing()
        {
        }
        /// <summary>
        /// Load particular page and changes the tab icons,color
        /// </summary>
        /// <param name="styleId"></param>
        private void DisplayPageSetup(string styleId)
        {
            //Resetting all the  images as UnSelected
            HomeIcon = "ic_home";
            PlansIcon = "ic_plan";
            ShopIcon = "ic_store";
            CookNowIcon = "ic_cooknow";
            LearnIcon = "ic_learn";
            if (styleId.Equals(GlobalConstants.HomeStyleId))
            {
                CurrentActiveTab = TabType.Home;
                if (homeTab == null)
                {
                    homeTab = new HomeView();
                }
                PageContent.Content = null;
                PageContent.Content = homeTab.Content;
                HomeIcon = "ic_home";//Set icon here
            }
            else if (styleId.Equals(GlobalConstants.PlansStyle))
            {
                CurrentActiveTab = TabType.Plan;
                if (plansViewTab == null)
                {
                    plansViewTab = new PlansView();
                }
                PageContent.Content = null;
                PageContent.Content = plansViewTab.Content;
                PlansIcon = "ic_plan";//Set icon here
            }
            else if (styleId.Equals(GlobalConstants.CookNowStyle))
            {
                CurrentActiveTab = TabType.CookNow;
                if (cookNowViewTab == null)
                {
                    cookNowViewTab = new CookNowView();
                }
                PageContent.Content = null;
                PageContent.Content = cookNowViewTab.Content;
                CookNowIcon = "ic_cooknow";//Set icon here
            }
            else if (styleId.Equals(GlobalConstants.LearnStyle))
            {
                CurrentActiveTab = TabType.Learn;
                if (learnViewTab == null)
                {
                    learnViewTab = new LearnView();
                }
                PageContent.Content = null;
                PageContent.Content = learnViewTab.Content;
                LearnIcon = "ic_learn";//Set icon here
            }
            else 
            {
                CurrentActiveTab = TabType.Shop;
                if (shopViewTab == null)
                {
                    shopViewTab = new ShopView();
                }
                PageContent.Content = null;
                PageContent.Content = shopViewTab.Content;
                ShopIcon = "ic_store";//Set icon here
            }
            
        }
        #endregion
    }
}
