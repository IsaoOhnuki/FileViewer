using FileViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileViewer.UWP.Models.FileAccess_UWP))]
namespace FileViewer.UWP.Models
{
    public class FileAccess_UWP : IFileAccess
    {
        public IFileContent ReadFile(string FileName)
        {
            throw new NotImplementedException();
        }
    }
}
