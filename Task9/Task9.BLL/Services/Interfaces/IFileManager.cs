using System.IO;
using System.Windows.Forms;

namespace Task9.BLL.Services.Interfaces
{
	public interface IFileManager
	{
		void SaveFile(string text, FileDialog saveDlg);
		string OpenFile(FileDialog openDlg);
		string Reader(Stream sourceFile);
		void Writer(Stream sourceFile, string text);
	}
}
