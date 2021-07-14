using Prism.Mvvm;
using Prism.Regions;
using WPFApp.Views;

namespace WPFApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        readonly IRegionManager _regionManager;
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(LoginView));
        }

    }
}
