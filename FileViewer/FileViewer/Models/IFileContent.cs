using System;
using System.Collections.Generic;
using System.Text;

namespace FileViewer.Models
{
    public interface IFileContent
    {
        string FileName { get; set; }
        string FileBody { get; set; }
    }
}
