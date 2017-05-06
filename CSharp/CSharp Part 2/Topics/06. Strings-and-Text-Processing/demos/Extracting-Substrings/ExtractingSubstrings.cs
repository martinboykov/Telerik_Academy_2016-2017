using System;
using System.IO;

class ExtractingSubstrings
{
    static string ExtractExtension(string fileName)
    {
        string extension = "";
        int dotIndex = fileName.LastIndexOf('.');
        if (dotIndex != -1)
        {
            extension = fileName.Substring(dotIndex + 1);
        }
        return extension;
    }

    static string ExtractFileName(string path)
    {
        char dirSlash = Path.DirectorySeparatorChar; // separates by \
        int slashIndex = path.LastIndexOf(dirSlash);
        string fileName = path.Substring(slashIndex + 1);
        return fileName;
    }

    static string ExtractPath(string fullFileName)
    {
        char dirSlash = Path.DirectorySeparatorChar;// separates by \
        int slashIndex = fullFileName.LastIndexOf(dirSlash);
        string path = "";
        if (slashIndex != -1)
        {
            path = fullFileName.Substring(0, slashIndex);
        }
        return path;
    }

    static void Main()
    {
        string fileName = @"C:\Pics\Rila2005.jpg";
        Console.WriteLine("Full file name: {0}", fileName);

        string extension = ExtractExtension(fileName);
        Console.WriteLine("File extenson: {0}", extension); // jpg

        string fileNameOnly = ExtractFileName(fileName);
        Console.WriteLine("File name only: {0}", fileNameOnly); //Rila2005.jpg

        string pathOnly = ExtractPath(fileName);
        Console.WriteLine("Path: {0}", pathOnly); // C:\Pics



    }
}

//http://www.dotnetperls.com/path
//An example.Here we extract parts of file name paths.The Path class is helpful.We access it by adding "using System.IO" at the top of a file.
//Next:
//As an introduction, we see a short console program that shows four Path methods.
//Here:
//We take the extension of the file, the actual file name, the file name without the extension, and the path root.
//Root:
//The path root is "C:\\", with the trailing separator, even when the file is nested in many folders.


//Based on: .NET 4.5

//C# program that uses Path methods

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "C:\\stagelist.txt";

//        string extension = Path.GetExtension(path);
//        string filename = Path.GetFileName(path);
//        string filenameNoExtension = Path.GetFileNameWithoutExtension(path);
//        string root = Path.GetPathRoot(path);

//        Console.WriteLine("{0}\n{1}\n{2}\n{3}",
//            extension,
//            filename,
//            filenameNoExtension,
//            root);
//    }
//}

//Output

//.txt
//stagelist.txt
//stagelist
//C:\

//Methods.Here we see the results of Path methods on various inputs.Sometimes the methods handle invalid characters as expected.Sometimes they do not.
//Extensions:
//GetFileNameWithoutExtension will return the entire file name if there is no extension on the file.
//Directory:
//Path.GetDirectoryName returns the entire string except the file name and the slash before it.
//URLs:
//For URLs the slashes are reversed into Windows-style slashes. This is not desirable with virtual paths or URLs.
//Tip:
//The volume such as "C:\" is part of the directory name. The directory name doesn't include the trailing slash "\".
//C# program that tests Path class

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string[] pages = new string[]
//        {
//        "cat.aspx",
//        "really-long-page.aspx",
//        "test.aspx",
//        "invalid-page",
//        "something-else.aspx",
//        "Content/Rat.aspx",
//        "http://dotnetperls.com/Cat/Mouse.aspx",
//        "C:\\Windows\\File.txt",
//        "C:\\Word-2007.docx"
//        };
//        foreach (string page in pages)
//        {
//            string name = Path.GetFileName(page);
//            string nameKey = Path.GetFileNameWithoutExtension(page);
//            string directory = Path.GetDirectoryName(page);
//            //
//            // Display the Path strings we extracted.
//            //
//            Console.WriteLine("{0}, {1}, {2}, {3}",
//            page, name, nameKey, directory);
//        }
//    }
//}

//Output: reformatted

//Input:                       cat.aspx
//GetFileName:                 cat.aspx
//GetFileNameWithoutExtension: cat
//GetDirectoryName:            -

//Input:                       really-long-page.aspx
//GetFileName:                 really-long-page.aspx
//GetFileNameWithoutExtension: really-long-page
//GetDirectoryName:            -

//Input:                       test.aspx
//GetFileName:                 test.aspx
//GetFileNameWithoutExtension: test
//GetDirectoryName:            -

//Input:                       invalid-page
//GetFileName:                 invalid-page
//GetFileNameWithoutExtension: invalid-page
//GetDirectoryName:            -

//Input:                       Content/Rat.aspx
//GetFileName:                 Rat.aspx
//GetFileNameWithoutExtension: Rat
//GetDirectoryName:            Content

//Input:                       http://dotnetperls.com/Cat/Mouse.aspx
//GetFileName:                 Mouse.aspx
//GetFileNameWithoutExtension: Mouse
//GetDirectoryName:            http:\dotnetperls.com\Cat

//Input:                       C:\Windows\File.txt
//GetFileName:                 File.txt
//GetFileNameWithoutExtension: File
//GetDirectoryName:            C:\Windows

//Input:                       C:\Word-2007.docx
//GetFileName:                 Word-2007.docx
//GetFileNameWithoutExtension: Word-2007
//GetDirectoryName:            C:\

//Syntax.In path literals, we must use two backslashes "\\" unless we use verbatim string syntax.A verbatim string uses the prefix character "@". In it, only one backslash is needed.
//String Literal
//C# program that uses verbatim string

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        // ... Verbatim string syntax.
//        string value = @"C:\directory\word.txt";
//        Console.WriteLine(Path.GetFileName(value));
//    }
//}

//Output

//word.txt

//Extensions.We can get an extension with GetExtension.We can change an extension with ChangeExtension.The method names are obvious.
//Path.GetExtension
//Path.ChangeExtension
//Note:
//GetExtension handles extensions of four letters. It also handles the case where a file name has more than one period in it.
//Here:
//This program briefly tests GetExtension.The period is part of the extension string returned.
//C# program that uses GetExtension

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        // ... Path values.
//        string value1 = @"C:\perls\word.txt";
//        string value2 = @"C:\file.excel.dots.xlsx";

//        // ... Get extensions.
//        string ext1 = Path.GetExtension(value1);
//        string ext2 = Path.GetExtension(value2);
//        Console.WriteLine(ext1);
//        Console.WriteLine(ext2);
//    }
//}

//Output

//.txt
//.xlsx

//Combine.This is a useful method.But there are edge cases it cannot solve. Here we combine the folder "Content\\" with the file name "file.txt."
//Note:
//Path.Combine handles certain cases where we have directory separators in different positions.
//C# program that uses Combine

//using System;

//class Program
//{
//    static void Main()
//    {
//        //
//        // Combine two path parts.
//        //
//        string path1 = System.IO.Path.Combine("Content", "file.txt");
//        Console.WriteLine(path1);

//        //
//        // Same as above but with a trailing separator.
//        //
//        string path2 = System.IO.Path.Combine("Content\\", "file.txt");
//        Console.WriteLine(path2);
//    }
//}

//Output

//Content\file.txt
//Content\file.txt

//System.IO.Path.We can refer to the Path class with "System.IO.Path" instead of including the namespace.This may be useful in source files that are not file-IO oriented.
//Tip:
//When we have to add the character "\" to a non-verbatim C# string literal, we must use \\ (two backslashes).
//Note:
//C# uses the backslash to escape characters, so we must escape it. Please see the syntax section.

//ASP.NET.URLs and virtual paths are used in ASP.NET websites. The Path class does not work well for these paths.For each ASP.NET request, there is a Request.PhysicalPath.
//And:
//The Request.PhysicalPath value is a Windows-style path. It works well with the Path class.
//Code that tests extensions: C#

////
//// This could be in your Global.asax file or in an ASPX page.
//// It gets the physical path.
////
//string physical = Request.PhysicalPath;
////
//// Here we see if we are handling an ASPX file.
////
//if (Path.GetExtension(physical) == ".aspx")
//{
//    //
//    // Get the file name without an extension.
//    //
//    string key = Path.GetFileNameWithoutExtension(physical);
//}

//Random.Sometimes programs use random file names.If we need to write a temp file and the path is not important, use Path.GetRandomFileName.We can also use this for random strings.
//Path.GetRandomFileName
//Tip:
//Here is the random string it just now yielded: zd4xcjmo.u4p.No file of that name likely exists.

//Separators.There are two properties for separators.These help us develop code that is understandable.It is easier to understand Path.DirectorySeparatorChar than some chars.
//Next:
//I looked at these two properties in the debugger. The results of the properties are shown below.
//Path.DirectorySeparatorChar result

//"\\"


//Path.AltDirectorySeparatorChar result

//"/"


//GetTempPath.This returns temporary file names.They point to a "Temp" folder in the User folder.This program shows the result of GetTempPath.
//Note:
//GetTempPath() has a separator character on the end.Path.GetDirectoryName meanwhile does not.
//Note 2:
//With Path.Combine, we can reliably concatenate a file name with the temporary path received.
//C# program that uses GetTempPath

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string temp = Path.GetTempPath();
//        Console.WriteLine(temp);

//        string random = Path.GetRandomFileName();
//        Console.WriteLine(random);

//        string both = Path.Combine(temp, random);
//        Console.WriteLine(both);
//    }
//}

//Output

//C:\Users\Sam2\AppData\Local\Temp\
//x4y3yspj.cgo
//C:\Users\Sam2\AppData\Local\Temp\x4y3yspj.cgo

//Cache.The result of GetTempPath is usually constant throughout program execution.It is safe to cache it. This eliminates allocations and external calls used by Path.GetTempPath.
//Invalid chars. A program should expect that invalid characters will be encountered. We need to quickly detect invalid path characters.
//So:
//We can use the Path.GetInvalidFileNameChars and Path.GetInvalidPathChars methods.
//Dictionary:
//We can use the character arrays returned by Path.GetInvalidFileNameChars and Path.GetInvalidPathChars with a Dictionary.
//ToDictionary
//C# that gets invalid characters

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // First, we build a Dictionary of invalid characters.
//        var dict = GetInvalidFileNameChars();
//        // Next, we test the dictionary to see if the asterisk (star) is valid.
//        if (dict.ContainsKey('*'))
//        {
//            // This will run.
//            // ... The star is in the Dictionary.
//            Console.WriteLine("* is an invalid char");
//        }
//    }

//    /// <summary>
//    /// Get a Dictionary of the invalid file name characters.
//    /// </summary>
//    static Dictionary<char, bool> GetInvalidFileNameChars()
//    {
//        // This method uses lambda expressions with ToDictionary.
//        return Path.GetInvalidFileNameChars().ToDictionary(c => c, c => true);
//    }
//}

//Output

//* is an invalid char

//GetDirectoryName.This method is useful.We often need to get the directory name from a string path. I provide some benchmarks of Path.GetDirectoryName.
//Path.GetDirectoryName

//Certain paths.Path is best used for certain types of paths. Web addresses are considered paths, but in the.NET Framework they are URIs.The Uri type is best for them.
//Warning:
//Path works poorly for URLs or virtual paths in ASP.NET.It has inconsistencies with directory names.

//File lists. Often we need lists of files in certain directories. We show how to get recursive lists of files by traversing subdirectories.
//Directory.GetFiles
//Recursive File List

//Custom methods. Sometimes additional logic is needed.For example, we can store a list of reserved file names.Then we can test to see if a file name is reserved.
//Reserved Filenames
//Path Exists

//In optimization, we must be careful not to change the functionality in ways that are detrimental. Path methods contain steps for special cases. We can remove these branches.
//Here:
//We developed a custom implementation of the Path GetFileNameWithoutExtension method.
//Info:
//The routine is over three times faster but has slight behavioral differences.The speed helps when this method is often called.
//C# that implements GetFileNameWithoutExtension

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string[] array =
//        {
//        @"C:\test\ok.txt",
//        @"http://example.com/Content/Array.aspx",
//        @"http://example.com/Content/Something/Ok.aspx",
//        @"http://example.com///.",
//        "",
//        "/_.",
//        "/Content/Array",
//        "Array",
//        @"test\"
//    };
//        foreach (string value in array)
//        {
//            Console.WriteLine("{0} = {1}",
//            GetFileNameWithoutExtensionFast(value),
//            Path.GetFileNameWithoutExtension(value));
//        }
//    }

//    public static string GetFileNameWithoutExtensionFast(string value)
//    {
//        // Find last available character.
//        // ... This is either last index or last index before last period.
//        int lastIndex = value.Length - 1;
//        for (int i = lastIndex; i >= 1; i--)
//        {
//            if (value[i] == '.')
//            {
//                lastIndex = i - 1;
//                break;
//            }
//        }
//        // Find first available character.
//        // ... Is either first character or first character after closest /
//        // ... or \ character after last index.
//        int firstIndex = 0;
//        for (int i = lastIndex - 1; i >= 0; i--)
//        {
//            switch (value[i])
//            {
//                case '/':
//                case '\\':
//                    {
//                        firstIndex = i + 1;
//                        goto End;
//                    }
//            }
//        }
//        End:
//        // Return substring.
//        return value.Substring(firstIndex, (lastIndex - firstIndex + 1));
//    }
//}

//Output

//ok = ok
//Array = Array
//Ok = Ok
/// =
// =
//_ = _
//Array = Array
//Array = Array
//test\ =

//Results

//Path.GetFileNameWithoutExtension: 1064 ns
//GetFileNameWithoutExtensionFast:   321 ns

//Uri. This type supports website addresses.It contains helper methods we can use to specify addresses of websites. If a path starts with "http", it is a better idea to use Uri.
//Uri
//UriBuilder

//A summary. The Path class provides Windows-native path manipulations and tests.It is ideal for file names, directory names, relative paths and file name extensions.
//Path has limitations. It does not work well with Internet addresses—use Uri instead.These examples hopefully put us on the path to good file path handling.
