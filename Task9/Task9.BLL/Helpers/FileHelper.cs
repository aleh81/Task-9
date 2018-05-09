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
	public class FileHelper
	{
		public static void SaveFile(string text)
		{
			var saveDlg = new SaveFileDialog
			{
				Title = "Browse for a save location",
				FileName = "Data.txt",
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
				InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.FullName,
				OverwritePrompt = true
			};

			if (saveDlg.ShowDialog() == DialogResult.OK)
			{
				var sw = new StreamWriter(saveDlg.FileName);
				sw.Write(text);
				sw.Close();
			}
		}
	}
}
