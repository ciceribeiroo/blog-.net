﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Data.FileManager
{
    public class FileManager : IFileManager
    {
        private string _imagePath;

        public FileManager(IConfiguration config)
        {
            _imagePath = config["Path:Images"];
        }

        public FileStream ImageStream(string image)
        {
            return new FileStream(Path.Combine(_imagePath, image), FileMode.Open, FileAccess.ReadWrite);
        }

        public async Task<string> SaveImage(IFormFile image)
        {
                try
                {
                    var save_path = Path.Combine(_imagePath);
                    if (!Directory.Exists(_imagePath))
                    {
                        Directory.CreateDirectory(save_path);
                    }

                    var mime = image.FileName.Substring(image.FileName.LastIndexOf('.'));
                    var fileName = $"img_{DateTime.Now:dd-MM-yyyy-HH-mm-ss}{mime}";

                    using (var fileStream = new FileStream(Path.Combine(save_path, fileName), FileMode.Create))
                    {
                        await image.CopyToAsync(fileStream);
                    }
                    return fileName;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return "Error";
                }
        }
    }
}
