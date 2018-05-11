using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Task9.BLL.Services.Interfaces;

namespace Task9.BLL.Helpers
{
	public class FileHelper
	{
		public static string DefaultDirectory { get; } = Directory
			.GetParent(Directory.GetCurrentDirectory())
			.Parent?.FullName + "/";

		public  string DefaultFileName { get; } =
			"Data.txt";

		public  string DefaultFilePath =>
			DefaultDirectory + DefaultFileName;

		private static IFileManager _filemanager;

		public FileHelper(IFileManager manager)
		{
			_filemanager = manager;
		}
		public  void SaveFileDialog(string text)
		{
			if (text == null)
			{
				throw new NullReferenceException();
			}

			var saveDlg = new SaveFileDialog
			{
				Title = "Browse for a save location",
				FileName = DefaultFileName,
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
				InitialDirectory = DefaultDirectory,
				OverwritePrompt = true
			};

			if (saveDlg.ShowDialog() == DialogResult.OK)
			{
				_filemanager.SaveFile(text, saveDlg);
			}
		}


		public  string OpenFileDialog()
		{
			var openDlg = new OpenFileDialog
			{
				Title = "Browse for a file to open",
				FileName = DefaultFileName,
				Multiselect = false,
				InitialDirectory = DefaultDirectory,
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
			};

			if (openDlg.ShowDialog() == DialogResult.OK)
			{
				return _filemanager.OpenFile(openDlg);
			}

			return null;
		}




	}
}
