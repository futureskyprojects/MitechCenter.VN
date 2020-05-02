using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using System;

namespace MitechCenter.vn.Utils
{
    public static class ByteArrayToFile
    {
        public static bool write(string filePath, byte[] byteArray)
        {
            string dir = Path.GetPathRoot(filePath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            try
            {
                using (var fs = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }
    }
}