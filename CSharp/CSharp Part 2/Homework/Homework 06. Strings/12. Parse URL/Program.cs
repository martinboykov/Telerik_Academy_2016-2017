using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class Program
    {
        static string ExtractProtocol(string fileName)
        {
            string extension = "";
            int dotIndex = fileName.IndexOf(':');
            extension = fileName.Substring(0, dotIndex - 0);
            return extension;
        }

        static string ExtractServer(string fileName)
        {
            string extension = "";
            int start = fileName.IndexOf("//");
            int end = fileName.IndexOf("/", start + 2);
            extension = fileName.Substring(start + 2, end - start - 2);

            return extension;
        }

        static string ExtractRecource(string fileName)
        {
            string extension = "";
            int start = fileName.IndexOf("//");
            int end = fileName.IndexOf("/", start + 2);
            extension = fileName.Substring(end);

            return extension;
        }

        static void Main()
        {
            string fileName = Console.ReadLine();//@"https://github.com/gentoo/gentoo.git";
            //Console.WriteLine("Full file name: {0}", fileName);

            string protocol = ExtractProtocol(fileName);
            Console.WriteLine("[protocol] = {0}", protocol); 

            string server = ExtractServer(fileName);
            Console.WriteLine("[server] = {0}", server); 

            string recource = ExtractRecource(fileName);
            Console.WriteLine("[resource] = {0}", recource); 
        }
    }
}
//http://telerikacademy.com/Courses/Courses/Details/212
// Path.AltDirectorySeparatorChar=  /
// Path.DirectorySeparatorChar=     \
// Path.PathSeparator=              ;
// Path.VolumeSeparatorChar=        :




//static string ExtractExtension(string fileName)
//{
//    string extension = "";
//    int dotIndex = fileName.LastIndexOf('.');
//    if (dotIndex != -1)
//    {
//        extension = fileName.Substring(dotIndex + 1);
//    }
//    return extension;
//}

//static string ExtractFileName(string path)  //C:\Pics\Rila2005.jpg  -->   Rila2005.jpg
//{
//    char dirSlash = Path.AltDirectorySeparatorChar; // separates by \
//    int slashIndex = path.LastIndexOf(dirSlash);
//    string fileName = path.Substring(slashIndex + 1);
//    return fileName;
//}

//static string ExtractPath(string fullFileName) //C:\Pics\Rila2005.jpg  -->   C:\Pics
//{
//    char dirSlash = Path.AltDirectorySeparatorChar;// separates by \
//    int slashIndex = fullFileName.LastIndexOf(dirSlash);
//    string path = "";
//    if (slashIndex != -1)
//    {
//        path = fullFileName.Substring(0, slashIndex);
//    }
//    return path;
//}


