using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Data.FileManager
{
    public interface IFileManager
    {
        FileStream ImageStream(string image);
        Task<string> SaveImage(IFormFile file);
    }
}
