using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Results;

namespace Core.Utilities.Helpers
{
    //TepmFileName:Diskte benzersiz olarak adlandırılmış, sıfır baytlık geçici bir dosya oluşturur ve bu dosyanın tam yolunu döndürür
    // Sınıfının üyeleri, Path bir dosya adı uzantısının bir yolun parçası olup olmadığını belirleme ve 
    //iki dizeyi tek yol adında birleştirme gibi genel işlemleri hızlı ve kolay bir şekilde gerçekleştirmenize olanak tanır.
    public class FileHelper
    {
        //sourcepath : kaynak yol
      public static  string directory = Environment.CurrentDirectory + @"\wwwroot\";
        public static string path = @"images\";
        public static string Add(IFormFile file)
        {
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var extension = Path.GetExtension(file.FileName);
            var newFileName = Guid.NewGuid().ToString("N") + extension;

            File.Move(sourcepath,directory+path+newFileName);
            return (path+newFileName).Replace("\\","/");
        }
        public static IResult Delete(string oldPath)
        {
            path = (directory+oldPath).Replace("/", "\\");
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResults(exception.Message);
            }

            return new SuccessResult();
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var newFileName = Guid.NewGuid().ToString("N") + extension;
           
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(directory+path+newFileName, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return (path + newFileName).Replace("\\", "/");
        }
       
    }
}
