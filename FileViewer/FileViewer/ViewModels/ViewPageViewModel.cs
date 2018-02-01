using FileViewer.Models;
using PCLStorage;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FileViewer.ViewModels
{
	public class ViewPageViewModel : ViewModelBase
    {
        IFileAccess fileAccess;

        public DelegateCommand OpenCommand { get; set; }
        public DelegateCommand ShowMPCommand { get; set; }
        private string text;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
        public ViewPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.fileAccess = DependencyService.Get<IFileAccess>(DependencyFetchTarget.NewInstance);

            Title = "FileName";
            Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20\r\n\r\n22\r\n23\r\n24\r\n25\r\n26\r\n27\r\n28\r\n29\r\n30\r\n\r\n32\r\n33\r\n34\r\n35\r\n";

            OpenCommand = new DelegateCommand(async () =>
            {
                // Androidの場合、documentsディレクトリになるはず
                var localFolder = PCLStorage.FileSystem.Current.LocalStorage;

                var files = await localFolder.GetFilesAsync();
                foreach (var file in files)
                {
                    System.Diagnostics.Debug.WriteLine(file.Name);
                }

                var firstFile = files.FirstOrDefault();
                if (firstFile != null)
                {
                    using (var stream = firstFile.OpenAsync(FileAccess.Read).Result)
                    {
                        // ファイルを読み込んで何かする
                    }
                }
            });
            ShowMPCommand = new DelegateCommand(async() => {
                await NavigationService.NavigateAsync("ViewPage2");
            });
        }
    }
}
