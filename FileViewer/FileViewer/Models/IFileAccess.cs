using System;
using System.Collections.Generic;
using System.Text;

namespace FileViewer.Models
{
    // http://www.nuits.jp/entry/2016/09/11/230541 Prism for Xamarin.Forms入門　よりみち：DependencyService
    public interface IFileAccess
    {
        IFileContent ReadFile(string FileName);
    }
}
