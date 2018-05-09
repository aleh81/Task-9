using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


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
				var sw = new StreamWriter(saveDlg.FileName);
				try
				{
					sw.Write(text);
				}
				finally
				{
					sw.Close();
				}
			}
		}

		public static void SaveFile(string path, string text)
		{
			var sw = new StreamWriter(path);
			try
			{
				sw.Write(text);
			}
			finally
			{
				sw.Close();
			}
		}
	}
}
