using FileViewer.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FileViewer.ViewModels
{
	public class ViewPage2ViewModel : ViewModelBase
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public DelegateCommand SaveCommand { get; set; }

        public ViewPage2ViewModel(INavigationService navigationService)
            : base (navigationService)
        {
            Title = "ViewPage2";

            SaveCommand = new DelegateCommand(async () => {
                StorageIO io = new StorageIO("", "test.txt");
                await io.SaveTextAsync(Text);
            });
        }

        public override async void OnNavigatedToAsync(NavigationParameters parameters)
        {
            base.OnNavigatedToAsync(parameters);

            StorageIO io = new StorageIO("", "test.txt");
            Text = await io.LoadTextAsync();
        }
    }
}
