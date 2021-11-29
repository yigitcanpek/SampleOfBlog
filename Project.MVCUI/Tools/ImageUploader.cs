using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Tools
{
    public class ImageUploader
    {
        /*Needs to be refactoring*/
        public static string UploadImage(string serverPath,HttpPostedFileBase file)
        {
            if (file != null)
            {
                Guid uniqueName = Guid.NewGuid();

                string[] fileArray = file.FileName.Split('.');
                string extension = fileArray[fileArray.Length - 1].ToLower();
                string fileName = $"{uniqueName}.{extension}";

                if (extension == "jpg" || extension  ==  "gif" || extension == "jpeg")
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath+fileName)))
                    {
                        return "1";
                    }
                    string filepath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                    file.SaveAs(filepath);
                    return /*serverPath +*/ filepath;
                }
                
                return "Uygun Formatta Değil";
            }
            return "Resim Yok";
        }
    }
}