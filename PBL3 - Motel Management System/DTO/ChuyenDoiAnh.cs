using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.DTO
{
    public class ChuyenDoiAnh
    {
        public static byte[] ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms,format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public static Image Base64ToImage(byte[] imageBytes) {
            MemoryStream ms = new MemoryStream(imageBytes,0,imageBytes.Length);
            ms.Write(imageBytes,0,imageBytes.Length);
            Image image = Image.FromStream(ms,true);
            return image;
        
        
        }

    }
}
