using System.IO;
using System.Windows.Forms;
using Task9.BLL.Services.Interfaces;

namespace Task9.BLL.Services
{
	public class FileManager: IFileManager
	{
		public void SaveFile(string text, FileDialog saveDlg)
		{
			var sourceFile = new FileStream(
				saveDlg.FileName,
				FileMode.OpenOrCreate,
				FileAccess.Write);

			Writer(sourceFile, text);
		}

		public void Writer(Stream sourceFile, string text)
		{
			var sw = new StreamWriter(sourceFile);

			try
			{
				sw.Write(text);
			}
			finally
			{
				sw.Close();
				sourceFile.Close();
			}
		}

		public string OpenFile(FileDialog openDlg)
		{
			var sourceFile = new FileStream(
				openDlg.FileName,
				FileMode.Open,
				FileAccess.Read);

			return Reader(sourceFile);
		}

		public string Reader(Stream sourceFile)
		{
			var sr = new StreamReader(sourceFile);

			try
			{
				return sr.ReadToEnd();
			}
			finally
			{
				sr.Close();
				sourceFile.Close();
			}
		}
	}
}
