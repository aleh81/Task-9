using System;
using System.Windows;
using Task9.BLL.Helpers;
using Task9.BLL.Services;
using Task9.BLL.Services.Interfaces;

namespace Task9.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly IFileManager _fileManager;

		public MainWindow()
		{
			InitializeComponent();
			_fileManager = new FileManager();
		}

		private void Save_File(object sender, RoutedEventArgs e)
		{
			try
			{
				var fileHelper = new FileHelper(_fileManager);
				fileHelper.SaveFileDialog(TxbTextFile.Text);
			}
			catch (Exception exception)
			{
				TxbTextFile.Text = "ERROR: " + exception.Message;
			}
		}

		private void Open_File(object sender, RoutedEventArgs e)
		{
			try
			{
				var fileHelper = new FileHelper(_fileManager);
				TxbTextFile.Text =  fileHelper.OpenFileDialog();
			}
			catch (Exception exception)
			{
				TxbTextFile.Text = "ERROR: " + exception.Message;
			}
		}
	}
}
