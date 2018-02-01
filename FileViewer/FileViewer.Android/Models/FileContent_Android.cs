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
using Xamarin.Forms;

[assembly: Dependency(typeof(FileViewer.Droid.Models.FileContent_Android))]
namespace FileViewer.Droid.Models
{
    public class FileContent_Android : IFileContent
    {
        public string FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FileBody { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}