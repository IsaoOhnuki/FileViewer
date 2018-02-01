using FileViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileViewer.UWP.Models.FileContent_UWP))]
namespace FileViewer.UWP.Models
{
    public class FileContent_UWP : IFileContent
    {
        public string FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FileBody { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
