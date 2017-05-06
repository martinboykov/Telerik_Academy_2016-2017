using System;
using System.Runtime.InteropServices;

class UsingAttributes
{
	[DllImport("user32.dll", EntryPoint = "MessageBox")]
	public static extern int ShowMessageBox(int hWnd,
		string text, string caption, int type);



    [Flags] // system.FlagsAttribute
    public enum FileAccess
    {
        Read =1,
        Write = 2,
        ReadWrite = Read|Write
    }



	static void Main()
	{
		ShowMessageBox(0, "Some text", "Some caption", 0);

        FileAccess fa = FileAccess.Read | FileAccess.Write | FileAccess.ReadWrite;
        Console.WriteLine(  fa);
	}
}
