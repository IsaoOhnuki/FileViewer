using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FileViewer.Models;
using Prism.Mvvm;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileViewer.Droid.Models.FileAccess_Android))]
namespace FileViewer.Droid.Models
{
    public class FileAccess_Android : BindableBase, IFileAccess
    {
        private Activity activity;
        public Activity Activity
        {
            get { return Activity; }
            private set
            {
                SetProperty(ref activity, value);
            }
        }

        //public FileAccess_Android(Activity activity)
        //{
        //    Activity = activity;
        //}

        public IFileContent ReadFile(string FileName)
        {
            FileContent_Android fileContent = new FileContent_Android();

            Intent intent = new Intent(Intent.ActionGetContent);
            intent.SetType("file/*");

            Activity.StartActivityForResult(intent, 0);

            return fileContent;
        }
    }
}