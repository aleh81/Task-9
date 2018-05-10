using System;
using System.IO;
using System.Windows.Forms;

namespace Task9.BLL.Helpers
{
	public static class FileHelper
	{
		public static string DefaultDirectory { get; } = Directory
			.GetParent(Directory.GetCurrentDirectory())
			.Parent?.FullName + "/";

		public static string DefaultFileName { get; } =
			"Data.txt";

		public static string DefaultFilePath =>
			DefaultDirectory + DefaultFileName;

		public static void SaveFileDialog(string text)
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
				SaveFile(text, saveDlg);
			}
		}

		private static void SaveFile(string text, FileDialog saveDlg)
		{
			var sourceFile = new FileStream(
				saveDlg.FileName,
				FileMode.OpenOrCreate,
				FileAccess.Write);

            Writer(sourceFile, text);
		}

		private static void Writer(Stream sourceFile, string text)
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
	}
}
