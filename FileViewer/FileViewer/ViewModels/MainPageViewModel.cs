using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileViewer.ViewModels
{
    //http://www.nuits.jp/entry/master-detail-page-memo 【メモ】PrismでMasterDetailPageと付き合うコツ

    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> NavigateCommand { get; }
        public DelegateCommand<string> ShowMenu2Command { get; set; }
        public DelegateCommand<string> ShowPage2Command { get; set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

            NavigateCommand = new DelegateCommand<string>(async x => {
                await NavigationService.NavigateAsync("NavigationPage/" + x);
            });

            ShowPage2Command = new DelegateCommand<string>(async x => {
                await NavigationService.NavigateAsync(x);
            });
            ShowMenu2Command = new DelegateCommand<string>(async x => {
                await NavigationService.NavigateAsync(x);
            });
        }
    }
}
